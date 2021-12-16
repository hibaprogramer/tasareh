
namespace tsareh
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.empinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securDataSet3 = new tsareh.securDataSet3();
            this.emp_infoTableAdapter = new tsareh.securDataSet3TableAdapters.emp_infoTableAdapter();
            this.securDataSet1 = new tsareh.securDataSet();
            this.empinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.securDataSet5 = new tsareh.securDataSet5();
            this.emp_infoTableAdapter1 = new tsareh.securDataSet5TableAdapters.emp_infoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.securDataSet7 = new tsareh.securDataSet7();
            this.securDataSet6 = new tsareh.securDataSet6();
            this.allinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all_infoTableAdapter = new tsareh.securDataSet6TableAdapters.all_infoTableAdapter();
            this.all_infoTableAdapter1 = new tsareh.securDataSet7TableAdapters.all_infoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit_ = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sernumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empgfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empggfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familynamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empcaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filestateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.per_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.empinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // empinfoBindingSource
            // 
            this.empinfoBindingSource.DataMember = "emp_info";
            this.empinfoBindingSource.DataSource = this.securDataSet3;
            // 
            // securDataSet3
            // 
            this.securDataSet3.DataSetName = "securDataSet3";
            this.securDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emp_infoTableAdapter
            // 
            this.emp_infoTableAdapter.ClearBeforeFill = true;
            // 
            // securDataSet1
            // 
            this.securDataSet1.DataSetName = "securDataSet";
            this.securDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empinfoBindingSource1
            // 
            this.empinfoBindingSource1.DataMember = "emp_info";
            this.empinfoBindingSource1.DataSource = this.securDataSet5;
            // 
            // securDataSet5
            // 
            this.securDataSet5.DataSetName = "securDataSet5";
            this.securDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emp_infoTableAdapter1
            // 
            this.emp_infoTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit_,
            this.sernumDataGridViewTextBoxColumn,
            this.empnamDataGridViewTextBoxColumn,
            this.empfaDataGridViewTextBoxColumn,
            this.empgfDataGridViewTextBoxColumn,
            this.empggfDataGridViewTextBoxColumn,
            this.familynamDataGridViewTextBoxColumn,
            this.dirDataGridViewTextBoxColumn,
            this.empcaseDataGridViewTextBoxColumn,
            this.caseidDataGridViewTextBoxColumn,
            this.filestateDataGridViewTextBoxColumn,
            this.per_type});
            this.dataGridView1.DataSource = this.allinfoBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(2, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1366, 604);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // allinfoBindingSource1
            // 
            this.allinfoBindingSource1.DataMember = "all_info";
            this.allinfoBindingSource1.DataSource = this.securDataSet7;
            // 
            // securDataSet7
            // 
            this.securDataSet7.DataSetName = "securDataSet7";
            this.securDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // securDataSet6
            // 
            this.securDataSet6.DataSetName = "securDataSet6";
            this.securDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allinfoBindingSource
            // 
            this.allinfoBindingSource.DataMember = "all_info";
            this.allinfoBindingSource.DataSource = this.securDataSet6;
            // 
            // all_infoTableAdapter
            // 
            this.all_infoTableAdapter.ClearBeforeFill = true;
            // 
            // all_infoTableAdapter1
            // 
            this.all_infoTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(981, 531);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("TeamViewer15", 12.75F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(458, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(753, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "البحــــــث";
            // 
            // Edit_
            // 
            this.Edit_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Edit_.HeaderText = "تعديـــل";
            this.Edit_.Name = "Edit_";
            this.Edit_.Width = 50;
            // 
            // sernumDataGridViewTextBoxColumn
            // 
            this.sernumDataGridViewTextBoxColumn.DataPropertyName = "ser_num";
            this.sernumDataGridViewTextBoxColumn.HeaderText = "رقــم القيـــد";
            this.sernumDataGridViewTextBoxColumn.Name = "sernumDataGridViewTextBoxColumn";
            // 
            // empnamDataGridViewTextBoxColumn
            // 
            this.empnamDataGridViewTextBoxColumn.DataPropertyName = "emp_nam";
            this.empnamDataGridViewTextBoxColumn.HeaderText = "الاســــــم";
            this.empnamDataGridViewTextBoxColumn.Name = "empnamDataGridViewTextBoxColumn";
            // 
            // empfaDataGridViewTextBoxColumn
            // 
            this.empfaDataGridViewTextBoxColumn.DataPropertyName = "emp_fa";
            this.empfaDataGridViewTextBoxColumn.HeaderText = "الاب";
            this.empfaDataGridViewTextBoxColumn.Name = "empfaDataGridViewTextBoxColumn";
            // 
            // empgfDataGridViewTextBoxColumn
            // 
            this.empgfDataGridViewTextBoxColumn.DataPropertyName = "emp_gf";
            this.empgfDataGridViewTextBoxColumn.HeaderText = "الجــــــد";
            this.empgfDataGridViewTextBoxColumn.Name = "empgfDataGridViewTextBoxColumn";
            // 
            // empggfDataGridViewTextBoxColumn
            // 
            this.empggfDataGridViewTextBoxColumn.DataPropertyName = "emp_ggf";
            this.empggfDataGridViewTextBoxColumn.HeaderText = "اب الجــــد";
            this.empggfDataGridViewTextBoxColumn.Name = "empggfDataGridViewTextBoxColumn";
            // 
            // familynamDataGridViewTextBoxColumn
            // 
            this.familynamDataGridViewTextBoxColumn.DataPropertyName = "family_nam";
            this.familynamDataGridViewTextBoxColumn.HeaderText = "اللقــــب";
            this.familynamDataGridViewTextBoxColumn.Name = "familynamDataGridViewTextBoxColumn";
            // 
            // dirDataGridViewTextBoxColumn
            // 
            this.dirDataGridViewTextBoxColumn.DataPropertyName = "Dir";
            this.dirDataGridViewTextBoxColumn.HeaderText = "الدائـــرة";
            this.dirDataGridViewTextBoxColumn.Name = "dirDataGridViewTextBoxColumn";
            this.dirDataGridViewTextBoxColumn.Width = 250;
            // 
            // empcaseDataGridViewTextBoxColumn
            // 
            this.empcaseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empcaseDataGridViewTextBoxColumn.DataPropertyName = "emp_case";
            this.empcaseDataGridViewTextBoxColumn.HeaderText = "صفـــــة الموظـــف";
            this.empcaseDataGridViewTextBoxColumn.Name = "empcaseDataGridViewTextBoxColumn";
            // 
            // caseidDataGridViewTextBoxColumn
            // 
            this.caseidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.caseidDataGridViewTextBoxColumn.DataPropertyName = "case_id";
            this.caseidDataGridViewTextBoxColumn.HeaderText = "حـــالة القيــــــد";
            this.caseidDataGridViewTextBoxColumn.Name = "caseidDataGridViewTextBoxColumn";
            // 
            // filestateDataGridViewTextBoxColumn
            // 
            this.filestateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filestateDataGridViewTextBoxColumn.DataPropertyName = "file_state";
            this.filestateDataGridViewTextBoxColumn.HeaderText = "موقــف الاضبــــــارة";
            this.filestateDataGridViewTextBoxColumn.Name = "filestateDataGridViewTextBoxColumn";
            // 
            // per_type
            // 
            this.per_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.per_type.DataPropertyName = "per_type";
            this.per_type.HeaderText = "موقـــف التصريــــــح";
            this.per_type.Name = "per_type";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1370, 680);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private securDataSet3 securDataSet3;
        private System.Windows.Forms.BindingSource empinfoBindingSource;
        private securDataSet3TableAdapters.emp_infoTableAdapter emp_infoTableAdapter;
        private securDataSet securDataSet1;
        private securDataSet5 securDataSet5;
        private System.Windows.Forms.BindingSource empinfoBindingSource1;
        private securDataSet5TableAdapters.emp_infoTableAdapter emp_infoTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private securDataSet6 securDataSet6;
        private System.Windows.Forms.BindingSource allinfoBindingSource;
        private securDataSet6TableAdapters.all_infoTableAdapter all_infoTableAdapter;
        private securDataSet7 securDataSet7;
        private System.Windows.Forms.BindingSource allinfoBindingSource1;
        private securDataSet7TableAdapters.all_infoTableAdapter all_infoTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn Edit_;
        private System.Windows.Forms.DataGridViewTextBoxColumn sernumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empgfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empggfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familynamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empcaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filestateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn per_type;
    }
}