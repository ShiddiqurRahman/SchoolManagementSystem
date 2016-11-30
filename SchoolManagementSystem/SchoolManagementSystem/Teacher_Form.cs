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
    public partial class Teacher_Form : Form
    {
        public Teacher_Form()
        {
            InitializeComponent();
        }


        private string teacherType;
        public string passTeacherType
        {
            get { return teacherType; }
            set { teacherType = value; }
        }

        private string teacherSubject;
        public string passTeacherSub
        {
            get { return teacherSubject; }
            set { teacherSubject = value; }
        }
       

        private void Teacher_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoStudentDataSet_Marks.marks' table. You can move, or remove it, as needed.
            this.marksTableAdapter.Fill(this.demoStudentDataSet_Marks.marks);

            lbl_type.Text = passTeacherType;
            lbl_subject.Text = passTeacherSub;

            if (lbl_subject.Text == "Bangali")
            {
                txt_english.Enabled = false;
                txt_math.Enabled = false;
                txt_gn.Enabled = false;
            }


            if (lbl_subject.Text == "English")
            {
                txt_bangla.Enabled = false;
                txt_math.Enabled = false;
                txt_gn.Enabled = false;
            }

            if (lbl_subject.Text == "Mathematics")
            {
                txt_english.Enabled = false;
                txt_bangla.Enabled = false;
                txt_gn.Enabled = false;
            }

            if (lbl_subject.Text == "GN")
            {
                txt_english.Enabled = false;
                txt_bangla.Enabled = false;
                txt_math.Enabled = false;
            }

        }

        private void btnAddMarks_Click(object sender, EventArgs e)
        {

            queryClass.addMarks(txt_bangla.Text, txt_english.Text, txt_math.Text, txt_gn.Text, txt_src.Text);
            queryClass.searchStuMarks("", this.dataGridMarks);
        }

        private void txt_src_TextChanged(object sender, EventArgs e)
        {
            queryClass.searchStuMarks(txt_src.Text, dataGridMarks);
            string bangla = dataGridMarks.CurrentRow.Cells[4].Value.ToString(); ;
            string english = dataGridMarks.CurrentRow.Cells[5].Value.ToString(); ;
            string math = dataGridMarks.CurrentRow.Cells[6].Value.ToString(); ;
            string gn = dataGridMarks.CurrentRow.Cells[7].Value.ToString(); ;

            if (bangla == "")
            {
                txt_bangla.Text = "0";
            }
            else
            {
                txt_bangla.Text = bangla;
            }

            if (english == "")
            {
                txt_english.Text = "0";
            }
            else
            {
                txt_english.Text = english;
            }

            if (math == "")
            {
                txt_math.Text = "0";
            }
            else
            {
                txt_math.Text = math;
            }

            if (gn == "")
            {
                txt_gn.Text = "0";
            }
            else
            {
                txt_gn.Text = gn;
            }

            if (txt_src.Text == "")
            {
                txt_bangla.Text = txt_english.Text = txt_math.Text = txt_gn.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lbl_subject_Click(object sender, EventArgs e)
        {

        }

        private void lbl_type_Click(object sender, EventArgs e)
        {

        }

        private void dataGridMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void marksBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_gn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_math_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_english_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bangla_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void marksBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void stuMarksBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void marksBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
