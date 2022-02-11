using hci_apoteka.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci_apoteka.DAO
{
    class EmployeeDAO
    {
        private static readonly string SELECT_EMPLOYEES = @"SELECT k.IdKorisnika, k.KorisnickoIme, k.Lozinka, k.Ime, k.Prezime, k.JMBG, k.Email, k.AdresaStanovanja, kv.IdKorisnikVrsta, kv.NazivKorisnikVrsta, k.Slika
                  FROM korisnik k
                  INNER JOIN `korisnik_vrsta` kv ON kv.IdKorisnikVrsta = k.IdKorisnikVrsta
                  WHERE k.KorisnickoIme LIKE @str OR k.JMBG LIKE @str OR k.Prezime LIKE @str
                  ORDER BY k.KorisnickoIme";
        private static readonly string INSERT_EMPLOYEE = "INSERT INTO `korisnik`(KorisnickoIme, Lozinka, Ime, Prezime, JMBG, Email, AdresaStanovanja, IdKorisnikVrsta, Slika) VALUES (@KorisnickoIme, @Lozinka, @Ime, @Prezime, @JMBG, @Email, @AdresaStanovanja, @IdKorisnikVrsta, @Slika)";
        private static readonly string UPDATE_EMPLOYEE = "UPDATE `korisnik` SET KorisnickoIme=@KorisnickoIme, Lozinka=@Lozinka, Ime=@Ime, Prezime=@Prezime, JMBG=@JMBG, Email=@Email, AdresaStanovanja=@AdresaStanovanja, IdKorisnikVrsta=@IdKorisnikVrsta, Slika=@Slika WHERE KorisnickoIme=@KorisnickoIme";

        public static List<Employee> GetEmployee(string filter)
        {
            List<Employee> result = new List<Employee>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_EMPLOYEES;
                cmd.Parameters.AddWithValue("@str", filter + "%");
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Employee()
                    {
                        KorisnickoIme = reader.GetString(1),
                        Lozinka = reader.GetString(2),
                        Ime = reader.GetString(3),
                        Prezime = reader.GetString(4),
                        JMBG = reader.GetString(5),
                        Email = reader.GetString(6),
                        AdresaStanovanja = reader.GetString(7),
                        UserType = new UserType()
                        {
                            IdKorisnikVrsta = reader.GetInt32(8),
                            NazivKorisnikVrsta = reader.GetString(9)
                        },
                        Slika = reader.IsDBNull(10) ? null : reader.GetString(10),

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

        public static void AddEmployee(Employee employee)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_EMPLOYEE;
                cmd.Parameters.AddWithValue("@KorisnickoIme", employee.KorisnickoIme);
                cmd.Parameters.AddWithValue("@Lozinka", employee.Lozinka);
                cmd.Parameters.AddWithValue("@Ime", employee.Ime);
                cmd.Parameters.AddWithValue("@Prezime", employee.Prezime);
                cmd.Parameters.AddWithValue("@JMBG", employee.JMBG);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@AdresaStanovanja", employee.AdresaStanovanja);
                cmd.Parameters.AddWithValue("@IdKorisnikVrsta", employee.UserType.IdKorisnikVrsta);
                cmd.Parameters.AddWithValue("@Slika", employee.Slika);
                cmd.ExecuteNonQuery();
                employee.IdKorisnika = (int)cmd.LastInsertedId;
            }
            catch
            {
            }
            finally
            {
                MySqlUtil.Close(conn);
            }
        }

        public static void UpdateEmployee(Employee employee)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_EMPLOYEE;
                cmd.Parameters.AddWithValue("@KorisnickoIme", employee.KorisnickoIme);
                cmd.Parameters.AddWithValue("@Lozinka", employee.Lozinka);
                cmd.Parameters.AddWithValue("@Ime", employee.Ime);
                cmd.Parameters.AddWithValue("@Prezime", employee.Prezime);
                cmd.Parameters.AddWithValue("@JMBG", employee.JMBG);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@AdresaStanovanja", employee.AdresaStanovanja);
                cmd.Parameters.AddWithValue("@IdKorisnikVrsta", employee.UserType.IdKorisnikVrsta);
                cmd.Parameters.AddWithValue("@Slika", employee.Slika);
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

        public string GetPicture(string idEmployee)
        {
            string picture = "";
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Slika, KorisnickoIme FROM korisnik WHERE KorisnickoIme='" + idEmployee + "';";

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

        public static List<Employee> GetUser()
        {
            List<Employee> result = new List<Employee>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT k.IdKorisnika, k.KorisnickoIme, k.Lozinka, k.Ime, k.Prezime, k.JMBG, k.Email, k.AdresaStanovanja, kv.IdKorisnikVrsta, kv.NazivKorisnikVrsta, k.Slika
                  FROM korisnik k
                  INNER JOIN `korisnik_vrsta` kv ON kv.IdKorisnikVrsta = k.IdKorisnikVrsta;";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Employee()
                    {
                        KorisnickoIme = reader.GetString(1),
                        Lozinka = reader.GetString(2),
                        Ime = reader.GetString(3),
                        Prezime = reader.GetString(4),
                        JMBG = reader.GetString(5),
                        Email = reader.GetString(6),
                        AdresaStanovanja = reader.GetString(7),
                        UserType = new UserType()
                        {
                            IdKorisnikVrsta = reader.GetInt32(8),
                            NazivKorisnikVrsta = reader.GetString(9)
                        },
                        Slika = reader.IsDBNull(10) ? null : reader.GetString(10),

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
    }
}