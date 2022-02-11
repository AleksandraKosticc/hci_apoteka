using hci_apoteka.DAO;
using hci_apoteka.DTO;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci_apoteka.Forms
{
    public partial class FormSales : Form
    {
        
        public FormSales()
        {
            InitializeComponent();
            LoadSelectedLanguageStrings();
        }

        private void LoadSelectedLanguageStrings()
        {
            if (Program.LanguageResxSet != null)
            {
                lbBarcode.Text = Program.LanguageResxSet.GetString("barcode");
                lbPrice.Text = Program.LanguageResxSet.GetString("cellingprice");
                lbProduct.Text = Program.LanguageResxSet.GetString("product");
                lbQuantity.Text = Program.LanguageResxSet.GetString("quantity");
                lbTotalPrice.Text = Program.LanguageResxSet.GetString("totalprice");
                buttonCreateBill.Text = Program.LanguageResxSet.GetString("createbill");
                lbCashRegistar.Text = Program.LanguageResxSet.GetString("cashregister");

                columnBillBarcode.HeaderText = Program.LanguageResxSet.GetString("barcode");
                columnBillName.HeaderText = Program.LanguageResxSet.GetString("product");
                columnBillPrice.HeaderText = Program.LanguageResxSet.GetString("cellingprice");
                columnBillQty.HeaderText = Program.LanguageResxSet.GetString("quantity");
            }
        }
        private void FormKasa_Load(object sender, EventArgs e)
        {
            textBoxBarcode.Visible = false;
            textBoxName.Visible = false;
            textBoxPrice.Visible = false;
            numericUpDowQuantity.Visible = false;
            lbBarcode.Visible = false;
            lbPrice.Visible = false;
            lbQuantity.Visible = false;
            lbProduct.Visible = false;
            iconButtonAdd.Visible = false; 
            iconButtonDelete.Visible = false; 
            buttonCreateBill.Enabled = false;
            numericUpDowQuantity.Value = 1;
            textBoxTotalPrice.Text = "0.00";
            labelUser.Text = FormLogin.id;              
        }
     
        private void IconButtonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBarcode.Text.Trim()) ||
                string.IsNullOrEmpty(numericUpDowQuantity.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxPrice.Text.Trim()))
            {
                MetroMessageBox.Show(this, "You must fill in all fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                buttonCreateBill.Enabled = true;
                int barcode = Convert.ToInt32(textBoxBarcode.Text);
                int qty = int.Parse(numericUpDowQuantity.Value.ToString());
                double price = double.Parse(textBoxPrice.Text);
                string name = textBoxName.Text;
                int zaliha;

                foreach (var p in MedicineDAO.GetBarcodeItemSale(barcode))
                {
                    zaliha = p.Zaliha;
                    if (qty <= zaliha)
                    {
                        iconButtonDelete.Visible = true;
                        for (int i = 0; i < dataGridViewSales.Rows.Count; i++)
                        {
                            var row = dataGridViewSales.Rows[i];
                            if (barcode == int.Parse(dataGridViewSales.Rows[i].Cells[0].Value.ToString()))
                            {
                                dataGridViewSales.Rows.Remove(row);
                                break;
                            }
                        }
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dataGridViewSales);
                        newRow.Cells[0].Value = barcode;
                        newRow.Cells[1].Value = name;
                        newRow.Cells[2].Value = price;
                        newRow.Cells[3].Value = qty;
                        dataGridViewSales.Rows.Add(newRow);

                        ClearItem();

                        double sum = 0.00;
                        for (int row = 0; row < dataGridViewSales.Rows.Count; row++)
                        {
                            sum += Convert.ToDouble(dataGridViewSales.Rows[row].Cells[2].Value) * int.Parse(dataGridViewSales.Rows[row].Cells[3].Value.ToString());
                        }
                        textBoxTotalPrice.Text = sum.ToString();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Not enough in stock", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearItem()
        {
            textBoxBarcode.Clear();
            textBoxName.Clear();
            numericUpDowQuantity.Value = 1;
            textBoxPrice.Clear();
        }

        private void IconButtonDelete_Click(object sender, EventArgs e)
        {
            dataGridViewSales.Rows.RemoveAt(dataGridViewSales.SelectedRows[0].Index);
            double sum = 0.00;
            for (int row = 0; row < dataGridViewSales.Rows.Count; row++)
            {
                sum += Convert.ToDouble(dataGridViewSales.Rows[row].Cells[2].Value) * int.Parse(dataGridViewSales.Rows[row].Cells[3].Value.ToString());
            }
            textBoxTotalPrice.Text = sum.ToString();
        }

        private void IconButtonCreateBill_Click(object sender, EventArgs e)
        {           
            for (int row = 0; row < dataGridViewSales.Rows.Count; row++)
            {
                var item = new ItemBill()
                {
                    Barkod = Convert.ToInt32(dataGridViewSales.Rows[row].Cells[0].Value),
                    Cijena = Convert.ToDouble(dataGridViewSales.Rows[row].Cells[2].Value),
                    Kolicina = int.Parse(dataGridViewSales.Rows[row].Cells[3].Value.ToString())
                };
                ItemBillDAO.AddItemBill(item);
            }
            dataGridViewSales.Rows.Clear();
            textBoxTotalPrice.Text = "0.00";
            textBoxBarcode.Visible = false;
            textBoxName.Visible = false;
            textBoxPrice.Visible = false;
            numericUpDowQuantity.Visible = false;
            lbBarcode.Visible = false;
            lbPrice.Visible = false;
            lbQuantity.Visible = false;
            lbProduct.Visible = false;
            iconButtonAdd.Visible = false;
            iconButtonDelete.Visible = false;
            buttonCreateBill.Enabled = false;
            buttonNewBill.Enabled = true;
        }

        private void ButtonNewBill_Click(object sender, EventArgs e)
        {
            var bill = new Bill()
            {
                IdKorisnika = labelUser.Text
            };
            BillDAO.AddBill(bill);

            buttonNewBill.Enabled = false;
            textBoxBarcode.Visible = true;
            textBoxName.Visible = true;
            textBoxPrice.Visible = true;
            textBoxName.Enabled = false;
            textBoxPrice.Enabled = false;
            numericUpDowQuantity.Visible = true;
            lbBarcode.Visible = true;
            lbPrice.Visible = true;
            lbQuantity.Visible = true;
            lbProduct.Visible = true;
        }

        private void TextBoxBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                foreach (var p in MedicineDAO.GetItems(Convert.ToInt32(textBoxBarcode.Text)))
                {
                    textBoxName.Text = p.NazivArtikla;
                    textBoxPrice.Text = p.ProdajnaCijena.ToString();
                }
                iconButtonAdd.Visible = true;
            }           
        }
    }
}