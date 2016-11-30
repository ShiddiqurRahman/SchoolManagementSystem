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
    public partial class Show_Accountant_Form : Form
    {
        public Show_Accountant_Form()
        {
            InitializeComponent();
        }

        private void Show_Accountant_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoStudentDataSet_Show_Accountant.accountant' table. You can move, or remove it, as needed.
            this.accountantTableAdapter.Fill(this.demoStudentDataSet_Show_Accountant.accountant);        
        }

        private void Acc_Search_TextChanged(object sender, EventArgs e)
        {
            string accID = Acc_Search.Text;
            queryClass.searchAcc(accID, this.DataGrid_All_Acc);
        }

        Update_Accountant_Form d1 = new Update_Accountant_Form();
        private void actionEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            string Aname = DataGrid_All_Acc.CurrentRow.Cells[1].Value.ToString();
            string Aid = DataGrid_All_Acc.CurrentRow.Cells[2].Value.ToString();
            string Apass = DataGrid_All_Acc.CurrentRow.Cells[3].Value.ToString();
            string Apos = DataGrid_All_Acc.CurrentRow.Cells[4].Value.ToString();
            string Adob = DataGrid_All_Acc.CurrentRow.Cells[5].Value.ToString();
            string Agender = DataGrid_All_Acc.CurrentRow.Cells[6].Value.ToString();
            string Ablood = DataGrid_All_Acc.CurrentRow.Cells[7].Value.ToString();
            string Asalary = DataGrid_All_Acc.CurrentRow.Cells[8].Value.ToString();
            string Acontact = DataGrid_All_Acc.CurrentRow.Cells[9].Value.ToString();
            string Aaddress = DataGrid_All_Acc.CurrentRow.Cells[10].Value.ToString();

            d1.passName = Aname;
            d1.passId = Aid;
            d1.passPass = Apass;
            d1.passPos = Apos;
            d1.passDob = Adob;
            d1.passGender = Agender;
            d1.passBlood = Ablood;
            d1.passSalary = Asalary;
            d1.passContact = Acontact;
            d1.passAdd = Aaddress;

            d1.ShowDialog();
        }

        private void actionDelete_Click(object sender, EventArgs e)
        {
            queryClass.AccountantDel(Acc_Search.Text, this.DataGrid_All_Acc);
            string ob = ""; // refresh accountant list
            queryClass.searchAcc(ob, this.DataGrid_All_Acc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Headmaster_Form d = new Headmaster_Form();
            d.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGrid_All_Acc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip_Acc_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aCTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountantBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void accountantBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
