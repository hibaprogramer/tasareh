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
using System.Data.SqlClient;
namespace tsareh
{
    public partial class Form5 : Form
    {
        string User_ID; 
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'securDataSet4.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.securDataSet4.users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            DataAccessLayer dal;
            dal = new DataAccessLayer();

            try
            {
            OleDbCommand SqlCmd = new OleDbCommand("insert into users ( [u_name] , [password] , [u_group]) values(@u_name , @password , @u_group)", dal.SqlCon);
                SqlCmd.Parameters.AddWithValue("@u_name", textBox1.Text);
                SqlCmd.Parameters.AddWithValue("@password", textBox2.Text);
                SqlCmd.Parameters.AddWithValue("@u_group", comUserType.Text);
                SqlCmd.ExecuteNonQuery();
                dal.SqlCon.Close();
                this.usersTableAdapter.Fill(this.securDataSet4.users);
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {


            DataAccessLayer dal;
            dal = new DataAccessLayer();
            try
            {


                OleDbCommand SqlCmd = new OleDbCommand("update users set [u_name] = @u_name , [password] = @password " +
                    "                                                   , [u_group] = @u_group " +
                    "                                                    where [ID] = @ID ", dal.SqlCon);

            SqlCmd.Parameters.AddWithValue("@u_name", textBox1.Text);
            SqlCmd.Parameters.AddWithValue("@password", textBox2.Text);
            SqlCmd.Parameters.AddWithValue("@u_group", comUserType.Text);
            SqlCmd.Parameters.AddWithValue("@ID", int.Parse(User_ID));

                SqlCmd.ExecuteNonQuery();

                dal.SqlCon.Close();
            this.usersTableAdapter.Fill(this.securDataSet4.users);
        }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DataAccessLayer dal;
            dal = new DataAccessLayer();
            try
            {


                OleDbCommand SqlCmd = new OleDbCommand("update to users set u_name='" + textBox1.Text + "' , password='" + textBox2.Text + "', u_group='" + comUserType.SelectedItem + "' where u_name='" + textBox1.Text + "'", dal.SqlCon);

                SqlCmd.ExecuteNonQuery();

                dal.SqlCon.Close();

            }
            catch (Exception )
            {
                MessageBox.Show("error");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit_"].Index && e.RowIndex >= 0)
            {
                textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comUserType.SelectedItem = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                User_ID = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            else if(e.ColumnIndex == dataGridView1.Columns["Delete_"].Index && e.RowIndex >= 0)
            {
                DataAccessLayer dal;
                dal = new DataAccessLayer();
                textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                OleDbCommand SqlCmd = new OleDbCommand("delete from users where u_name='" + textBox1.Text + "'", dal.SqlCon);

                SqlCmd.ExecuteNonQuery();
                dal.SqlCon.Close();
                this.usersTableAdapter.Fill(this.securDataSet4.users);
            }
        }
    }
}
