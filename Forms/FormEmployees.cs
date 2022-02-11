using System;
using System.Windows.Forms;
using hci_apoteka.DAO;
using MetroFramework;
using System.IO;
using hci_apoteka.DTO;
using System.Drawing;

namespace hci_apoteka.Forms
{
    public partial class FormEmployees : Form
    {

        readonly EmployeeDAO employee = new EmployeeDAO();
        string imageUrl = null;
        public FormEmployees()
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
                lbUsername.Text = Program.LanguageResxSet.GetString("username");
                lbPass.Text = Program.LanguageResxSet.GetString("password");
                lbName.Text = Program.LanguageResxSet.GetString("firstname");
                lbSurname.Text = Program.LanguageResxSet.GetString("surname");
                lbJmbg.Text = Program.LanguageResxSet.GetString("jmbg");
                lbEmail.Text = Program.LanguageResxSet.GetString("email");
                lbState.Text = Program.LanguageResxSet.GetString("state");
                lbUserType.Text = Program.LanguageResxSet.GetString("usertype");
                gbInfo.Text = Program.LanguageResxSet.GetString("basicinformation");


                columnUsername.HeaderText = Program.LanguageResxSet.GetString("username");
                columnPassword.HeaderText = Program.LanguageResxSet.GetString("password");
                columnFirstname.HeaderText = Program.LanguageResxSet.GetString("firstname");
                columnSurname.HeaderText = Program.LanguageResxSet.GetString("surname");
                columnJmbg.HeaderText = Program.LanguageResxSet.GetString("jmbg");
                columnEmail.HeaderText = Program.LanguageResxSet.GetString("email");
                columnState.HeaderText = Program.LanguageResxSet.GetString("state");
                columnUserType.HeaderText = Program.LanguageResxSet.GetString("usertype");
                iconButtonBrowse.Text = Program.LanguageResxSet.GetString("browse");           
            }
        }

        private void IconButtonBrowse_Click(object sender, EventArgs e)
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
                    pictureBoxEmployee.ImageLocation = imageLocation;
                    imageUrl = dialog.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greska", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IconButtonAddEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxPass.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxName.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxSurname.Text.Trim()) ||
                textBoxJmbg.Text.Length != 13 ||
                string.IsNullOrEmpty(textBoxEmail.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxState.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Type data not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string usersA = textBoxUsername.Text;

                string userDb;
                bool exists = false;
                foreach (var p in EmployeeDAO.GetUser())
                {
                    userDb = p.KorisnickoIme;
                    if (usersA == userDb)
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
                    var employee = new Employee()
                    {
                        KorisnickoIme = textBoxUsername.Text,
                        Lozinka = textBoxPass.Text,
                        Ime = textBoxName.Text,
                        Prezime = textBoxSurname.Text,
                        JMBG = textBoxJmbg.Text,
                        Email = textBoxEmail.Text,
                        AdresaStanovanja = textBoxState.Text,
                        UserType = (UserType)comboBoxUserType.SelectedItem,
                        Slika = imageUrl
                    };
                    EmployeeDAO.AddEmployee(employee);
                    FillGrid();
                    ClearEmployee();
                    MetroMessageBox.Show(this, "Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void ClearEmployee()
        {
            textBoxUsername.Clear();
            textBoxPass.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxJmbg.Clear();
            textBoxEmail.Clear();
            textBoxState.Clear();
            comboBoxUserType.SelectedIndex = 0;
            pictureBoxEmployee.Image = Properties.Resources.user;
        }

        void FillGrid()
        {
            metroGridEmployees.Rows.Clear();
            foreach (var p in EmployeeDAO.GetEmployee(tbFilterEmployee.Text))
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = p
                };
                row.CreateCells(metroGridEmployees, p.KorisnickoIme, p.Lozinka, p.Ime, p.Prezime, p.JMBG, p.Email, p.AdresaStanovanja, p.UserType.NazivKorisnikVrsta);
                metroGridEmployees.Rows.Add(row);
            }
        }

        void FillComboBox()
        {
            comboBoxUserType.DataSource = UserTypeDAO.GetComboBoxUserType();
        }

        private void MetroGridEmployees_DoubleClick(object sender, EventArgs e)
        {
            ClearEmployee();
            textBoxUsername.Text = metroGridEmployees.CurrentRow.Cells[0].Value.ToString();
            textBoxPass.Text = metroGridEmployees.CurrentRow.Cells[1].Value.ToString();
            textBoxName.Text = metroGridEmployees.CurrentRow.Cells[2].Value.ToString();
            textBoxSurname.Text = metroGridEmployees.CurrentRow.Cells[3].Value.ToString();
            textBoxJmbg.Text = metroGridEmployees.CurrentRow.Cells[4].Value.ToString();
            textBoxEmail.Text = metroGridEmployees.CurrentRow.Cells[5].Value.ToString();
            textBoxState.Text = metroGridEmployees.CurrentRow.Cells[6].Value.ToString();
            comboBoxUserType.Text = metroGridEmployees.CurrentRow.Cells[7].Value.ToString();
            string id = metroGridEmployees.CurrentRow.Cells[0].Value.ToString(); 
            string pathImage = employee.GetPicture(id);
            if (pathImage != null)
            {
                pictureBoxEmployee.Image = new Bitmap(pathImage);
                pictureBoxEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBoxEmployee.Image = Properties.Resources.user;
            }
        }

        private void IconButtonEditEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxPass.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxName.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxSurname.Text.Trim()) ||
                textBoxJmbg.Text.Length != 13 ||
                string.IsNullOrEmpty(textBoxEmail.Text.Trim()) ||
                string.IsNullOrEmpty(textBoxState.Text.Trim()))
            {
                MetroMessageBox.Show(this, "You must fill in all fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var employee = new Employee()
                {
                    KorisnickoIme = textBoxUsername.Text,
                    Lozinka = textBoxPass.Text,
                    Ime = textBoxName.Text,
                    Prezime = textBoxSurname.Text,
                    JMBG = textBoxJmbg.Text,
                    Email = textBoxEmail.Text,
                    AdresaStanovanja = textBoxState.Text,
                    UserType = (UserType)comboBoxUserType.SelectedItem,
                    Slika = imageUrl
                };
                EmployeeDAO.UpdateEmployee(employee);
                FillGrid();               
                MetroMessageBox.Show(this, "Successfully modified", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                ClearEmployee();
            }
        }

        private void TbFilterEmployee_TextChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void IconPictureBoxRefresh_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPass.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxJmbg.Clear();
            textBoxEmail.Clear();
            textBoxState.Clear();
            comboBoxUserType.SelectedIndex = 0;
            pictureBoxEmployee.Image = Properties.Resources.user;
        }
    }
}