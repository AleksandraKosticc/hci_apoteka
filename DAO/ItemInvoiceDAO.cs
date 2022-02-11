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
    class ItemInvoiceDAO
    {
        public static bool AddItemInvoice(ItemInvoice item)
        {
            bool result = false;
            MySqlConnection conn;
            MySqlCommand cmd;
            String upit = "call dodaj_faktura_stavka(@Barkod, @Kolicina, @CijenaStavke);";

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = upit;
                cmd.Parameters.AddWithValue("@Barkod", item.Barkod);
                cmd.Parameters.AddWithValue("@Kolicina", item.Kolicina);
                cmd.Parameters.AddWithValue("@CijenaStavke", item.CijenaStavke);
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