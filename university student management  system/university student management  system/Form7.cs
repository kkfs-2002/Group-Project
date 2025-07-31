using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project__11group_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string studentid = txtstudentid.Text;
            string semester = cmbsemester.Text;
            string courstype = rbfulltime.Checked ? "Fulltime" : "parttime";
            string feestype = cmbfeestype.Text;
            string amount = txtamount.Text;
            DateTime paymendData = dtppaymentdata.Value;
            string paymentmethods = cmbpaymentmethods.Text;


            String message = $"Name:{name}\nStudent ID:{studentid}\nSemester:{semester}\nCours Type:{courstype}\nFees Type:{feestype}\nAmount:{amount}\nPayment Date:{paymendData}\nPayment Methods:{paymentmethods}";
            MessageBox.Show(message, "Student information saved successfully!");


            if (rbparttime.Checked && cmbfeestype.Text == "Renewal Fee") {
                decimal Amount;
                if (decimal.TryParse(txtamount.Text, out Amount))
                {
                    MessageBox.Show("Renewal fee for part time student saved successefully");
                }
                else {
                    MessageBox.Show("please entera valid amount for the renewal fee");
                }
            }
            else
            {
                MessageBox.Show("Only renewal fee for part-time student can be saved in mode");
            }
            
               }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         MessageBox.Show("Changes discarded");
          this.Close();

        }

        private void rbfulltime_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfulltime.Checked==true )
            {
                
               
                txtamount.Visible = false;
                dtppaymentdata.Visible = false;
                cmbpaymentmethods.Visible = false;

            }



        }

        private void rbparttime_CheckedChanged(object sender, EventArgs e)
        {
            if (rbparttime.Checked == true)
            {
                txtamount.Visible = true;
                dtppaymentdata.Visible = true;
                cmbpaymentmethods.Visible = true;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            txtamount.Visible = false;
            dtppaymentdata.Visible = false;
            cmbpaymentmethods.Visible = false;

        }
    }
}
