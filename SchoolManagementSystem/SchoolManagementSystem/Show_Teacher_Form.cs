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
    public partial class Show_Teacher_Form : Form
    {
        public Show_Teacher_Form()
        {
            InitializeComponent();
        }

        private void teacher_Search_TextChanged(object sender, EventArgs e)
        {
            string teacherID = teacher_Search.Text;
            queryClass.searchTeacher(teacherID, this.DataGridView_All_Teacher);
        }

        private void Show_Teacher_Form_Load(object sender, EventArgs e)
        {
            string a = "";   //Refresh student List
            queryClass.searchTeacher(a, this.DataGridView_All_Teacher);

            // TODO: This line of code loads data into the 'demoStudentDataSet_Show_Teacher.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.demoStudentDataSet_Show_Teacher.teacher);

        }

        Update_Teacher_Form d1 = new Update_Teacher_Form();
        private void actionEdit_Click(object sender, EventArgs e)
        {

            this.Hide();
            string Tname = DataGridView_All_Teacher.CurrentRow.Cells[1].Value.ToString();
            string Tid = DataGridView_All_Teacher.CurrentRow.Cells[2].Value.ToString();
            string Tpass = DataGridView_All_Teacher.CurrentRow.Cells[3].Value.ToString();
            string Tpos = DataGridView_All_Teacher.CurrentRow.Cells[4].Value.ToString();
            string Tsub = DataGridView_All_Teacher.CurrentRow.Cells[5].Value.ToString();
            string Tdob = DataGridView_All_Teacher.CurrentRow.Cells[6].Value.ToString();
            string Tgender = DataGridView_All_Teacher.CurrentRow.Cells[7].Value.ToString();
            string Tblood = DataGridView_All_Teacher.CurrentRow.Cells[8].Value.ToString();
            string Tsalary = DataGridView_All_Teacher.CurrentRow.Cells[9].Value.ToString();
            string Tcontact = DataGridView_All_Teacher.CurrentRow.Cells[10].Value.ToString();
            string Taddress = DataGridView_All_Teacher.CurrentRow.Cells[11].Value.ToString();

            d1.passName = Tname;
            d1.passId = Tid;
            d1.passPass = Tpass;
            d1.passPos = Tpos;
            d1.passSub = Tsub;
            d1.passDob = Tdob;
            d1.passGender = Tgender;
            d1.passBlood = Tblood;
            d1.passSalary = Tsalary;
            d1.passContact = Tcontact;
            d1.passAdd = Taddress;

            d1.ShowDialog();
        }

        private void actionDelete_Click(object sender, EventArgs e)
        {
            queryClass.TeacherDel(teacher_Search.Text, this.DataGridView_All_Teacher);

            string a = "";   //Refresh student List
            queryClass.searchTeacher(a, this.DataGridView_All_Teacher);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Headmaster_Form d = new Headmaster_Form();
            d.Show();
        }
    }
}
