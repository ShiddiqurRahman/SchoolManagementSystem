namespace SchoolManagementSystem
{
    partial class Show_Student_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Student_Form));
            this.label2 = new System.Windows.Forms.Label();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.demoStudentDataSet_Show_Student = new SchoolManagementSystem.DemoStudentDataSet_Show_Student();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Stu_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.student_menuStrip = new System.Windows.Forms.MenuStrip();
            this.aCTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.actionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.studentTableAdapter = new SchoolManagementSystem.DemoStudentDataSet_Show_StudentTableAdapters.studentTableAdapter();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.classCombo = new System.Windows.Forms.ComboBox();
            this.studentTableAdapter1 = new SchoolManagementSystem.DemoStudentDataSet2TableAdapters.studentTableAdapter();
            this.DataGrid_All_Student = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.demoStudentDataSet1 = new SchoolManagementSystem.DemoStudentDataSet1();
            this.studentTableAdapter2 = new SchoolManagementSystem.DemoStudentDataSet1TableAdapters.studentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_Show_Student)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.student_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_All_Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(575, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "ALL STUDENT ";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.demoStudentDataSet_Show_Student;
            // 
            // demoStudentDataSet_Show_Student
            // 
            this.demoStudentDataSet_Show_Student.DataSetName = "DemoStudentDataSet_Show_Student";
            this.demoStudentDataSet_Show_Student.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.71951F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.28049F));
            this.tableLayoutPanel1.Controls.Add(this.Stu_Search, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(85, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 34);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // Stu_Search
            // 
            this.Stu_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stu_Search.Location = new System.Drawing.Point(129, 3);
            this.Stu_Search.Name = "Stu_Search";
            this.Stu_Search.Size = new System.Drawing.Size(187, 31);
            this.Stu_Search.TabIndex = 6;
            this.Stu_Search.TextChanged += new System.EventHandler(this.Stu_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "SEARCH";
            // 
            // student_menuStrip
            // 
            this.student_menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.student_menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCTIONToolStripMenuItem});
            this.student_menuStrip.Location = new System.Drawing.Point(416, 70);
            this.student_menuStrip.Name = "student_menuStrip";
            this.student_menuStrip.Size = new System.Drawing.Size(178, 29);
            this.student_menuStrip.TabIndex = 11;
            this.student_menuStrip.Text = "menuStrip1";
            // 
            // aCTIONToolStripMenuItem
            // 
            this.aCTIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionEdit,
            this.actionDelete});
            this.aCTIONToolStripMenuItem.Name = "aCTIONToolStripMenuItem";
            this.aCTIONToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.aCTIONToolStripMenuItem.Text = "ACTION";
            // 
            // actionEdit
            // 
            this.actionEdit.Name = "actionEdit";
            this.actionEdit.Size = new System.Drawing.Size(152, 26);
            this.actionEdit.Text = "EDIT";
            this.actionEdit.Click += new System.EventHandler(this.actionEdit_Click);
            // 
            // actionDelete
            // 
            this.actionDelete.Name = "actionDelete";
            this.actionDelete.Size = new System.Drawing.Size(152, 26);
            this.actionDelete.Text = "DELETE";
            this.actionDelete.Click += new System.EventHandler(this.actionDelete_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.36771F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.63229F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.classCombo, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(931, 67);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(344, 46);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "SHOW BY CLASS";
            // 
            // classCombo
            // 
            this.classCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCombo.FormattingEnabled = true;
            this.classCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.classCombo.Location = new System.Drawing.Point(231, 3);
            this.classCombo.Name = "classCombo";
            this.classCombo.Size = new System.Drawing.Size(110, 33);
            this.classCombo.TabIndex = 6;
            this.classCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // DataGrid_All_Student
            // 
            this.DataGrid_All_Student.AutoGenerateColumns = false;
            this.DataGrid_All_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_All_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.DataGrid_All_Student.DataSource = this.studentBindingSource2;
            this.DataGrid_All_Student.Location = new System.Drawing.Point(85, 119);
            this.DataGrid_All_Student.Name = "DataGrid_All_Student";
            this.DataGrid_All_Student.Size = new System.Drawing.Size(1194, 577);
            this.DataGrid_All_Student.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "SL";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nameStd";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idStd";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "rollStd";
            this.dataGridViewTextBoxColumn4.HeaderText = "Roll";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "classStd";
            this.dataGridViewTextBoxColumn5.HeaderText = "Class";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dobStd";
            this.dataGridViewTextBoxColumn6.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "genderStd";
            this.dataGridViewTextBoxColumn7.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "bloodStd";
            this.dataGridViewTextBoxColumn8.HeaderText = "Blood";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "gardianStd";
            this.dataGridViewTextBoxColumn9.HeaderText = "Guardian";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "contactStd";
            this.dataGridViewTextBoxColumn10.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "addressStd";
            this.dataGridViewTextBoxColumn11.HeaderText = "Address";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "feeStd";
            this.dataGridViewTextBoxColumn12.HeaderText = "Fees";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "scholoshipStd";
            this.dataGridViewTextBoxColumn14.HeaderText = "Scholarship";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "feeAfterScholar";
            this.dataGridViewTextBoxColumn15.HeaderText = "Waiver";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "student";
            this.studentBindingSource2.DataSource = this.demoStudentDataSet1;
            // 
            // demoStudentDataSet1
            // 
            this.demoStudentDataSet1.DataSetName = "DemoStudentDataSet1";
            this.demoStudentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter2
            // 
            this.studentTableAdapter2.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(1173, 731);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Show_Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGrid_All_Student);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.student_menuStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_Student_Form";
            this.Text = "Show_Student_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Show_Student_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_Show_Student)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.student_menuStrip.ResumeLayout(false);
            this.student_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_All_Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Stu_Search;
       
        private System.Windows.Forms.BindingSource studentBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gardianStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scholoshipStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeAfterScholarDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip student_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aCTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionEdit;
        private System.Windows.Forms.ToolStripMenuItem actionDelete;
        private DemoStudentDataSet_Show_Student demoStudentDataSet_Show_Student;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private DemoStudentDataSet_Show_StudentTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox classCombo;
        private DemoStudentDataSet2TableAdapters.studentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.DataGridView DataGrid_All_Student;
        private DemoStudentDataSet1 demoStudentDataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private DemoStudentDataSet1TableAdapters.studentTableAdapter studentTableAdapter2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}