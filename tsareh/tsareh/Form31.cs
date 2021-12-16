using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tsareh
{
    public partial class Form31 : Form
    {
        public Form31()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
            MessageBox.Show("aaaaa");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}
