using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insititute
{
    public partial class InstituteFrm : Form
    {
        public InstituteFrm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string InstituteName = txtname.Text;
            string InstituteID = txtid.Text;
            string Address = txtaddress.Text;
            string Email = txtemail.Text;
            string WebAddress = txtweb.Text;
            string TelephoneNumber = txttele.Text;
            {
                if (InstituteName == "SLIATE Nawalapitiya" || InstituteID == "naw" || Address == "Nawalapitiya" || Email == "sliate@gmail.com" || WebAddress == "naw@yahoo.com" || TelephoneNumber == "0111122222")
                {
                    MessageBox.Show("Department added successfully");
                }

                else
                {
                    MessageBox.Show("Invalid department id");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes discarded");
            this.Close();
        }
    }
}
