using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace university_student_management__system
{
    public partial class Login : Form
    {
        public string Usertype{ get; private set; }
        public Login()
        {
            InitializeComponent();
        }

       

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string usertype = comboBox2.SelectedItem.ToString();
            string username = txtusername.Text;
            string password = txtpass.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter password.");
                return;
            }

            

            if ((username == "Admin") && (usertype == "Admin"))
            {
                if (password == "1111")
                {
                    MessageBox.Show("Welcome Admin");
                    FrmMain mainform = new FrmMain(usertype);
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Password ");
                }
            }
            else if ((username == "User") && (usertype == "User"))
            {
                if (password == "2222")
                {
                    MessageBox.Show("Welcome User");
                    FrmMain mainform = new FrmMain( usertype);
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Password ");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            txtusername.Clear();
            comboBox2.SelectedIndex = -1;
        }
    }
}




           