using hci_apoteka.DAO;
using hci_apoteka.DTO;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci_apoteka.Forms
{
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
            LoadSelectedLanguageStrings();
            FillGridInvoice();
            FillComboBoxCompany();
        }

        private void LoadSelectedLanguageStrings()
        {
            if (Program.LanguageResxSet != null)
            {
                lbBarcode.Text = Program.LanguageResxSet.GetString("barcode");
                lbBuyingPrice.Text = Program.LanguageResxSet.GetString("buyingprice");
                lbQuantity.Text = Program.LanguageResxSet.GetString("quantity");
                lbCompany.Text = Program.LanguageResxSet.GetString("company");
                gbNewInvoice.Text = Program.LanguageResxSet.GetString("newinvoice");

                columnDate.HeaderText = Program.LanguageResxSet.GetString("date");
                columnBarcode.HeaderText = Program.LanguageResxSet.GetString("barcode");
                columnEmployee.HeaderText = Program.LanguageResxSet.GetString("employees");
                columnName.HeaderText = Program.LanguageResxSet.GetString("product");
                columnCompany.HeaderText = Program.LanguageResxSet.GetString("company");
                columnNoInvoice.HeaderText = Program.LanguageResxSet.GetString("noinvoice");
                columnPrice.HeaderText = Program.LanguageResxSet.GetString("buyingprice");
                columnQty.HeaderText = Program.LanguageResxSet.GetString("quantity");
                columnTotalPrice.HeaderText = Program.LanguageResxSet.GetString("totalprice");
            }
        }
        private void FormInvoice_Load(object sender, EventArgs e)
        {
            iconButtonDeleteInvoice.Visible = false;
            numericUpDownQuantity.Value = 1;
            label1.Text = FormLogin.id;
        }

        private void IconButtonDeleteInvoice_Click(object sender, EventArgs e)
        {
            metroGridItemInvoice.Rows.RemoveAt(metroGridItemInvoice.SelectedRows[0].Index);
        }

        void FillGridInvoice()
        {
            metroGridInvoice.Rows.Clear();
            foreach (var p in InvoiceDAO.GetInvoice())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(metroGridInvoice, p.IdFaktura, p.DatumIzdavanja, p.IznosRacuna, p.Company.Naziv, p.Employee.KorisnickoIme);
                metroGridInvoice.Rows.Add(row);
            }
        }

        void FillComboBoxCompany()
        {
            comboBoxCompany.DataSource = CompanyDAO.GetComboBoxCompany();
        }

        private void IconButtonAddInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxBarcodeInvoice.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxPriceInvoice.Text.Trim()))
                {
                    MetroMessageBox.Show(this, "You must fill in all fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int barcode = Convert.ToInt32(textBoxBarcodeInvoice.Text);
                    int qty = int.Parse(numericUpDownQuantity.Value.ToString());
                    double price = Convert.ToDouble(textBoxPriceInvoice.Text);
                    string proizvodjac = comboBoxCompany.SelectedItem.ToString();
                    string name = "";
                    bool exists = false;
                    foreach (var p in MedicineDAO.GetBarcodeInvoice())
                    {

                        if (barcode == p.Barkod && proizvodjac == p.Company.Naziv)
                        {
                            name = p.NazivArtikla;
                            exists = true;
                            break;
                        }
                    }
                    if (exists)
                    {
                        for (int i = 0; i < metroGridItemInvoice.Rows.Count; i++)
                        {
                            var row = metroGridItemInvoice.Rows[i];
                            if (barcode == int.Parse(metroGridItemInvoice.Rows[i].Cells[0].Value.ToString()))
                            {
                                metroGridItemInvoice.Rows.Remove(row);
                                break;
                            }
                        }
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(metroGridItemInvoice);
                        newRow.Cells[0].Value = barcode;
                        newRow.Cells[1].Value = name;
                        newRow.Cells[2].Value = price;
                        newRow.Cells[3].Value = qty;
                        metroGridItemInvoice.Rows.Add(newRow);
                        iconButtonDeleteInvoice.Visible = true;
                        ClearItem();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "The drug is not from the company", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MetroMessageBox.Show(this, "Type data not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
        
        private void ClearItem()
        {
            textBoxBarcodeInvoice.Clear();
            numericUpDownQuantity.Value = 1;
            textBoxPriceInvoice.Clear();
        }

        private void TextBoxBarcodeInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                foreach (var p in MedicineDAO.GetBuyingPrice(Convert.ToInt32(textBoxBarcodeInvoice.Text)))
                {
                    textBoxPriceInvoice.Text = p.NabavnaCijena.ToString();
                }
            }
        }

        private void IconButtonSaveInvoice_Click(object sender, EventArgs e)
        {
            int i = comboBoxCompany.SelectedIndex + 1;
            
            var invoice = new Invoice()
            {
                IdProizvodjac = i,
                IdKorisnika = label1.Text
            };
            
            InvoiceDAO.AddInvoice(invoice);

            for (int row = 0; row < metroGridItemInvoice.Rows.Count; row++)
            {
                var item = new ItemInvoice()
                {
                    Barkod = Convert.ToInt32(metroGridItemInvoice.Rows[row].Cells[0].Value),
                    CijenaStavke = Convert.ToDouble(metroGridItemInvoice.Rows[row].Cells[2].Value),
                    Kolicina = int.Parse(metroGridItemInvoice.Rows[row].Cells[3].Value.ToString()),
                };
                ItemInvoiceDAO.AddItemInvoice(item);
            }
            metroGridItemInvoice.Rows.Clear();                   
            FillGridInvoice();
            MetroMessageBox.Show(this, "Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            iconButtonDeleteInvoice.Visible = false;
        }
    }
}