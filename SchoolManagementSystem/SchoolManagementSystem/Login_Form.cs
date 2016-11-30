using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Headmaster_Form HMF = new Headmaster_Form();
            Teacher_Form TF = new Teacher_Form();
            Accountant_Form AF = new Accountant_Form();
            try
            {
               
                queryClass.login_func(txt_userid.Text, this.dataGridViewLogin);


                string userid = dataGridViewLogin.CurrentRow.Cells[1].Value.ToString();
                string userPas = dataGridViewLogin.CurrentRow.Cells[2].Value.ToString();
                string userType = dataGridViewLogin.CurrentRow.Cells[3].Value.ToString();





                string tpyeHeadmaster = "Headmaster";

                if (txt_userid.Text == userid && txt_pass.Text == userPas)
                {
                    if (userType == tpyeHeadmaster)
                    {
                        HMF.passType = tpyeHeadmaster;
                        HMF.Show();
                    }
                    else if (userType == "Teacher")
                    {
                        queryClass.loginTeacher(txt_userid.Text, dataGridViewLogin);
                        string userSubject = dataGridView_t_login.CurrentRow.Cells[5].Value.ToString();
                        TF.passTeacherType = userType;
                        TF.passTeacherSub = userSubject;
                        
                        TF.ShowDialog();

                    }

                    else if (userType == "Accountant")
                    {

                        queryClass.loginAccountant(txt_userid.Text, this.dataGridViewLogin);
                        AF.passAccountantType = userType;
                        AF.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid userid or pass");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid userid or pass");
            }

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoStudentDataSet_Teacher.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.demoStudentDataSet_Teacher.teacher);
            // TODO: This line of code loads data into the 'demoStudentDataSet_Login.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.demoStudentDataSet_Login.login);
            dataGridViewLogin.Hide();
            dataGridView_t_login.Hide();

        }

        private void txt_userid_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(txt_userid.Text.Length.ToString());
            if (a == 10)
            {
                btnlogin.Enabled = true;
                btnlogin.BackColor = Color.Green;
            }
            else
            {
                btnlogin.Enabled = false;
                btnlogin.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


    
    }

