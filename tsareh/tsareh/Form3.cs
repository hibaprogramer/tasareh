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
    public partial class Form3 : Form
    {

        public string Privilege_ = "";
        public Form3()
        {

            InitializeComponent();


        //////}


        //public void Form3_Load()
        //{
        //    InitializeComponent();
            

            //if (Privilege_ == "user")
            //{
            //    button5.Enabled = false;
            //}

        }





        private void button6_Click(object sender, EventArgs e)
        {
               
                all_form frm = new all_form();
            frm.State_ = "new";
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            fm5.Show();
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            //1000000 - 10000001 - 100001002 -
            if (Privilege_ == "user")
            {
                button5.Enabled = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
