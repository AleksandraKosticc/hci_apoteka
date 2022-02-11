using hci_apoteka.DTO;
using hci_apoteka.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci_apoteka.DAO
{
    class CompanyDAO
    {
        private static readonly string SELECT_COMPANY = "SELECT * FROM `proizvodjac` ORDER BY Naziv";
        private static readonly string INSERT_COMPANY = "INSERT INTO `proizvodjac`(Naziv, Adresa, Telefon) VALUES (@Naziv, @Adresa, @Telefon)";
        private static readonly string DELETE_COMPANY = "DELETE FROM `proizvodjac` WHERE Naziv=@Naziv";
        private static readonly string UPDATE_COMPANY = "UPDATE `proizvodjac` SET Naziv=@Naziv, Adresa=@Adresa, Telefon=@Telefon WHERE Naziv=@Naziv";
       
        public static List<Company> GetCompany()
        {
            List<Company> result = new List<Company>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_COMPANY;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Company()
                    {
                        Naziv = reader.GetString(1),
                        Adresa = reader.GetString(2),
                        Telefon = reader.GetString(3)
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

        public static List<Company> GetComboBoxCompany()
        {
            List<Company> result = new List<Company>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT IdProizvodjac, Naziv FROM `proizvodjac` ORDER BY IdProizvodjac";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Company()
                    {
                        IdProizvodjac = reader.GetInt32(0),
                        Naziv = reader.GetString(1)
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

        public static void AddCompany(Company company)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_COMPANY;
                cmd.Parameters.AddWithValue("@Naziv", company.Naziv);
                cmd.Parameters.AddWithValue("@Adresa", company.Adresa);
                cmd.Parameters.AddWithValue("@Telefon", company.Telefon);
                cmd.ExecuteNonQuery();
                company.IdProizvodjac = (int)cmd.LastInsertedId;
            }
            catch
            {
            }
            finally
            {
                MySqlUtil.Close(conn);
            }
        }

        public static void DeleteCompany(string companyName)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE_COMPANY;
                cmd.Parameters.AddWithValue("@Naziv", companyName);
                int resultRowCount;
                resultRowCount  = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot delete this company");
            }
            finally
            {
                MySqlUtil.Close(conn);
            }
        }

        public static void UpdateCompany(Company company)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_COMPANY;
                cmd.Parameters.AddWithValue("@Naziv", company.Naziv);
                cmd.Parameters.AddWithValue("@Adresa", company.Adresa);
                cmd.Parameters.AddWithValue("@Telefon", company.Telefon);
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
    }
}