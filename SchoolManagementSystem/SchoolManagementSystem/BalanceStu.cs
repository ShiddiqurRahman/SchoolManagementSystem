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
    public partial class BalanceStu : Form
    {
        public BalanceStu()
        {
            InitializeComponent();
        }

        private void BalanceStu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoStudentDataSet_BalanceStu.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.demoStudentDataSet_BalanceStu.student);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string studentID = txtSearch.Text;
            queryClass.searchStu(studentID, this.dataGridView1_BALANCE);
        }

        private void btn_add_fees_Click(object sender, EventArgs e)
        {
            
                string Stuid = dataGridView1_BALANCE.CurrentRow.Cells[2].Value.ToString();
                string oldfee = dataGridView1_BALANCE.CurrentRow.Cells[4].Value.ToString();
                string adFee = txt_fees.Text;

                queryClass.add_fee(Stuid, oldfee, adFee);
           
        }

        private void btn_add_schlr_Click(object sender, EventArgs e)
        {
            string Stuid = dataGridView1_BALANCE.CurrentRow.Cells[2].Value.ToString();
            string oldSch = dataGridView1_BALANCE.CurrentRow.Cells[5].Value.ToString();
            string adsch = txt_Schlr.Text;
            queryClass.add_sch(Stuid, oldSch, adsch);
        }

        private void dataGridView1_BALANCE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
