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
    public partial class ShowStuAcc : Form
    {
        public ShowStuAcc()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string studentID = txtSearch.Text;
            queryClass.searchStu(studentID,this.DataGrideView_AllStu);
        }

        stuFormProfile sf = new stuFormProfile();
        private void button1_Click(object sender, EventArgs e)
        {
            string name = dataGridDemo.CurrentRow.Cells[1].Value.ToString();
            string id = dataGridDemo.CurrentRow.Cells[2].Value.ToString();
            string roll = dataGridDemo.CurrentRow.Cells[3].Value.ToString();
            string classstu = dataGridDemo.CurrentRow.Cells[4].Value.ToString();
            string dob = dataGridDemo.CurrentRow.Cells[5].Value.ToString();
            string gender = dataGridDemo.CurrentRow.Cells[6].Value.ToString();
            string blood = dataGridDemo.CurrentRow.Cells[7].Value.ToString();
            string gardian = dataGridDemo.CurrentRow.Cells[8].Value.ToString();
            string contact = dataGridDemo.CurrentRow.Cells[9].Value.ToString();
            string address = dataGridDemo.CurrentRow.Cells[10].Value.ToString();

            sf.passStuName = name;
            sf.passStuId = id;
            sf.passStuRoll = roll;
            sf.passStuClass = classstu;
            sf.passStuDob = dob;
            sf.passStuGender = gender;
            sf.passStuBlood = blood;
            sf.passStuGardian = gardian;
            sf.passStuContact = contact;
            sf.passStuAddress = address;

            sf.ShowDialog();

        }

        private void ShowStuAcc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoStudentDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.demoStudentDataSet.student);
            // TODO: This line of code loads data into the 'demoStudentDataSet_ShowStuAcc.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.demoStudentDataSet_ShowStuAcc.student);
            dataGridDemo.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
