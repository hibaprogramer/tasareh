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
using System.IO;
using Hiba;

namespace tsareh
{
    public partial class all_form : Form
    {
   


        DataAccessLayer dal;
     
        public string State_ = "";
        public string SerialNumber; 


        public all_form()
        {
            InitializeComponent();
        }

       public void Form4_Load(object sender, EventArgs e)
        {
            
                dal = new DataAccessLayer();

                string str = "select gov_id,gov_nam from governerate ";
                OleDbDataAdapter da = new OleDbDataAdapter(str, dal.SqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "gov_nam";
                comboBox5.ValueMember = "gov_id";
       

                string str1 = "select * from province ";
                OleDbDataAdapter da1 = new OleDbDataAdapter(str1, dal.SqlCon);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                comboBox4.DataSource = dt1;
                comboBox4.DisplayMember = "pro_name";
                comboBox4.ValueMember = "ID";

            if (State_ == "old")
            {
                
                DataAccessLayer dal;
                dal = new DataAccessLayer();

             

                    using (OleDbCommand  com = new OleDbCommand ("select * from emp_info Where ser_num = @SerialNumber ", dal.SqlCon))
                    {
                    OleDbCommand com2 = new OleDbCommand("select * from emp_detil", dal.SqlCon);
                        OleDbCommand com3 = new OleDbCommand("select * from permit ", dal.SqlCon);

                        com.Parameters.AddWithValue("@SerialNumber", SerialNumber);
                        DataTable dt5 = new DataTable();
                        OleDbDataAdapter  da5 = new OleDbDataAdapter(com);
                        da5.Fill(dt5);

                    DataTable dtcom2 = new DataTable();
                    OleDbDataAdapter dacom2 = new OleDbDataAdapter(com2);
                    dacom2.Fill(dtcom2);

                    DataTable dtcom3 = new DataTable();
                    OleDbDataAdapter dacom3 = new OleDbDataAdapter(com3);
                    dacom3.Fill(dtcom3);
                    t1.Text = dt5.Rows[0]["ser_num"].ToString();  
                        t2.Text = dt5.Rows[0]["emp_nam"].ToString();
                        t3.Text = dt5.Rows[0]["emp_fa"].ToString();
                        t4.Text = dt5.Rows[0]["emp_gf"].ToString();
                        t5.Text = dt5.Rows[0]["emp_ggf"].ToString();
                        t6.Text = dt5.Rows[0]["family_nam"].ToString();
                        t7.Text = dt5.Rows[0]["emp_ma"].ToString();
                        t8.Text = dt5.Rows[0]["emp_fa_ma"].ToString();
                    t9.Text = dt5.Rows[0]["emp_gf_ma"].ToString();
                    t10.Text = dt5.Rows[0]["emp_par"].ToString();
                    t11.Text = dt5.Rows[0]["emp_fa_par"].ToString();
                    t12.Text = dt5.Rows[0]["emp_gf_par"].ToString();
                    dateTimePicker2.Text = dt5.Rows[0]["berth_date"].ToString();
                    t14.Text = dt5.Rows[0]["berth_place"].ToString();
                    comboBox1.Text = dt5.Rows[0]["case_id"].ToString();
                    comboBox2.Text = dt5.Rows[0]["file_state"].ToString();

                    t15.Text = dtcom2.Rows[0]["dep_civil"].ToString();
                    t16.Text = dtcom2.Rows[0]["emp_ident"].ToString();
                    t17.Text = dtcom2.Rows[0]["record"].ToString();
                    t18.Text = dtcom2.Rows[0]["paper"].ToString();
                    comboBox4.Text = dtcom2.Rows[0]["present"].ToString();
                    t20.Text = dtcom2.Rows[0]["hay"].ToString();
                    t21.Text = dtcom2.Rows[0]["mahla"].ToString();
                    t22.Text = dtcom2.Rows[0]["zukak"].ToString();
                    t23.Text = dtcom2.Rows[0]["dar"].ToString();
                    t24.Text = dtcom2.Rows[0]["nerestpoint"].ToString();
                    t25.Text = dtcom2.Rows[0]["tam_num"].ToString();
                    comboBox5.Text = dtcom2.Rows[0]["dir"].ToString();
                    com_case.Text = dtcom2.Rows[0]["emp_case"].ToString();
                    textBox2.Text = dtcom2.Rows[0]["nots"].ToString();

                    comboBox3.Text = dtcom3.Rows[0]["per_type"].ToString();
                    textBox1.Text = dtcom3.Rows[0]["doc_num"].ToString();
                    dateTimePicker1.Text = dtcom3.Rows[0]["doc_date"].ToString();
                    textBox3.Text = dtcom3.Rows[0]["action"].ToString();

                }


            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       

        private  void button1_Click_2(object sender, EventArgs e)
        {
            DataAccessLayer dal;
            dal = new DataAccessLayer();

            {
                if (State_ == "new")
                {

                    string str1 = "insert into emp_info([ser_num],[emp_nam],[emp_fa],[emp_gf],[emp_ggf],[family_nam],[emp_ma],[emp_fa_ma],[emp_gf_ma],[emp_par],[emp_fa_par],[emp_gf_par],[berth_date],[berth_place],[case_id],[file_state]) values (@ser_num,@emp_nam,@emp_fa,@emp_gf,@emp_ggf,@family_nam,@emp_ma,@emp_fa_ma,@emp_gf_ma,@emp_par,@emp_fa_par,@emp_gf_par,@berth_date,@berth_place,@case_id,@file_state)";

                    string str2 = "insert into emp_detil ( [dep_civil], [emp_ident], [record], [paper], [present], [hay], [mahla], [zukak],[dar]," +
                        "[nerestpoint],[tam_num],[dir],[emp_case],[nots],[ser_num]) " +
                        "values (@dep_civil, @emp_ident, @record, @paper, @present, @hay, @mahla, @zukak,@dar,@nerestpoint,@tam_num," +
                        "@dir,@emp_case,@nots,@ser_num)";

                    string str3 = "insert into permit([ser_id],[per_type],[doc_num],[doc_date],[action]) values (@ser_id,@per_type,@doc_num,@doc_date,@action)";


                    OleDbCommand SqlCmd = new OleDbCommand(str1, dal.SqlCon);
                    OleDbCommand SqlCmd2 = new OleDbCommand(str2, dal.SqlCon);
                    OleDbCommand SqlCmd3 = new OleDbCommand(str3, dal.SqlCon);


                    SqlCmd.Parameters.AddWithValue("@ser_num", t1.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_nam", t2.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_fa", t3.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_gf", t4.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_ggf", t5.Text);

                    SqlCmd.Parameters.AddWithValue("@family_nam", t6.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_ma", t7.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_fa_ma", t8.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_gf_ma", t9.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_par", t10.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_fa_par", t11.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_gf_par", t12.Text);

                    SqlCmd.Parameters.AddWithValue("@berth_date", dateTimePicker2.Text);

                    SqlCmd.Parameters.AddWithValue("@berth_place", t14.Text);
                    SqlCmd.Parameters.AddWithValue("@case_id", comboBox1.Text);
                    SqlCmd.Parameters.AddWithValue("@file_state", comboBox2.Text);

                   
                    SqlCmd2.Parameters.AddWithValue("@dep_civil", t15.Text);
                    SqlCmd2.Parameters.AddWithValue("@emp_ident", t16.Text);
                    SqlCmd2.Parameters.AddWithValue("@record", t17.Text);
                    SqlCmd2.Parameters.AddWithValue("@paper", t18.Text);
                    SqlCmd2.Parameters.AddWithValue("@present", comboBox4.Text);
                    SqlCmd2.Parameters.AddWithValue("@hay", t20.Text);
                    SqlCmd2.Parameters.AddWithValue("@mahla", t21.Text);
                    SqlCmd2.Parameters.AddWithValue("@zukak", t22.Text);
                    SqlCmd2.Parameters.AddWithValue("@dar", t23.Text);
                    SqlCmd2.Parameters.AddWithValue("@nerestpoint", t24.Text);
                    SqlCmd2.Parameters.AddWithValue("@tam_num", t25.Text);
                    SqlCmd2.Parameters.AddWithValue("@dir", comboBox5.Text);
                    SqlCmd2.Parameters.AddWithValue("@emp_case", com_case.Text);
                    SqlCmd2.Parameters.AddWithValue("@nots", textBox2.Text);
                    SqlCmd2.Parameters.AddWithValue("@ser_num", t1.Text);

                    SqlCmd3.Parameters.AddWithValue("@ser_id",t1.Text);
                    SqlCmd3.Parameters.AddWithValue("@per_type",comboBox3.Text);
                    SqlCmd3.Parameters.AddWithValue("@doc_num", int.Parse(textBox1.Text));
                    SqlCmd3.Parameters.AddWithValue("@doc_date", dateTimePicker1.Text);
                    SqlCmd3.Parameters.AddWithValue("@action", textBox3.Text);



                    SqlCmd.ExecuteNonQuery();
                    SqlCmd2.ExecuteNonQuery();
                    SqlCmd3.ExecuteNonQuery();

                    MessageBox.Show("تم");
                    dal.SqlCon.Close();
                }
                else
                {

                    string str1 = "update emp_info set [ser_num]=@SerialNumber,[emp_nam]=@emp_nam, [emp_fa]=@emp_fa, [emp_gf]=@emp_gf, [emp_ggf]=@emp_ggf, [family_nam]=@family_nam, [emp_ma]=@emp_ma, [emp_fa_ma]=@emp_fa_ma, [emp_gf_ma]=@emp_gf_ma, [emp_par]=@emp_par,[emp_fa_par]=@emp_fa_par,[emp_gf_par]=@emp_gf_par,[berth_date]=@berth_date,[berth_place]=@berth_place,[case_id]=@case_id,[file_state]=@file_state where [ser_num]=@SerialNumber";

                    string str2 = "update emp_detil  set  [dep_civil]=@dep_civil, [emp_ident]=@emp_ident, [record]=@record, [paper]=@paper, [present]=@present, [hay]=@hay, [mahla]=@mahla, [zukak]=@zukak,[dar]=@dar," +
                        "[nerestpoint]=@nerestpoint,[tam_num]=@tam_num,[dir]=@dir,[emp_case]=@emp_case,[nots]=@nots,[ser_num]=@SerialNumber where [ser_num]=@SerialNumber ";


                    string str3 = "update permit set [ser_id]=@SerialNumber, [per_type]= @per_type,[doc_num]= @doc_num,[doc_date]=@doc_date,[action]=@action where [ser_id]=@SerialNumber"; 
                        


                    OleDbCommand SqlCmd = new OleDbCommand(str1, dal.SqlCon);
                    OleDbCommand SqlCmd2 = new OleDbCommand(str2, dal.SqlCon);
                    OleDbCommand SqlCmd3 = new OleDbCommand(str3, dal.SqlCon);

                    SqlCmd.Parameters.AddWithValue("@ser_num", t1.Text);
                    SqlCmd.Parameters.AddWithValue("@emp_nam", t2.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_fa", t3.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_gf", t4.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_ggf", t5.Text);

                    SqlCmd.Parameters.AddWithValue("@family_nam", t6.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_ma", t7.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_fa_ma", t8.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_gf_ma", t9.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_par", t10.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_fa_par", t11.Text);

                    SqlCmd.Parameters.AddWithValue("@emp_gf_par", t12.Text);

                    SqlCmd.Parameters.AddWithValue("@berth_date", dateTimePicker2.Text);

                    SqlCmd.Parameters.AddWithValue("@berth_place", t14.Text);
                    SqlCmd.Parameters.AddWithValue("@case_id", comboBox1.Text);
                    SqlCmd.Parameters.AddWithValue("@file_state", comboBox2.Text);


                    SqlCmd2.Parameters.AddWithValue("@dep_civil", t15.Text);
                    SqlCmd2.Parameters.AddWithValue("@emp_ident", t16.Text);
                    SqlCmd2.Parameters.AddWithValue("@record", t17.Text);
                    SqlCmd2.Parameters.AddWithValue("@paper", t18.Text);
                    SqlCmd2.Parameters.AddWithValue("@present", comboBox4.Text);
                    SqlCmd2.Parameters.AddWithValue("@hay", t20.Text);
                    SqlCmd2.Parameters.AddWithValue("@mahla", t21.Text);
                    SqlCmd2.Parameters.AddWithValue("@zukak", t22.Text);
                    SqlCmd2.Parameters.AddWithValue("@dar", t23.Text);
                    SqlCmd2.Parameters.AddWithValue("@nerestpoint", t24.Text);
                    SqlCmd2.Parameters.AddWithValue("@tam_num", t25.Text);
                    SqlCmd2.Parameters.AddWithValue("@dir", comboBox5.Text);
                    SqlCmd2.Parameters.AddWithValue("@emp_case", com_case.Text);
                    SqlCmd2.Parameters.AddWithValue("@nots", textBox2.Text);
                    SqlCmd2.Parameters.AddWithValue("@ser_num", t1.Text);

                    SqlCmd3.Parameters.AddWithValue("@ser_id", t1.Text);
                    SqlCmd3.Parameters.AddWithValue("@per_type", comboBox3.Text);
                    SqlCmd3.Parameters.AddWithValue("@doc_num", int.Parse(textBox1.Text));
                    SqlCmd3.Parameters.AddWithValue("@doc_date", dateTimePicker1.Text);
                    SqlCmd3.Parameters.AddWithValue("@action", textBox3.Text);



                    SqlCmd.ExecuteNonQuery();
                    SqlCmd2.ExecuteNonQuery();
                    SqlCmd3.ExecuteNonQuery();

                    MessageBox.Show("تم");
                    dal.SqlCon.Close();
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            t1.Text = string.Empty;
            t2.Text = string.Empty ;
            t3.Text = string.Empty;
            t4.Text = string.Empty;
            t5.Text = string.Empty;
            t6.Text = string.Empty;
            t7.Text = string.Empty;
            t8.Text = string.Empty;
            t9.Text = string.Empty;
            t10.Text = string.Empty;
            t11.Text = string.Empty;
            t12.Text = string.Empty;
            dateTimePicker2.CustomFormat = "";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            t14.Text = string.Empty;
            t15.Text = string.Empty;
            t16.Text = string.Empty;
            t17.Text = string.Empty;
            t18.Text = string.Empty;
            comboBox4.Text = string.Empty;
            t20.Text = string.Empty;
            t21.Text = string.Empty;
            t22.Text = string.Empty;
            t23.Text = string.Empty;
            t24.Text = string.Empty;
            t25.Text = string.Empty;
            comboBox5.Text = string.Empty;
            com_case.Text = string.Empty;


            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            textBox1.Text = string.Empty;
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
           



        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void t20_TextChanged(object sender, EventArgs e)
        {

        }
       
        public void button3_Click(object sender, EventArgs e)
        {      
            Form1 fm = new Form1();
            fm.ser = (t1.Text).ToString();
            fm.Show();

            //fm6.button4_Click(int.Parse(t1.Text));


        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void all_form_Activated(object sender, EventArgs e)
        {
           
            if (State_ == "old")
            {
                button1.Text = "تعديل";
                button6.Visible = true;
            }
            else
            {
                button1.Text = "حفظ";
                button6.Visible = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void t2_TextChanged(object sender, EventArgs e)
        {
            //if(t2.Text==" ")
            //{
            //    t2.Focus();
            //}
            //else
            //{
            //    t3.Focus();
            //}
        }

        private void t3_TextChanged(object sender, EventArgs e)
        {
            //if (t3.Text == " ")
            //{
            //    t3.Focus();
            //}
            //else
            //{
            //    t4.Focus();
            //}
        }

        private void t2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (t2.Text == " ")
            {
                t2.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal;
            dal = new DataAccessLayer();
            string ss = SerialNumber;
            OleDbCommand SqlCmd = new OleDbCommand("delete from emp_info where [ser_num]='"+t1.Text+"'", dal.SqlCon);
            OleDbCommand SqlCmd1 = new OleDbCommand("delete from emp_detil where [ser_num]='" + t1.Text + "'" , dal.SqlCon);
            OleDbCommand SqlCmd2 = new OleDbCommand("delete from permit where [ser_id]='" + t1.Text + "'" , dal.SqlCon);
            SqlCmd.ExecuteNonQuery();
            SqlCmd1.ExecuteNonQuery();
            SqlCmd2.ExecuteNonQuery();
            MessageBox.Show("تم");
            dal.SqlCon.Close();

            t1.Text = string.Empty;
            t2.Text = string.Empty;
            t3.Text = string.Empty;
            t4.Text = string.Empty;
            t5.Text = string.Empty;
            t6.Text = string.Empty;
            t7.Text = string.Empty;
            t8.Text = string.Empty;
            t9.Text = string.Empty;
            t10.Text = string.Empty;
            t11.Text = string.Empty;
            t12.Text = string.Empty;
            dateTimePicker2.CustomFormat = "";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            t14.Text = string.Empty;
            t15.Text = string.Empty;
            t16.Text = string.Empty;
            t17.Text = string.Empty;
            t18.Text = string.Empty;
            comboBox4.Text = string.Empty;
            t20.Text = string.Empty;
            t21.Text = string.Empty;
            t22.Text = string.Empty;
            t23.Text = string.Empty;
            t24.Text = string.Empty;
            t25.Text = string.Empty;
            comboBox5.Text = string.Empty;
            com_case.Text = string.Empty;


            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            textBox1.Text = string.Empty;
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;



        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
    }

