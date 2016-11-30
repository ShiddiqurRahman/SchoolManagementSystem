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
    public partial class Update_Student_Form : Form
    {
        private string stuName;
        private string stuID;
        private string stuRoll;
        private string stuClass;
        private string stuDob;
        private string stuGender;
        private string stuBlood;
        private string stuGardian;
        private string stuContact;
        private string stuAddress;
        private string stuFee;
        private string stuScholarship;
        public string passStuName
        {
            get { return stuName; }
            set { stuName = value; }
        }

        public string passStuID
        {
            get { return stuID; }
            set { stuID = value; }
        }
        public string passStuRoll
        {
            get { return stuRoll; }
            set { stuRoll = value; }
        }


        public string passStuClass
        {
            get { return stuClass; }
            set { stuClass = value; }
        }


        public string passStuDob
        {
            get { return stuDob; }
            set { stuDob = value; }
        }


        public string passStuGender
        {
            get { return stuGender; }
            set { stuGender = value; }
        }


        public string passStuBlood
        {
            get { return stuBlood; }
            set { stuBlood = value; }
        }


        public string passStuGardian
        {
            get { return stuGardian; }
            set { stuGardian = value; }
        }


        public string passStuContact
        {
            get { return stuContact; }
            set { stuContact = value; }
        }


        public string passStuAddress
        {
            get { return stuAddress; }
            set { stuAddress = value; }
        }


        public string passStuFee
        {
            get { return stuFee; }
            set { stuFee = value; }
        }
        public string passStuScholarship
        {
            get { return stuScholarship; }
            set { stuScholarship = value; }
        }

        public Update_Student_Form()
        {
            InitializeComponent();
        }

        

        private void Update_Student_Form_Load(object sender, EventArgs e)
        {
            txtStdName.Text = stuName;
            txtStdID.Text = stuID;
            txtStdRoll.Text = stuRoll;
            txtStdclass.Text = stuClass;
            txtStdDob.Text = stuDob;
            txtStdGender.Text = stuGender;
            txtStdBlood.Text = stuBlood;
            txtStdGardian.Text = stuGardian;
            txtStdContact.Text = stuContact;
            txtStdAddress.Text = stuAddress;
            txtStdFee.Text = stuFee;
            txtStdFeeOff.Text = stuScholarship;
        }

        private void Stu_update_button_Click(object sender, EventArgs e)
        {
            string sName = txtStdName.Text;
            string sId = txtStdID.Text;
            string sRoll = txtStdRoll.Text;
            string sClass = txtStdclass.Text;
            string sDob = txtStdDob.Text;
            string sGender = txtStdGender.Text;
            string sBlood = txtStdBlood.Text;
            string sGd = txtStdGardian.Text;
            string sCon = txtStdContact.Text;
            string sAdd = txtStdAddress.Text;
            string sFee = txtStdFee.Text;
            string sSch = txtStdFeeOff.Text;

            queryClass.updateStudent(sName, sId, sRoll, sClass, sDob, sGender, sBlood, sGd, sCon, sAdd, sFee, sSch);
            this.Hide();
            Show_Student_Form d = new Show_Student_Form();
            d.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Teacher_Form d = new Show_Teacher_Form();
            d.Show();
        }
    }
}
