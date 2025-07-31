using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serach_student
{
    public partial class SearchFrm : Form
    {
        public SearchFrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Registration = txtReg.Text;
            string Name = txtName.Text;
            string NIC = txtNIC.Text;
           
            String message = $"Name:{Name}\nNIC:{NIC}\\nRegistration No:{Registration}";
            MessageBox.Show(message, "Student information saved successfully!");

            var result = MessageBox.Show("Do you want to Save?", "Save Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data saved Cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes discarded");
           
            var result = MessageBox.Show("Do you want to cancel?", "Cancel Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Data saved Cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Cancelled aborted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
