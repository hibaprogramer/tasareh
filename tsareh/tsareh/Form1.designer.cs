
namespace Hiba
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Emp_IDTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Attach_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Save_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Emp_IDTXT
            // 
            this.Emp_IDTXT.Enabled = false;
            this.Emp_IDTXT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_IDTXT.Location = new System.Drawing.Point(404, 35);
            this.Emp_IDTXT.Name = "Emp_IDTXT";
            this.Emp_IDTXT.Size = new System.Drawing.Size(147, 29);
            this.Emp_IDTXT.TabIndex = 0;
            this.Emp_IDTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Emp_IDTXT.TextChanged += new System.EventHandler(this.Emp_IDTXT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(557, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم القيــــد";
            // 
            // Attach_btn
            // 
            this.Attach_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Attach_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attach_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attach_btn.ForeColor = System.Drawing.Color.White;
            this.Attach_btn.Location = new System.Drawing.Point(286, 30);
            this.Attach_btn.Name = "Attach_btn";
            this.Attach_btn.Size = new System.Drawing.Size(91, 36);
            this.Attach_btn.TabIndex = 2;
            this.Attach_btn.Text = "اضافة صورة";
            this.Attach_btn.UseVisualStyleBackColor = false;
            this.Attach_btn.Click += new System.EventHandler(this.Attach_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 475);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.ForeColor = System.Drawing.Color.White;
            this.Save_btn.Location = new System.Drawing.Point(184, 30);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(91, 36);
            this.Save_btn.TabIndex = 5;
            this.Save_btn.Text = "حفظ الصورة";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(198, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(768, 584);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Attach_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Emp_IDTXT);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المرفقات";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Emp_IDTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Attach_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

