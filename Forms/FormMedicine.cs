using hci_apoteka.DAO;
using hci_apoteka.DTO;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci_apoteka.Forms
{
    public partial class FormMedicine : Form
    {
        readonly MedicineDAO medicine = new MedicineDAO();
        string imageUrl = null;

        public FormMedicine()
        {
            InitializeComponent();
            LoadSelectedLanguageStrings();
            FillGrid();
            FillComboBox();
        }

        private void LoadSelectedLanguageStrings()
        {
            if (Program.LanguageResxSet != null)
            {
                lbBarcode.Text = Program.LanguageResxSet.GetString("barcode");
                lbProductName.Text = Program.LanguageResxSet.GetString("product");
                lbBuyingPrice.Text = Program.LanguageResxSet.GetString("buyingprice");
                lbCellingPrice.Text = Program.LanguageResxSet.GetString("cellingprice");
                lbCompany.Text = Program.LanguageResxSet.GetString("company");
                lbDosage.Text = Program.LanguageResxSet.GetString("dosage");
                lbAvailableStrength.Text = Program.LanguageResxSet.GetString("availablestrength");
                
                columnAvaibleStrength.HeaderText = Program.LanguageResxSet.GetString("availablestrength");
                columnBarcode.HeaderText = Program.LanguageResxSet.GetString("barcode");
                columnBuying.HeaderText = Program.LanguageResxSet.GetString("buyingprice");
                columnCelling.HeaderText = Program.LanguageResxSet.GetString("cellingprice");
                columnCompany.HeaderText = Program.LanguageResxSet.GetString("company");
                columnDosage.HeaderText = Program.LanguageResxSet.GetString("dosage");
                columnName.HeaderText = Program.LanguageResxSet.GetString("product");
                columnStoke.HeaderText = Program.LanguageResxSet.GetString("stock");
                iconButtonBrowseMedicine.Text = Program.LanguageResxSet.GetString("browse");
                groupBoxMedicine.Text = Program.LanguageResxSet.GetString("medicine");
            }
        }

        private void IconButtonBrowseMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "Files|*.jpg;*.jpeg;*.png;"
                };

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string imageLocation = dialog.FileName;
                    pictureBoxMedicine.ImageLocation = imageLocation;
                    imageUrl = dialog.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greska", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IconButtonDeleteMedicine_Click(object sender, EventArgs e)
        {
                MedicineDAO.DeleteMedicine(metroGridMedicine.SelectedRows[0].Cells[0].Value.ToString());
                metroGridMedicine.Rows.RemoveAt(metroGridMedicine.SelectedRows[0].Index);
                FillGrid();
        }

        private void IconButtonAddMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxBarcode.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxNameMedicine.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxAvailableStrength.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxDosage.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxBuyingPrice.Text.Trim()) ||
                    string.IsNullOrEmpty(textBoxCellingPrice.Text.Trim()))
                {
                    MetroMessageBox.Show(this, "You must fill in all fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int barcode = Convert.ToInt32(textBoxBarcode.Text);

                    int barcodeDb;
                    bool exists = false;
                    foreach (var p in MedicineDAO.GetItems(barcode))
                    {
                        barcodeDb = p.Barkod;
                        if (barcode == barcodeDb)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (exists)
                    {
                        MetroMessageBox.Show(this, "The product exists in the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var medicine = new Medicine()
                        {
                            Barkod = Convert.ToInt32(textBoxBarcode.Text),
                            NazivArtikla = textBoxNameMedicine.Text,
                            Doza = textBoxDosage.Text,
                            Oblik = textBoxAvailableStrength.Text,
                            NabavnaCijena = Convert.ToDouble(textBoxBuyingPrice.Text.Replace(".", ",")),
                            ProdajnaCijena = Convert.ToDouble(textBoxCellingPrice.Text.Replace(".", ",")),
                            Company = (Company)comboBoxCompany.SelectedItem,
                            SlikaArtikla = imageUrl
                        };
                        MedicineDAO.AddMedicine(medicine);                       
                        FillGrid();
                        MetroMessageBox.Show(this, "Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        ClearMedicine();
                    }
                }
            }
            catch (FormatException)
            {
                MetroMessageBox.Show(this, "Type data not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillGrid()
        {
            metroGridMedicine.Rows.Clear();
            foreach (var p in MedicineDAO.GetMedicine(tbFilter.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(metroGridMedicine, p.Barkod, p.NazivArtikla, p.Zaliha, p.Doza, p.Oblik, p.NabavnaCijena, p.ProdajnaCijena, p.Company.Naziv);
                metroGridMedicine.Rows.Add(row);
            }
        }

        private void TbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        void FillComboBox()
        {
            comboBoxCompany.DataSource = CompanyDAO.GetComboBoxCompany();
        }

        private void MetroGridMedicine_DoubleClick(object sender, EventArgs e)
        {
            ClearMedicine();
            textBoxBarcode.Text = metroGridMedicine.CurrentRow.Cells[0].Value.ToString();
            textBoxNameMedicine.Text = metroGridMedicine.CurrentRow.Cells[1].Value.ToString();
            textBoxDosage.Text = metroGridMedicine.CurrentRow.Cells[3].Value.ToString();
            textBoxAvailableStrength.Text = metroGridMedicine.CurrentRow.Cells[4].Value.ToString();
            textBoxBuyingPrice.Text = metroGridMedicine.CurrentRow.Cells[5].Value.ToString();
            textBoxCellingPrice.Text = metroGridMedicine.CurrentRow.Cells[6].Value.ToString();
            comboBoxCompany.Text = metroGridMedicine.CurrentRow.Cells[7].Value.ToString();
            int id = Convert.ToInt32(metroGridMedicine.CurrentRow.Cells[0].Value.ToString());
            string pathImage = medicine.GetPicture(id);
            if (pathImage != null && File.Exists(pathImage))
            {
                pictureBoxMedicine.Image = new Bitmap(pathImage);
                pictureBoxMedicine.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBoxMedicine.Image = Properties.Resources.medicine;
            }
        }

        private void ClearMedicine()
        {
            textBoxBarcode.Clear();
            textBoxNameMedicine.Clear();
            textBoxDosage.Clear();
            textBoxAvailableStrength.Clear();
            textBoxBuyingPrice.Clear();
            textBoxCellingPrice.Clear();
            comboBoxCompany.SelectedIndex = 0;
            pictureBoxMedicine.Image = Properties.Resources.medicine;
        }

        private void IconButtonEditMedicine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBarcode.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxNameMedicine.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxAvailableStrength.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxDosage.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxBuyingPrice.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxCellingPrice.Text.Trim()))
            {
                MetroMessageBox.Show(this, "You must fill in all fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var medicine = new Medicine()
                {
                    Barkod = Convert.ToInt32(textBoxBarcode.Text),
                    NazivArtikla = textBoxNameMedicine.Text,
                    Doza = textBoxDosage.Text,
                    Oblik = textBoxAvailableStrength.Text,
                    NabavnaCijena = Convert.ToDouble(textBoxBuyingPrice.Text.Replace(".", ",")),
                    ProdajnaCijena = Convert.ToDouble(textBoxCellingPrice.Text.Replace(".", ",")),
                    Company = (Company)comboBoxCompany.SelectedItem,
                    SlikaArtikla = imageUrl
                };
                MedicineDAO.UpdateMedicine(medicine);
                FillGrid();               
                MetroMessageBox.Show(this, "Successfully modified", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                ClearMedicine();
            }
        }

        private void MetroGridMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(metroGridMedicine.CurrentRow.Cells[0].Value.ToString());
            string pathImage = medicine.GetPicture(id);
            if (pathImage != null && File.Exists(pathImage))
            {
                pictureBoxMedicine.Image = new Bitmap(pathImage);
                pictureBoxMedicine.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBoxMedicine.Image = Properties.Resources.medicine;
            }
        }
        private void IconPictureBoxRefresh_Click(object sender, EventArgs e)
        {
            textBoxBarcode.Clear();
            textBoxNameMedicine.Clear();
            textBoxDosage.Clear();
            textBoxAvailableStrength.Clear();
            textBoxBuyingPrice.Clear();
            textBoxCellingPrice.Clear();
            comboBoxCompany.SelectedIndex = 0;
            pictureBoxMedicine.Image = Properties.Resources.medicine;
        }
    }
}