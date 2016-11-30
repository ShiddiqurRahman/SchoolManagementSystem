using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class Show_Student_Form : Form
    {
        public Show_Student_Form()
        {
            InitializeComponent();
        }

        private void DataGrid_All_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Show_Student_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoStudentDataSet1.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter2.Fill(this.demoStudentDataSet1.student);



            // TODO: This line of code loads data into the 'demoStudentDataSet_Show_Student.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.demoStudentDataSet_Show_Student.student);
            string a = "";   // Refresh student List
            queryClass.searchStu(a, this.DataGrid_All_Student);
            
        }

        

        Update_Student_Form editStudent = new Update_Student_Form();
        private void actionEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            string name = DataGrid_All_Student.CurrentRow.Cells[1].Value.ToString();
            string id = DataGrid_All_Student.CurrentRow.Cells[2].Value.ToString();
            string roll = DataGrid_All_Student.CurrentRow.Cells[3].Value.ToString();
            string classStd = DataGrid_All_Student.CurrentRow.Cells[4].Value.ToString();
            string dob = DataGrid_All_Student.CurrentRow.Cells[5].Value.ToString();
            string gender = DataGrid_All_Student.CurrentRow.Cells[6].Value.ToString();
            string blood = DataGrid_All_Student.CurrentRow.Cells[7].Value.ToString();
            string gardian = DataGrid_All_Student.CurrentRow.Cells[8].Value.ToString();
            string contact = DataGrid_All_Student.CurrentRow.Cells[9].Value.ToString();
            string address = DataGrid_All_Student.CurrentRow.Cells[10].Value.ToString();
            string fee = DataGrid_All_Student.CurrentRow.Cells[11].Value.ToString();
            string scholarship = DataGrid_All_Student.CurrentRow.Cells[12].Value.ToString();

            editStudent.passStuName = name;
            editStudent.passStuID = id;
            editStudent.passStuRoll = roll;
            editStudent.passStuClass = classStd;
            editStudent.passStuDob = dob;
            editStudent.passStuGender = gender;
            editStudent.passStuBlood = blood;
            editStudent.passStuGardian = gardian;
            editStudent.passStuContact = contact;
            editStudent.passStuAddress = address;
            editStudent.passStuFee = fee;
            editStudent.passStuScholarship = scholarship;

            editStudent.ShowDialog();
        }

        private void Stu_Search_TextChanged(object sender, EventArgs e)
        {
            string studentID = Stu_Search.Text;
            queryClass.searchStu(studentID, this.DataGrid_All_Student);
        }

        private void actionDelete_Click(object sender, EventArgs e)
        {

            queryClass.stuDel(Stu_Search.Text, this.DataGrid_All_Student);
            queryClass.stuDelMarks(Stu_Search.Text);

            string a = "";   /// Refresh student Lsist
                queryClass.searchStu(a, this.DataGrid_All_Student);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string classId = classCombo.Text;
            queryClass.ShowStdByClass(classId, this.DataGrid_All_Student);
        }

        Headmaster_Form d = new Headmaster_Form();

        private void button1_Click(object sender, EventArgs e)
        {
           
            d.Show();
            this.Hide();
           
        }
    }
}
