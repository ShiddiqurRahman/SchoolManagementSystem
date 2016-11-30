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
    public partial class Accountant_Form : Form
    {
        public Accountant_Form()
        {
            InitializeComponent();
        }

        string accountantType;

        public string passAccountantType
        {
            get { return accountantType; }
            set { accountantType = value; }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("ARE YOU SURE TO ADD STUDENT DATABASE?.", "CONFORM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                queryClass.addStudent(txtStdName.Text, txtStdID.Text, txtStdRoll.Text, txtStdClass.Text, txtStdDob.Text, txtStdGender.Text, txtStdBlood.Text, txtStdGardian.Text, txtStdContact.Text, txtStdAddress.Text,txtStdFee.Text, txtStdFeeOff.Text);

                MessageBox.Show("Student added Successfully");
                // ************ Clear the boxes 
                txtStdName.Text = txtStdID.Text = txtStdRoll.Text = txtStdClass.Text = txtStdDob.Text = txtStdGender.Text = txtStdBlood.Text = txtStdContact.Text = txtStdAddress.Text = txtStdFee.Text = txtStdGardian.Text = txtStdFeeOff.Text = "";
            }
            else
            {
                MessageBox.Show("Adding Abroted");
            }
        }

        private void Accountant_Form_Load(object sender, EventArgs e)
        {
            lbl_type.Text = accountantType;
   
        }

        private void allStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStuAcc a = new ShowStuAcc();
            a.ShowDialog();
            this.Hide();
        }
        BalanceStu b1 = new BalanceStu();
        private void showStudentFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            b1.ShowDialog();
        }
        Salary_Teacher_Form b2 = new Salary_Teacher_Form();
        private void showTeachersBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            b2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
