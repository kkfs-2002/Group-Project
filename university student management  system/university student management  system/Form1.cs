/*using Leave_form;

using Project__11group_;*/
using Insititute;
using Leave_form;
using Project__11group_;
using Registration;
using Serach_student;
using System;
using System.Windows.Forms;

namespace university_student_management__system
{
    public partial class FrmMain : Form
    {
        public FrmMain(string usertype)
        {
            InitializeComponent();
            

            UpdateUsertype(usertype);

        }

        public void UpdateUsertype(string usertype)
        {
            label_user.Text = usertype;
            if (usertype == "Admin")
            {


            }
            else
            {

                button_Exist.Hide();
                button_Student.Hide();
                button2.Hide();
            }
        }

        private Form activeFrom = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_cover.Controls.Add(childForm);
            panel_cover.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void Button_Registration_Click(object sender, EventArgs e)
        {

        }

       /* private void Button_Institute_Click(object sender, EventArgs e)
        {
            InstituteFrm form3 = new InstituteFrm();
            
            OpenChildForm(new InstituteFrm());
           
        }*/

       

       /* private void Button_Department_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DepartmentFrm());
            DepartmentFrm form4 = new DepartmentFrm();

            

        }

        private void Button_Exist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FeesFrm());
            FeesFrm form5 = new FeesFrm();
        }
       */
      /* private void Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageStudentFrm());
            ManageStudentFrm form = new ManageStudentFrm();

        }*/

        /*private void FrmMain_Load(object sender, EventArgs e)
        {

        }

      /*  private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new leaveFrm());
            leaveFrm form4 = new leaveFrm();

        }*/

        private void button_Student_Click(object sender, EventArgs e)
        {

            RegFrm form3 = new RegFrm();
            form3.Show();

            
        }

        private void button_Department_Click(object sender, EventArgs e)
        {

            DepFrm form5 = new DepFrm();

            OpenChildForm(new DepFrm());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            leaveform form4 = new leaveform();

            OpenChildForm(new leaveform());
        }

        private void button_Exist_Click(object sender, EventArgs e)
        {

            Form2 form7 = new Form2();

            OpenChildForm(new Form2());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SearchFrm form3 = new SearchFrm();

            OpenChildForm(new SearchFrm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Institute_Click(object sender, EventArgs e)
        {

            InstituteFrm form8 = new InstituteFrm();

            OpenChildForm(new InstituteFrm());
        }

        /* private void pictureBox2_Click(object sender, EventArgs e)
         {

         }*/



    }
    }


