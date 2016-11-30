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
    public partial class Update_Teacher_Form : Form
    {
        private string a, b, c, d, e, f, g, h, i, j, k;
        public string passName
        {
            get { return a; }
            set { a = value; }
        }

        public string passId
        {
            get { return b; }
            set { b = value; }
        }

        public string passPass
        {
            get { return k; }
            set { k = value; }

        }

        public string passPos
        {
            get { return c; }
            set { c = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Teacher_Form d = new Show_Teacher_Form();
            d.Show();
        }

        public string passSub
        {
            get { return d; }
            set { d = value; }
        }

        public string passDob
        {
            get { return e; }
            set { e = value; }
        }

        public string passGender
        {
            get { return f; }
            set { f = value; }
        }

        public string passBlood
        {
            get { return g; }
            set { g = value; }
        }

        public string passSalary
        {
            get { return h; }
            set { h = value; }
        }

        public string passContact
        {
            get { return i; }
            set { i = value; }
        }


        public string passAdd
        {
            get { return j; }
            set { j = value; }
        }
        public Update_Teacher_Form()
        {
            InitializeComponent();
        }

        private void Update_Teacher_Form_Load(object sender, EventArgs e)
        {
            t_name.Text = passName;
            t_id.Text = passId;
            t_pass.Text = passPass;
            t_position.Text = passPos;
            t_subject.Text = passSub;
            t_dob.Text = passDob;
            t_gender.Text = passGender;
            t_blood.Text = passBlood;
            t_salary.Text = passSalary;
            t_contact.Text = passContact;
            t_address.Text = passAdd;
        }

        private void teacher_update_button_Click(object sender, EventArgs e)
        {

            string tname = t_name.Text;
            string tid = t_id.Text;
            string tpas = t_pass.Text;
            string tpos = t_position.Text;
            string tsub = t_subject.Text;
            string tdob = t_dob.Text;
            string tgen = t_gender.Text;
            string tblood = t_blood.Text;
            string tsal = t_salary.Text;
            string tcon = t_contact.Text;
            string tadd = t_address.Text;


            queryClass.updateTeacher(tname, tid, tpas, tpos, tsub, tdob, tgen, tblood, tsal, tcon, tadd);
            this.Hide();
            Show_Teacher_Form d = new Show_Teacher_Form();
            d.ShowDialog();
        }
    }
}
