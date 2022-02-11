using hci_apoteka.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci_apoteka.DAO
{
    class MedicineDAO
    {
        private static readonly string INSERT_MEDICINE = "INSERT INTO `artikal`(Barkod, NazivArtikla, Doza, Oblik, NabavnaCijena, ProdajnaCijena, IdProizvodjac, SlikaArtikla) VALUES (@Barkod, @NazivArtikla, @Doza, @Oblik, @NabavnaCijena, @ProdajnaCijena, @IdProizvodjac, @SlikaArtikla)";
        private static readonly string UPDATE_MEDICINE = "UPDATE `artikal` SET Barkod=@Barkod, NazivArtikla=@NazivArtikla, Doza=@Doza, Oblik=@Oblik, NabavnaCijena=@NabavnaCijena, ProdajnaCijena=@ProdajnaCijena, IdProizvodjac=@IdProizvodjac, SlikaArtikla=@SlikaArtikla WHERE Barkod=@Barkod";
        private static readonly string DELETE_MEDICINE = "DELETE FROM `artikal` WHERE Barkod=@Barkod";

        public static List<Medicine> GetMedicine(string filter)
        {
            List<Medicine> result = new List<Medicine>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText =
                @"SELECT a.Barkod, a.NazivArtikla, a.Zaliha, a.Doza, a.Oblik, a.NabavnaCijena, a.ProdajnaCijena, p.IdProizvodjac, p.Naziv
                  FROM artikal a
                  INNER JOIN `proizvodjac` p ON p.IdProizvodjac = a.IdProizvodjac
                  WHERE a.Barkod LIKE @str OR a.NazivArtikla LIKE @str OR p.Naziv LIKE @str
                  ORDER BY a.Barkod;";
                cmd.Parameters.AddWithValue("@str", filter + "%");
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Medicine()
                    {
                        Barkod = reader.GetInt32(0),
                        NazivArtikla = reader.GetString(1),
                        Zaliha = reader.GetInt32(2),
                        Doza = reader.GetString(3),
                        Oblik = reader.GetString(4),
                        NabavnaCijena = reader.GetDouble(5),
                        ProdajnaCijena = reader.GetDouble(6),
                        Company = new Company()
                        {
                            IdProizvodjac = reader.GetInt32(7),
                            Naziv = reader.GetString(8)
                        }
                    });
                }
            }
            catch
            {
            }
            finally
            {
                MySqlUtil.Close(reader, conn);
            }
            return result;
        }

        public static void AddMedicine(Medicine medicine)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_MEDICINE;
                cmd.Parameters.AddWithValue("@Barkod", medicine.Barkod);
                cmd.Parameters.AddWithValue("@NazivArtikla", medicine.NazivArtikla);
                cmd.Parameters.AddWithValue("@Doza", medicine.Doza);
                cmd.Parameters.AddWithValue("@Oblik", medicine.Oblik);
                cmd.Parameters.AddWithValue("@NabavnaCijena", medicine.NabavnaCijena);
                cmd.Parameters.AddWithValue("@ProdajnaCijena", medicine.ProdajnaCijena);
                cmd.Parameters.AddWithValue("@IdProizvodjac", medicine.Company.IdProizvodjac);
                cmd.Parameters.AddWithValue("@SlikaArtikla", medicine.SlikaArtikla);
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                MySqlUtil.Close(conn);
            }
        }

        public static void UpdateMedicine(Medicine medicine)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_MEDICINE;
                cmd.Parameters.AddWithValue("@Barkod", medicine.Barkod);
                cmd.Parameters.AddWithValue("@NazivArtikla", medicine.NazivArtikla);
                cmd.Parameters.AddWithValue("@Doza", medicine.Doza);
                cmd.Parameters.AddWithValue("@Oblik", medicine.Oblik);
                cmd.Parameters.AddWithValue("@NabavnaCijena", medicine.NabavnaCijena);
                cmd.Parameters.AddWithValue("@ProdajnaCijena", medicine.ProdajnaCijena);
                cmd.Parameters.AddWithValue("@IdProizvodjac", medicine.Company.IdProizvodjac);
                cmd.Parameters.AddWithValue("@SlikaArtikla", medicine.SlikaArtikla);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                MySqlUtil.Close(conn);
            }
        }

        public string GetPicture(int idMedicine)
        {
            string picture = "";
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT SlikaArtikla, Barkod FROM artikal WHERE Barkod='" + idMedicine + "';";

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    picture = reader.IsDBNull(0) ? null : reader.GetString(0);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                MySqlUtil.Close(conn);
            }
            return picture;
        }

        public static void DeleteMedicine(string barcode)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE_MEDICINE;
                cmd.Parameters.AddWithValue("@Barkod", barcode);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot delete this medicine");
            }
            finally
            {
                MySqlUtil.Close(conn);
            }
        }

        public static List<Medicine> GetBarcodeInvoice()
        {
            List<Medicine> result = new List<Medicine>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT a.Barkod, a.NazivArtikla, p.IdProizvodjac, p.Naziv FROM artikal a
                INNER JOIN `proizvodjac` p ON p.IdProizvodjac = a.IdProizvodjac;";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Medicine()
                    {
                        Barkod = reader.GetInt32(0),
                        NazivArtikla = reader.GetString(1),
                        Company = new Company()
                        {
                            IdProizvodjac = reader.GetInt32(2),
                            Naziv = reader.GetString(3)
                        }
                    });
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error " + e.Number + " has occured: " + e.Message, "Error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MySqlUtil.Close(reader, conn);
            }
            return result;
        }

        public static List<Medicine> GetItems(int barcodeSale)
        {
            List<Medicine> result = new List<Medicine>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT Barkod, NazivArtikla, ProdajnaCijena FROM artikal
                WHERE Barkod ='" + barcodeSale + "';";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Medicine()
                    {
                        Barkod = reader.GetInt32(0),
                        NazivArtikla = reader.GetString(1),
                        ProdajnaCijena = reader.GetDouble(2)
                    });
                }
            }
            catch
            {
            }
            finally
            {
                MySqlUtil.Close(reader, conn);
            }
            return result;
        }

        public static List<Medicine> GetBuyingPrice(int barcodeInvoice)
        {
            List<Medicine> result = new List<Medicine>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT Barkod, NabavnaCijena FROM artikal
                WHERE Barkod ='" + barcodeInvoice + "';";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Medicine()
                    {
                        Barkod = reader.GetInt32(0),
                        NabavnaCijena = reader.GetDouble(1)
                    });
                }
            }
            catch
            {
            }
            finally
            {
                MySqlUtil.Close(reader, conn);
            }
            return result;
        }

        public static List<Medicine> GetBarcodeItemSale(int barcodeForQty)
        {
            List<Medicine> result = new List<Medicine>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT Zaliha FROM artikal
                WHERE Barkod ='" + barcodeForQty + "';";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Medicine()
                    {
                        Zaliha = reader.GetInt32(0)

                    });
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                MySqlUtil.Close(reader, conn);
            }
            return result;
        }
    }
}