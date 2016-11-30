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
    public partial class Salary_Teacher_Form : Form
    {
        public Salary_Teacher_Form()
        {
            InitializeComponent();
        }

        private void Salary_Teacher_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoStudentDataSet1_Salary_Teacher_Form.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.demoStudentDataSet1_Salary_Teacher_Form.teacher);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string TeacherID = txtSearch.Text;
            queryClass.searchTeacher(TeacherID,this.dataGridView1_T_Salary_Form);
        }

        private void btn_add_salary_Click(object sender, EventArgs e)
        {
            string Tid = dataGridView1_T_Salary_Form.CurrentRow.Cells[2].Value.ToString();
            string oldsalary = dataGridView1_T_Salary_Form.CurrentRow.Cells[5].Value.ToString();
            string adSalary = txt_salary.Text;

            queryClass.add_salary(Tid, oldsalary, adSalary);
        }

        private void btn_add_Bonus_Click(object sender, EventArgs e)
        {
            string Tid = dataGridView1_T_Salary_Form.CurrentRow.Cells[2].Value.ToString();
            string oldsalary = dataGridView1_T_Salary_Form.CurrentRow.Cells[5].Value.ToString();
            string adbonus = txt_Bonus.Text;
            queryClass.add_sch(Tid, oldsalary, adbonus);
        }

        private void dataGridView1_T_Salary_Form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
