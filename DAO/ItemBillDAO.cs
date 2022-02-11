using hci_apoteka.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci_apoteka.DAO
{
    class ItemBillDAO
    {
        
        public static bool AddItemBill(ItemBill item)
        {
            bool result = false;
            MySqlConnection conn;
            MySqlCommand cmd;
            String upit = "call dodaj_racun_stavka(@Barkod, @Cijena, @Kolicina);";

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = upit;
                cmd.Parameters.AddWithValue("@Barkod", item.Barkod);
                cmd.Parameters.AddWithValue("@Cijena", item.Cijena);
                cmd.Parameters.AddWithValue("@Kolicina", item.Kolicina);
                result = cmd.ExecuteNonQuery() == 1;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error " + e.Number + " has occured: " + e.Message, "Error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}