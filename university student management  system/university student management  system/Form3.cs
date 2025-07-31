using Project__11group_;
using Serach_student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave_form
{
    public partial class leaveform : Form
    {
        public leaveform()
        {
            InitializeComponent();
        }

        private void leaveform_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {

            SearchFrm form3 = new SearchFrm();
            form3.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form7 = new Form2();
            form7.Show();

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {





        }

        private void dtpregitrstion_ValueChanged(object sender, EventArgs e)
        {
            {
                
                DateTime selectedDate1 = dtpregitrstion.Value;
                DateTime selectedDate2 = dtpleave.Value;

                TimeSpan difference = selectedDate2 - selectedDate1;
                int daysDifference = difference.Days;
                int monthsDifference = selectedDate2.Month - selectedDate1.Month + 12 * (selectedDate2.Year - selectedDate1.Year);
                int yearsDifference = selectedDate2.Year - selectedDate1.Year;

                
                if (selectedDate2 < selectedDate1.AddMonths(monthsDifference))
                {
                    monthsDifference--;
                }

                
                if (monthsDifference < 0)
                {
                    yearsDifference--;
                    monthsDifference += 12;
                }
                
                txtduration.Text = $"Difference: {yearsDifference} years, {monthsDifference} months, {daysDifference} days";
            }
        }
        
    




private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    } 
}





