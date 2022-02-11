using hci_apoteka.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci_apoteka.DAO
{
    class InvoiceDAO
    {
        private static readonly string INSERT_INVOICE = "INSERT INTO `faktura`(IdProizvodjac, IdKorisnika) VALUES (@IdProizvodjac, @IdKorisnika)";
        private static readonly string SELECT_INVOICE_ITEM = @"SELECT f.IdFaktura, f.DatumIzdavanja, f.IznosRacuna, p.IdProizvodjac, p.Naziv, k.IdKorisnika, k.KorisnickoIme
                  FROM faktura f
                  INNER JOIN `proizvodjac` p ON p.IdProizvodjac = f.IdProizvodjac
                  INNER JOIN `korisnik` k ON k.IdKorisnika = f.IdKorisnika ORDER BY f.IdFaktura";
        public static List<Invoice> GetInvoice()
        {
            List<Invoice> result = new List<Invoice>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_INVOICE_ITEM;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Invoice()
                    {
                        IdFaktura = reader.GetInt32(0),
                        DatumIzdavanja = (DateTime)reader.GetMySqlDateTime(1),
                        IznosRacuna = reader.GetDecimal(2),
                        Company = new Company()
                        {
                            IdProizvodjac = reader.GetInt32(3),
                            Naziv = reader.GetString(4),
                        },
                        Employee = new Employee()
                        {
                            IdKorisnika = reader.GetInt32(5),
                            KorisnickoIme = reader.GetString(6)
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

        public static void AddInvoice(Invoice invoice)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_INVOICE;
                cmd.Parameters.AddWithValue("@IdProizvodjac", invoice.IdProizvodjac);
                cmd.Parameters.AddWithValue("@IdKorisnika", invoice.IdKorisnika);
                cmd.ExecuteNonQuery();
                invoice.IdFaktura = (int)cmd.LastInsertedId;
            }
            catch
            {
            }
            finally
            {
                MySqlUtil.Close(conn);
            }
        }
    }
}