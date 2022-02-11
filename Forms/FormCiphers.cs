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
    public partial class FormCiphers : Form
    {
        public FormCiphers()
        {
            InitializeComponent();
            LoadSelectedLanguageStrings();
            FillGridCompany();
            FillGridUserType();
        }

        private void LoadSelectedLanguageStrings()
        {
            if (Program.LanguageResxSet != null)
            {
                lbCompanyName.Text = Program.LanguageResxSet.GetString("company");
                lbDescription.Text = Program.LanguageResxSet.GetString("description");
                lbNameUserTypes.Text = Program.LanguageResxSet.GetString("name");
                lbPhone.Text = Program.LanguageResxSet.GetString("phone");
                lbState.Text = Program.LanguageResxSet.GetString("state");
                tabPage1.Text = Program.LanguageResxSet.GetString("companies");
                tabPage2.Text = Program.LanguageResxSet.GetString("usertypes");

                columnDescription.HeaderText = Program.LanguageResxSet.GetString("description");
                columnNameCompany.HeaderText = Program.LanguageResxSet.GetString("company");
                columnNameUserType.HeaderText = Program.LanguageResxSet.GetString("name");
                columnPhone.HeaderText = Program.LanguageResxSet.GetString("phone");
                columnStateCompany.HeaderText = Program.LanguageResxSet.GetString("state");
                columnNoUsers.HeaderText = Program.LanguageResxSet.GetString("number");
            }
        }

        void FillGridCompany()
        {
            metroGridCompany.Rows.Clear();
            foreach (var p in CompanyDAO.GetCompany())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(metroGridCompany, p.Naziv, p.Adresa, p.Telefon);
                metroGridCompany.Rows.Add(row);
            }
        }

        void FillGridUserType()
        {
            metroGridUserType.Rows.Clear();
            foreach (var p in UserTypeDAO.GetUserType())
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(metroGridUserType, p.IdKorisnikVrsta, p.NazivKorisnikVrsta, p.Opis);
                metroGridUserType.Rows.Add(row);
            }
        }

        private void IconButtonAddUserTypes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserTypes.Text.Trim()))
            {
                MetroMessageBox.Show(this, "You must fill in all fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var usertype = new UserType()
                {
                    NazivKorisnikVrsta = textBoxUserTypes.Text,
                    Opis = textBoxDescription.Text
                };
                UserTypeDAO.AddUserType(usertype);
                FillGridUserType();
                MetroMessageBox.Show(this, "Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                ClearUserType();
            }
        }

        private void ClearUserType()
        {
            textBoxUserTypes.Clear();
            textBoxDescription.Clear();
        }

        private void IconButtonEditUserTypes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserTypes.Text.Trim()))
            {
                MetroMessageBox.Show(this, "You must fill in all fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var usertype = new UserType()
                {
                    NazivKorisnikVrsta = textBoxUserTypes.Text,
                    Opis = textBoxDescription.Text
                };
                UserTypeDAO.UpdateUserType(usertype);
                FillGridUserType();              
                MetroMessageBox.Show(this, "Successfully modified", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                ClearUserType();
            }
        }

        private void ClearCompany()
        {
            textBoxNameCompany.Clear();
            textBoxState.Clear();
            textBoxPhone.Clear();
        }

        private void IconButtonAddCompany_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameCompany.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxState.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxPhone.Text.Trim()))
            {
                MetroMessageBox.Show(this, "You must fill in all fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = textBoxNameCompany.Text;
                string nameDb;
                bool exits = false;
                foreach (var p in CompanyDAO.GetCompany())
                {
                    nameDb = p.Naziv;
                    if (name == nameDb)
                    {
                        exits = true;
                        break;
                    }
                }
                if (exits)
                {
                    MetroMessageBox.Show(this, "The company exists in the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                
                    var company = new Company()
                    {
                        Naziv = textBoxNameCompany.Text,
                        Adresa = textBoxState.Text,
                        Telefon = textBoxPhone.Text
                    };
                    CompanyDAO.AddCompany(company);
                    FillGridCompany();
                    MetroMessageBox.Show(this, "Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }                                     
            }
            ClearCompany();
        }
    
       
        private void IconButtonDeleteCompany_Click(object sender, EventArgs e)
        {           
                CompanyDAO.DeleteCompany(metroGridCompany.SelectedRows[0].Cells[0].Value.ToString());
                metroGridCompany.Rows.RemoveAt(metroGridCompany.SelectedRows[0].Index);
                FillGridCompany();
        }

        private void IconButtonEditCompany_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameCompany.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxState.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxPhone.Text.Trim()))
            {
                MetroMessageBox.Show(this, "You must fill in all fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var company = new Company()
                {
                    Naziv = textBoxNameCompany.Text,
                    Adresa = textBoxState.Text,
                    Telefon = textBoxPhone.Text
                };
                CompanyDAO.UpdateCompany(company);
                FillGridCompany();
                ClearCompany();
                MetroMessageBox.Show(this, "Successfully update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void MetroGridCompany_DoubleClick(object sender, EventArgs e)
        {
            if (metroGridCompany.CurrentRow.Index != -1)
            {
                textBoxNameCompany.Text = metroGridCompany.CurrentRow.Cells[0].Value.ToString();
                textBoxState.Text = metroGridCompany.CurrentRow.Cells[1].Value.ToString();
                textBoxPhone.Text = metroGridCompany.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void MetroGridUserType_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (metroGridUserType.CurrentRow.Index != -1)
            {
                textBoxUserTypes.Text = metroGridUserType.CurrentRow.Cells[1].Value.ToString();
                textBoxDescription.Text = metroGridUserType.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}