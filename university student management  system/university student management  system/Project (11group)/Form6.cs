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
    
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
            

        }
        private void AddButton() {
            Button addButton = new Button();
            addButton.Text = "Add";
            addButton.Location = new
                System.Drawing.Point(10, 70);
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string departmemtname = nametextbox.Text;
            string departmentid = idtextbox.Text;
            {
                if (departmemtname == "Information Technology" && departmentid == "0001")
                {
                    MessageBox.Show("Department added successfully");
                }
                else if (departmemtname == "English" && departmentid == "0002")
                { 
                    MessageBox.Show("Department added successfully");

                }
                else if (departmemtname == "Manegment" && departmentid == "0003") { 
                }
                else
                {
                    MessageBox.Show("Invalid department id");
                }
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string departmentName = nametextbox.Text;
            string departmentID = idtextbox.Text;

            if (departmentID == "0001")
            {
                if (departmentName == "Information Technology")
                {
                    MessageBox.Show("Department updated successfully");
                }
                else
                {
                    MessageBox.Show("Invalid department name");
                }
            }
            else if (departmentID == "0002")
            {
                if (departmentName == "English")
                {
                    MessageBox.Show("Department updated successfully");
                }
                else
                {
                    MessageBox.Show("Invalid department name");
                }
            }
            else if (departmentID == "0003")
            {
                if (departmentName == "Management")
                {
                    MessageBox.Show("Department updated successfully");
                }
                else
                {
                    MessageBox.Show("Invalid department name");
                }
            }
            else
            {
                MessageBox.Show("Invalid department ID");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            nametextbox.Clear();
            idtextbox.Clear();
            
        }

    }

}

