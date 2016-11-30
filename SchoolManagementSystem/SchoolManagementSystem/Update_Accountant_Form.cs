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
    public partial class Update_Accountant_Form : Form
    {
        private string a, b, c, e, f, g, h, i, j, k;
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

        public Update_Accountant_Form()
        {
            InitializeComponent();
        }

        private void acc_update_button_Click(object sender, EventArgs e)
        {
            string aname = a_name.Text;
            string aid = a_id.Text;
            string apass = a_pass.Text;
            string apos = a_com_pos.Text;
            string adob = a_com_dob.Text;
            string agen = a_com_gender.Text;
            string ablood = a_com_blood.Text;
            string asal = a_com_sal.Text;
            string acon = a_con.Text;
            string aadd = a_rich_ad.Text;

            queryClass.UpdateAcc(aname, aid, apass, apos, adob, agen, ablood, asal, acon, aadd);
            this.Hide();
            Show_Accountant_Form d = new Show_Accountant_Form();
            d.ShowDialog();
        }

        private void Update_Accountant_Form_Load(object sender, EventArgs e)
        {
            a_name.Text = passName;
            a_id.Text = passId;
            a_pass.Text = passPass;
            a_com_pos.Text = passPos;
            a_com_dob.Text = passDob;
            a_com_gender.Text = passGender;
            a_com_blood.Text = passBlood;
            a_com_sal.Text = passSalary;
            a_con.Text = passContact;
            a_rich_ad.Text = passAdd;
        }
    }
}
