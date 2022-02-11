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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSerbian_Click(object sender, EventArgs e)
        {
            Program.SwitchLanguage(Program.Languages.Serbian);
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            this.Hide();
            Form login = new FormLogin();
            login.ShowDialog();
            this.Close();
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new FormLogin();
            login.ShowDialog();
            this.Close();
        }
    }
}
