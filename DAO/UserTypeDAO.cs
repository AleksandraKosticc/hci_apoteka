using hci_apoteka.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hci_apoteka.DAO
{
    class UserTypeDAO
    {
        private static readonly string SELECT_USERTYPE = "SELECT * FROM `korisnik_vrsta` ORDER BY IdKorisnikVrsta";
        private static readonly string INSERT_USERTYPE = "INSERT INTO `korisnik_vrsta`(NazivKorisnikVrsta, Opis) VALUES (@NazivKorisnikVrsta, @Opis)";
        private static readonly string UPDATE_USERTYPE = "UPDATE `korisnik_vrsta` SET NazivKorisnikVrsta=@NazivKorisnikVrsta, Opis=@Opis WHERE NazivKorisnikVrsta=@NazivKorisnikVrsta";
        
        public static List<UserType> GetUserType()
        {
            List<UserType> result = new List<UserType>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_USERTYPE;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new UserType()
                    {
                        IdKorisnikVrsta = reader.GetInt32(0),
                        NazivKorisnikVrsta = reader.GetString(1),
                        Opis = reader.IsDBNull(2) ? null : reader.GetString(2)
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

        public static List<UserType> GetComboBoxUserType()
        {
            List<UserType> result = new List<UserType>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT IdKorisnikVrsta, NazivKorisnikVrsta FROM `korisnik_vrsta` ORDER BY NazivKorisnikVrsta";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new UserType()
                    {
                        IdKorisnikVrsta = reader.GetInt32(0),
                        NazivKorisnikVrsta = reader.GetString(1)
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

        public static void AddUserType(UserType userType)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_USERTYPE;
                cmd.Parameters.AddWithValue("@NazivKorisnikVrsta", userType.NazivKorisnikVrsta);
                cmd.Parameters.AddWithValue("@Opis", userType.Opis);
                cmd.ExecuteNonQuery();
                userType.IdKorisnikVrsta = (int)cmd.LastInsertedId;
            }
            catch
            {
            }
            finally
            {
                MySqlUtil.Close(conn);
            }
        }

        public static void UpdateUserType(UserType usertype)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_USERTYPE;
                cmd.Parameters.AddWithValue("@NazivKorisnikVrsta", usertype.NazivKorisnikVrsta);
                cmd.Parameters.AddWithValue("@Opis", usertype.Opis);
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