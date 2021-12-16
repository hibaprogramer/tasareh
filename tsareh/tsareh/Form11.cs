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
    public partial class Form11 : Form
    {
        DataAccessLayer dal;

        public Form11()
        {
            InitializeComponent();

          
                //SqlCmd.CommandType = CommandType.Text;

                //dReader = SqlCmd.ExecuteReader();
                //if (dReader.HasRows)
                //{
                //    string cont;
                //    dReader.Read();
                //    MessageBox.Show(dReader["u_name"].ToString());
                //    cont = dReader["u_name"].ToString();
                //    dReader.Close();

                //}
            //}
            //catch (SqlException exp)
            //{
            //    string xc = exp.ToString();

            //}
            //dReader.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dal = new DataAccessLayer();

            OleDbCommand SqlCmd = new OleDbCommand("select * from users where u_name='"+textBox1.Text+"'", dal.SqlCon);
            string per1 = "select u_group from users where u_name='" + textBox1.Text + "'";
            OleDbCommand per = new OleDbCommand(per1, dal.SqlCon);
           
            OleDbDataReader rd = SqlCmd.ExecuteReader();
          
                if (rd.Read())
            {
                
              
                if (textBox1.Text == "" && textBox2.Text == "")

                    {
                        MessageBox.Show("يرجى ادخال الاسم وكلمة مرور");
                    }

                    else
                    {



                    if (textBox1.Text.Equals(rd["u_name"].ToString()) && textBox2.Text.Equals(rd["password"].ToString()))

                    {

                        Form3 fm3 = new Form3();
                        fm3.Privilege_ = rd["u_group"].ToString();
                        string ss = rd["u_group"].ToString();
                        fm3.Privilege_ = ss;
                        fm3.Show();
                        //if (ss == "user")
                        //{
                        //    fm3.button5.Enabled = false;
                        //}

                    }




                    else
                        {
                            MessageBox.Show(" يرجى التأكد من اسم المستخدم او كلمة المرور");
                        }
                    }            dal.SqlCon.Close();
                           

                    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
