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
    public partial class stuFormProfile : Form
    {
        public stuFormProfile()
        {
            InitializeComponent();
        }



        string passName;
        string passId;
        string passRoll;
        string passClass;
        string passDob;
        string passGender;
        string passBlood;
        string passGardian;
        string passConatct;
        string passAddress;

        public string passStuName
        {
            get { return passName; }
            set { passName = value; }
        }

        public string passStuId
        {
            get { return passId; }
            set { passId = value; }
        }


        public string passStuRoll
        {
            get { return passRoll; }
            set { passRoll = value; }
        }


        public string passStuClass
        {
            get { return passClass; }
            set { passClass = value; }
        }

        public string passStuDob
        {
            get { return passDob; }
            set { passDob = value; }
        }

        public string passStuGender
        {
            get { return passGender; }
            set { passGender = value; }
        }

        public string passStuBlood
        {
            get { return passBlood; }
            set { passBlood = value; }
        }

        public string passStuGardian
        {
            get { return passGardian; }
            set { passGardian = value; }
        }

        public string passStuContact
        {
            get { return passConatct; }
            set { passConatct = value; }
        }

        public string passStuAddress
        {
            get { return passAddress; ; }
            set { passAddress = value; }
        }

        private void stuFormProfile_Load(object sender, EventArgs e)
        {
            txt_name.Text = passName;
            txt_id.Text = passStuId;
            txt_roll.Text = passStuRoll;
            txt_class.Text = passStuClass;
            txt_dob.Text = passStuDob;
            txt_gender.Text = passStuGender;
            txt_blood.Text = passStuBlood;
            txt_gardian.Text = passStuGardian;
            txt_contact.Text = passStuContact;
            txt_address.Text = passStuAddress;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
