using hci_apoteka.DAO;
using hci_apoteka.DTO;
using MetroFramework;
using MySql.Data.MySqlClient;
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
    public partial class FormLogin : Form
    {
        public static string id = "";
        public static string user = "";
        public FormLogin()
        {
            InitializeComponent();
            LoadSelectedLanguageStrings();
        }

        private void LoadSelectedLanguageStrings()
        {
            if (Program.LanguageResxSet != null)
            {
                btnLogin.Text = Program.LanguageResxSet.GetString("login");
                btnCancle.Text = Program.LanguageResxSet.GetString("cancle");
                labelLoginForm.Text = Program.LanguageResxSet.GetString("logintothesystem");               
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
              if (string.IsNullOrEmpty(textLogin.Text.Trim()) || string.IsNullOrEmpty(textPass.Text.Trim()))
              {
                  MetroMessageBox.Show(this, "You must fill in all fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              else
              {
                  bool isExist = false;

                  
                  String userPass = "";
                  int userType = -1;
                  String userName = "";
                  MySqlConnection conn = null;
                  MySqlCommand cmd;
                  MySqlDataReader reader = null;

                  try
                  {
                      conn = MySqlUtil.GetConnection();
                      cmd = conn.CreateCommand();
                      cmd.CommandText = "SELECT * FROM korisnik WHERE KorisnickoIme='" + textLogin.Text + "' AND Lozinka='" + textPass.Text + "'";
                      reader = cmd.ExecuteReader();
                      while (reader.Read())
                      {
                        isExist = true;
                        labelId.Text = reader.GetString(0); 
                        userName = reader.GetString(1);
                        userPass = reader.GetString(2);
                        userType = reader.GetInt32(8);
                      }

                      if (isExist)
                      {
                          if (textLogin.Text.Trim().Equals(userName) && textPass.Text.Trim().Equals(userPass))
                          {
                              if (userType == 1)
                              {
                                  this.Hide();
                                  Form login = new FormMainAdmin();
                                  login.ShowDialog();
                                  this.Close();
                              }
                              else if (userType == 4)
                              {
                                  MetroMessageBox.Show(this, "The user account has been deactivated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              }
                              else
                              {                                
                                user = textLogin.Text;
                                id = labelId.Text;
                                this.Hide();
                                  FormMain formaGlavna = new FormMain();
                                  Form login = new FormMain();
                                  login.ShowDialog();
                                  this.Close();
                              }
                          }
                      }
                      else
                      {
                          MetroMessageBox.Show(this, "User account or password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      }
                  }
                  catch
                  {
                             }
                  finally
                  {
                      MySqlUtil.Close(reader, conn);
                  }


              }
        }


        private void TextLogin_Click(object sender, EventArgs e)
        {
            textLogin.BackColor = Color.White;
            panelLogin.BackColor = Color.White;
            textPass.BackColor = SystemColors.Control;
            panelPass.BackColor = SystemColors.Control;
        }

        private void TextPass_Click(object sender, EventArgs e)
        {
            textPass.BackColor = Color.White;
            panelPass.BackColor = Color.White;
            textLogin.BackColor = SystemColors.Control;
            panelLogin.BackColor = SystemColors.Control;
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form start = new FormStart();
            start.ShowDialog();
            this.Close();
        }
    }
}
