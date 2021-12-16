using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace tsareh
{
    public partial class Form2 : Form
    {
        DataAccessLayer dal;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'securDataSet7.all_info' table. You can move, or remove it, as needed.
            this.all_infoTableAdapter1.Fill(this.securDataSet7.all_info);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit_"].Index && e.RowIndex >= 0)
            {
                all_form frm = new all_form();
                frm.State_ = "old";
                frm.SerialNumber = this.dataGridView1.CurrentRow.Cells["sernumDataGridViewTextBoxColumn"].Value.ToString();
                frm.ShowDialog();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dal = new DataAccessLayer();
            OleDbCommand SqlCmd = new OleDbCommand("select * from all_info where emp_nam like '" + textBox1.Text + "%'", dal.SqlCon);
            OleDbDataAdapter da = new OleDbDataAdapter(SqlCmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dal.SqlCon.Close();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            //this.button2_Click_1( sur_num);


        }

        public void button2_Click_1(object sender, EventArgs e)
        {
            //int num = int.Parse(sur_num);
 





        }
    }
}
