using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using hci_apoteka.Forms;

namespace hci_apoteka
{
    public partial class FormMainAdmin : Form
    {
        private IconButton currentBtn;
        private Panel leftBtn;
        private Form currentChildForm;

        public FormMainAdmin()
        {
            InitializeComponent();
            LoadSelectedLanguageStrings();
            leftBtn = new Panel();
            leftBtn.Size = new Size(7, 60);
            panelMenuAdmin.Controls.Add(leftBtn);
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void LoadSelectedLanguageStrings()
        {
            if (Program.LanguageResxSet != null)
            {
                btnCiphers.Text = Program.LanguageResxSet.GetString("chipers");
                btnEmployees.Text = Program.LanguageResxSet.GetString("employees");
            }
        }

        private struct RGBSColor
        {
            public static Color color = Color.FromArgb(25, 25, 112);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(240, 240, 240);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBtn.BackColor = color;
                leftBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBtn.Visible = true;
                leftBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(25, 25, 112);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopAdmin.Controls.Add(childForm);
            panelDesktopAdmin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void BtnSifarnici_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBSColor.color);
            OpenChildForm(new FormCiphers());
        }

        private void BtnZaposleni_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBSColor.color);
            OpenChildForm(new FormEmployees());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void PanelBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IconExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new FormLogin();
            login.ShowDialog();
            this.Close();
        }

        private void IconPictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void IconPictureBoxMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void PanelDesktopAdmin_Paint(object sender, PaintEventArgs e)
        {
            OpenChildForm(new FormEmployees());
        }

     
    }
}