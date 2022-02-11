using hci_apoteka.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hci_apoteka.DAO
{
    class BillDAO
    {
        private static readonly string INSERT_BILL = "INSERT INTO `racun`(IdKorisnika) VALUES (@IdKorisnika)";

        public static void AddBill(Bill bill)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT_BILL;
                cmd.Parameters.AddWithValue("@IdKorisnika", bill.IdKorisnika);
                cmd.ExecuteNonQuery();
                bill.IdRacuna = (int)cmd.LastInsertedId;
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