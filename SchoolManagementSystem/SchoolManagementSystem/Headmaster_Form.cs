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
    public partial class Headmaster_Form : Form
    {
        public Headmaster_Form()
        {
            InitializeComponent();
        }

        string headmasterType;
        public string passType
        {
            get { return headmasterType; }
            set { headmasterType = value; }
        }

       

        private void Headmaster_Form_Load(object sender, EventArgs e)
        {
            lbl_type.Text = headmasterType;
        }

        private void t_submit_Click(object sender, EventArgs e)
        {
            string Tname = t_name.Text;
            string Tid = t_id.Text;
            string Tpass = t_pass.Text;
            string Tpos = t_position.Text;
            string Tsub = t_subject.Text;
            string Tdob = t_dob.Text;
            string Tgender = t_gender.Text;
            string Tblood = t_blood.Text;
            string Tsalary = t_salary.Text;
            string Tcontact = t_contact.Text;
            string Taddress = t_address.Text;

            if (MessageBox.Show("ARE YOU SURE TO ADD TEACHER DATABASE?", "CONFORM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                queryClass.addTeacher(Tname, Tid, Tpass, Tpos, Tsub, Tdob, Tgender, Tblood, Tsalary, Tcontact, Taddress);

                // ************ Clear the boxes 
                t_name.Text = t_id.Text = t_position.Text = t_pass.Text = t_subject.Text = t_dob.Text = t_gender.Text = t_blood.Text = t_salary.Text = t_contact.Text = t_address.Text = "";
                MessageBox.Show("Teacher SuccessFully Added");
            }

            else
            {
                MessageBox.Show("Adding Abroted");
            }
        }

        private void acc_sub_Click(object sender, EventArgs e)
        {
            string aName = a_name.Text;
            string aId = a_id.Text;
            string aPass = a_pass.Text;
            string aPos = a_com_pos.Text;
            string aDob = a_com_dob.Text;
            string aGender = a_com_gender.Text;
            string aBlood = a_com_blood.Text;
            string aSalary = a_com_sal.Text;
            string aContact = a_con.Text;
            string aAddress = a_rich_ad.Text;



            if (MessageBox.Show("ARE YOU SURE TO ADD TEACHER DATABASE?", "CONFORM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                queryClass.addAccountant(aName, aId, aPass, aPos, aDob, aGender, aBlood, aSalary, aContact, aAddress);

                // ************ Clear the boxes 
                a_name.Text = a_id.Text = a_com_pos.Text = a_com_dob.Text = a_com_gender.Text = a_com_blood.Text = a_com_sal.Text = a_con.Text = a_rich_ad.Text = a_pass.Text = "";
                MessageBox.Show("Accountant SuccessFully Added");
            }

            else
            {
                MessageBox.Show("Adding Abroted");
            }
        }

        private void stu_submit_Click(object sender, EventArgs e)
        {
            string Stdname = txtStdName.Text;
            string StdId = txtStdID.Text;
            string StdRoll = txtStdRoll.Text;
            string StdClass = txtStdClass.Text;
            string StdDob = txtStdDob.Text;
            string StdGender = txtStdGender.Text;
            string StdBlood = txtStdBlood.Text;
            string StdGardian = txtStdGardian.Text;
            string StdContact = txtStdContact.Text;
            string StdAddress = txtStdAddress.Text;
            string StdFees = txtStdFee.Text;
            string StdScholorship = txtStdFeeOff.Text;


            if (MessageBox.Show("ARE YOU SURE TO ADD STUDENT DATABASE?", "CONFORM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                queryClass.addStudent(Stdname, StdId, StdRoll, StdClass, StdDob, StdGender, StdBlood, StdGardian, StdContact, StdAddress, StdFees, StdScholorship);

                // ************ Clear the boxes 
                txtStdName.Text = txtStdID.Text = txtStdRoll.Text = txtStdClass.Text = txtStdDob.Text = txtStdGender.Text = txtStdBlood.Text = txtStdGardian.Text = txtStdContact.Text = txtStdAddress.Text = txtStdFee.Text = txtStdFeeOff.Text = "";
                MessageBox.Show("Student SuccessFully Added");
            }
            else
            {
                MessageBox.Show("Adding Abroted");
            }
        }

        private void showTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Show_Teacher_Form d = new Show_Teacher_Form();
            d.Show();
           // this.Hide();
        }

        private void showAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void showAccountantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Accountant_Form d = new Show_Accountant_Form();
            d.Show();
            // this.hide();
        }

        
        private void showStudentsByClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Student_Form d = new Show_Student_Form();
            d.Show();
   
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form d = new Login_Form();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form d = new Login_Form();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form d = new Login_Form();
            d.Show();
        }

        private void showStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Student_Form d = new Show_Student_Form();
            d.Show();
            // this.Hide();
        }
    }
    }

