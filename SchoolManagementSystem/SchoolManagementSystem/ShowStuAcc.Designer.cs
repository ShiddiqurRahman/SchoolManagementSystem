namespace SchoolManagementSystem
{
    partial class ShowStuAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStuAcc));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DataGrideView_AllStu = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeAfterScholarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scholoshipStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoStudentDataSet_ShowStuAcc = new SchoolManagementSystem.DemoStudentDataSet_ShowStuAcc();
            this.studentTableAdapter = new SchoolManagementSystem.DemoStudentDataSet_ShowStuAccTableAdapters.studentTableAdapter();
            this.dataGridDemo = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classStdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gardianStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scholoshipStdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeAfterScholarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.demoStudentDataSet = new SchoolManagementSystem.DemoStudentDataSet();
            this.studentTableAdapter1 = new SchoolManagementSystem.DemoStudentDataSetTableAdapters.studentTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrideView_AllStu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_ShowStuAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(154, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(246, 59);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(394, 25);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "View Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGrideView_AllStu
            // 
            this.DataGrideView_AllStu.AutoGenerateColumns = false;
            this.DataGrideView_AllStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrideView_AllStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameStdDataGridViewTextBoxColumn,
            this.idStdDataGridViewTextBoxColumn,
            this.classStdDataGridViewTextBoxColumn,
            this.feeAfterScholarDataGridViewTextBoxColumn,
            this.scholoshipStdDataGridViewTextBoxColumn});
            this.DataGrideView_AllStu.DataSource = this.studentBindingSource;
            this.DataGrideView_AllStu.Location = new System.Drawing.Point(159, 135);
            this.DataGrideView_AllStu.Name = "DataGrideView_AllStu";
            this.DataGrideView_AllStu.Size = new System.Drawing.Size(661, 404);
            this.DataGrideView_AllStu.TabIndex = 23;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "SL";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameStdDataGridViewTextBoxColumn
            // 
            this.nameStdDataGridViewTextBoxColumn.DataPropertyName = "nameStd";
            this.nameStdDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameStdDataGridViewTextBoxColumn.Name = "nameStdDataGridViewTextBoxColumn";
            // 
            // idStdDataGridViewTextBoxColumn
            // 
            this.idStdDataGridViewTextBoxColumn.DataPropertyName = "idStd";
            this.idStdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idStdDataGridViewTextBoxColumn.Name = "idStdDataGridViewTextBoxColumn";
            // 
            // classStdDataGridViewTextBoxColumn
            // 
            this.classStdDataGridViewTextBoxColumn.DataPropertyName = "classStd";
            this.classStdDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classStdDataGridViewTextBoxColumn.Name = "classStdDataGridViewTextBoxColumn";
            // 
            // feeAfterScholarDataGridViewTextBoxColumn
            // 
            this.feeAfterScholarDataGridViewTextBoxColumn.DataPropertyName = "feeAfterScholar";
            this.feeAfterScholarDataGridViewTextBoxColumn.HeaderText = "TotalFees";
            this.feeAfterScholarDataGridViewTextBoxColumn.Name = "feeAfterScholarDataGridViewTextBoxColumn";
            // 
            // scholoshipStdDataGridViewTextBoxColumn
            // 
            this.scholoshipStdDataGridViewTextBoxColumn.DataPropertyName = "scholoshipStd";
            this.scholoshipStdDataGridViewTextBoxColumn.HeaderText = "Scholarship";
            this.scholoshipStdDataGridViewTextBoxColumn.Name = "scholoshipStdDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.demoStudentDataSet_ShowStuAcc;
            // 
            // demoStudentDataSet_ShowStuAcc
            // 
            this.demoStudentDataSet_ShowStuAcc.DataSetName = "DemoStudentDataSet_ShowStuAcc";
            this.demoStudentDataSet_ShowStuAcc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridDemo
            // 
            this.dataGridDemo.AutoGenerateColumns = false;
            this.dataGridDemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDemo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameStdDataGridViewTextBoxColumn1,
            this.idStdDataGridViewTextBoxColumn1,
            this.rollStdDataGridViewTextBoxColumn,
            this.classStdDataGridViewTextBoxColumn1,
            this.dobStdDataGridViewTextBoxColumn,
            this.genderStdDataGridViewTextBoxColumn,
            this.bloodStdDataGridViewTextBoxColumn,
            this.gardianStdDataGridViewTextBoxColumn,
            this.contactStdDataGridViewTextBoxColumn,
            this.addressStdDataGridViewTextBoxColumn,
            this.feeStdDataGridViewTextBoxColumn,
            this.scholoshipStdDataGridViewTextBoxColumn1,
            this.feeAfterScholarDataGridViewTextBoxColumn1});
            this.dataGridDemo.DataSource = this.studentBindingSource1;
            this.dataGridDemo.Location = new System.Drawing.Point(1066, 31);
            this.dataGridDemo.Name = "dataGridDemo";
            this.dataGridDemo.Size = new System.Drawing.Size(240, 150);
            this.dataGridDemo.TabIndex = 24;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameStdDataGridViewTextBoxColumn1
            // 
            this.nameStdDataGridViewTextBoxColumn1.DataPropertyName = "nameStd";
            this.nameStdDataGridViewTextBoxColumn1.HeaderText = "nameStd";
            this.nameStdDataGridViewTextBoxColumn1.Name = "nameStdDataGridViewTextBoxColumn1";
            // 
            // idStdDataGridViewTextBoxColumn1
            // 
            this.idStdDataGridViewTextBoxColumn1.DataPropertyName = "idStd";
            this.idStdDataGridViewTextBoxColumn1.HeaderText = "idStd";
            this.idStdDataGridViewTextBoxColumn1.Name = "idStdDataGridViewTextBoxColumn1";
            // 
            // rollStdDataGridViewTextBoxColumn
            // 
            this.rollStdDataGridViewTextBoxColumn.DataPropertyName = "rollStd";
            this.rollStdDataGridViewTextBoxColumn.HeaderText = "rollStd";
            this.rollStdDataGridViewTextBoxColumn.Name = "rollStdDataGridViewTextBoxColumn";
            // 
            // classStdDataGridViewTextBoxColumn1
            // 
            this.classStdDataGridViewTextBoxColumn1.DataPropertyName = "classStd";
            this.classStdDataGridViewTextBoxColumn1.HeaderText = "classStd";
            this.classStdDataGridViewTextBoxColumn1.Name = "classStdDataGridViewTextBoxColumn1";
            // 
            // dobStdDataGridViewTextBoxColumn
            // 
            this.dobStdDataGridViewTextBoxColumn.DataPropertyName = "dobStd";
            this.dobStdDataGridViewTextBoxColumn.HeaderText = "dobStd";
            this.dobStdDataGridViewTextBoxColumn.Name = "dobStdDataGridViewTextBoxColumn";
            // 
            // genderStdDataGridViewTextBoxColumn
            // 
            this.genderStdDataGridViewTextBoxColumn.DataPropertyName = "genderStd";
            this.genderStdDataGridViewTextBoxColumn.HeaderText = "genderStd";
            this.genderStdDataGridViewTextBoxColumn.Name = "genderStdDataGridViewTextBoxColumn";
            // 
            // bloodStdDataGridViewTextBoxColumn
            // 
            this.bloodStdDataGridViewTextBoxColumn.DataPropertyName = "bloodStd";
            this.bloodStdDataGridViewTextBoxColumn.HeaderText = "bloodStd";
            this.bloodStdDataGridViewTextBoxColumn.Name = "bloodStdDataGridViewTextBoxColumn";
            // 
            // gardianStdDataGridViewTextBoxColumn
            // 
            this.gardianStdDataGridViewTextBoxColumn.DataPropertyName = "gardianStd";
            this.gardianStdDataGridViewTextBoxColumn.HeaderText = "gardianStd";
            this.gardianStdDataGridViewTextBoxColumn.Name = "gardianStdDataGridViewTextBoxColumn";
            // 
            // contactStdDataGridViewTextBoxColumn
            // 
            this.contactStdDataGridViewTextBoxColumn.DataPropertyName = "contactStd";
            this.contactStdDataGridViewTextBoxColumn.HeaderText = "contactStd";
            this.contactStdDataGridViewTextBoxColumn.Name = "contactStdDataGridViewTextBoxColumn";
            // 
            // addressStdDataGridViewTextBoxColumn
            // 
            this.addressStdDataGridViewTextBoxColumn.DataPropertyName = "addressStd";
            this.addressStdDataGridViewTextBoxColumn.HeaderText = "addressStd";
            this.addressStdDataGridViewTextBoxColumn.Name = "addressStdDataGridViewTextBoxColumn";
            // 
            // feeStdDataGridViewTextBoxColumn
            // 
            this.feeStdDataGridViewTextBoxColumn.DataPropertyName = "feeStd";
            this.feeStdDataGridViewTextBoxColumn.HeaderText = "feeStd";
            this.feeStdDataGridViewTextBoxColumn.Name = "feeStdDataGridViewTextBoxColumn";
            // 
            // scholoshipStdDataGridViewTextBoxColumn1
            // 
            this.scholoshipStdDataGridViewTextBoxColumn1.DataPropertyName = "scholoshipStd";
            this.scholoshipStdDataGridViewTextBoxColumn1.HeaderText = "scholoshipStd";
            this.scholoshipStdDataGridViewTextBoxColumn1.Name = "scholoshipStdDataGridViewTextBoxColumn1";
            // 
            // feeAfterScholarDataGridViewTextBoxColumn1
            // 
            this.feeAfterScholarDataGridViewTextBoxColumn1.DataPropertyName = "feeAfterScholar";
            this.feeAfterScholarDataGridViewTextBoxColumn1.HeaderText = "feeAfterScholar";
            this.feeAfterScholarDataGridViewTextBoxColumn1.Name = "feeAfterScholarDataGridViewTextBoxColumn1";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.demoStudentDataSet;
            // 
            // demoStudentDataSet
            // 
            this.demoStudentDataSet.DataSetName = "DemoStudentDataSet";
            this.demoStudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(915, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 59;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShowStuAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1046, 557);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridDemo);
            this.Controls.Add(this.DataGrideView_AllStu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowStuAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowStuAcc";
            this.Load += new System.EventHandler(this.ShowStuAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrideView_AllStu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_ShowStuAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataGrideView_AllStu;
        private DemoStudentDataSet_ShowStuAcc demoStudentDataSet_ShowStuAcc;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DemoStudentDataSet_ShowStuAccTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeAfterScholarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scholoshipStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridDemo;
        private DemoStudentDataSet demoStudentDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private DemoStudentDataSetTableAdapters.studentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classStdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gardianStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scholoshipStdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeAfterScholarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button2;
    }
}