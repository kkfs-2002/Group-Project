using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class RegFrm : Form
    {
        public RegFrm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string ati = comboBoxAti.Text;
            string courseCode = txtCourseCode.Text;
            string courseType = comboBoxCourseType.Text;
            string registrationYear = txtRegYear.Text;
            string registerNo = txtRegNo.Text;

            string title = comboBoxTitle.Text;
            string nameWithInitial = txtNameWithInitial.Text;
            string nameInFull = txtNameinFull.Text;
            string address = txtAddress.Text;
            string dob = dateTimePicker1.Value.ToShortDateString();
            string gender = comboBoxGender.Text;
            string nic = txtNic.Text;
            string contactNo = txtContactNo.Text;

            string aLIndexNo = txtIndex.Text;
            string aLYear = txtYear.Text;
            string aLStream = comboBoxAlStream.Text;
            string zCore = txtZcore.Text;

            string oLIndexNo = txtndex2.Text;
            string oLYear = txtYear2.Text;
            string englishGrade = comboBoxEnglishGrade.Text;
            string mathsGrade = comboBoxMathsGrade.Text;

            string otherQualification = richTextBox1.Text;

            bool isActive = checkBox1.Checked;
            bool isInactive = checkBox2.Checked;

            string message = $"ATI: {ati}\n" +
                $"Course Code: {courseCode}\n" +
                $"Course Type: {courseType}\n" +
                $"Registration Year: {registrationYear}\n" +
                $"Register No: {registerNo}\n\n" +
                $"Title: {title}\n" +
                $"Name With Initial: {nameWithInitial}\n" +
                $"Name in Full: {nameInFull}\n" +
                $"Address: {address}\n" +
                $"Date of Birth: {dob}\n" +
                $"Gender: {gender}\n" +
                $"NIC: {nic}\n" +
                $"Contact No: {contactNo}\n\n" +
                $"A/L Index No: {aLIndexNo}\n" +
                $"A/L Year: {aLYear}\n" +
                $"A/L Stream: {aLStream}\n" +
                $"Z.Core: {zCore}\n\n" +
                $"O/L Index No: {oLIndexNo}\n" +
                $"O/L Year: {oLYear}\n" +
                $"English Grade: {englishGrade}\n" +
                $"Maths Grade: {mathsGrade}\n\n" +
                $"Other Qualification: {otherQualification}\n" +

                $"Active Student: {isActive}\n" +
                $"Inactive Student: {isInactive}";

            // Display the message in a message box
            MessageBox.Show(message, "Student Registration Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Clear all the form controls
            comboBoxAti.SelectedIndex = -1;
            txtCourseCode.Clear();
            comboBoxCourseType.SelectedIndex = -1;
            txtRegYear.Clear();
            txtRegNo.Clear();

            comboBoxTitle.SelectedIndex = -1;
            txtNameWithInitial.Clear();
            txtNameinFull.Clear();
            txtAddress.Clear();
            dateTimePicker1.Value = DateTime.Now;
            comboBoxGender.SelectedIndex = -1;
            txtNic.Clear();
            txtContactNo.Clear();

            txtIndex.Clear();
            txtYear.Clear();
            comboBoxAlStream.SelectedIndex = -1;
            txtZcore.Clear();

            txtndex2.Clear();
            txtYear2.Clear();
            comboBoxEnglishGrade.SelectedIndex = -1;
            comboBoxMathsGrade.SelectedIndex = -1;
            richTextBox1.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
