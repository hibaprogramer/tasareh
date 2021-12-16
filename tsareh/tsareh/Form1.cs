using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hiba
{
    public partial class Form1 : Form
    {
        public string ser ;

        List<string> PathList = new List<string>();
        public Form1()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
        }
        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter =
                "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "All files (*.*)|*.*";

            //  Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            //                   ^  ^  ^  ^  ^  ^  ^

            this.openFileDialog1.Title = "My Image Browser";
        }
        private void Attach_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                {
                    // Create a PictureBox.
                    try
                    {
                        Button btn = new Button();
                        btn.Click += btn_Click;
                        btn.Tag = file;
                        btn.Text = "Show";
                        PictureBox pb = new PictureBox();
                        Image loadedImage = Image.FromFile(file);
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        //pb.Height = loadedImage.Height;
                        //pb.Width = loadedImage.Width;
                        pb.Image = loadedImage;
                        flowLayoutPanel1.Controls.Add(pb);
                        flowLayoutPanel1.Controls.Add(btn);
                        PathList.Add(file);
                        //Console.WriteLine(file);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Console.WriteLine(clickedButton.Tag.ToString());
            pictureBox1.Image = Image.FromFile(@clickedButton.Tag.ToString());
        }

        private void View_btn_Click(object sender, EventArgs e)
        {
         
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            using (var con = new OleDbConnection(tsareh.Properties.Settings.Default.securConnectionString))
            {
                con.Open();
                foreach (var value in PathList)
                {
                    string path1 = @value.ToString();
                    using (var cmd = new OleDbCommand(@"INSERT INTO ImgTbl(EMP_id , IMG_path)VALUES(@ser , " + "'" + path1 + "'" + ")", con))
                    {
                        cmd.Parameters.AddWithValue("@EMP_id", ser);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Emp_IDTXT.Text = ser;
        }

        private void Emp_IDTXT_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
