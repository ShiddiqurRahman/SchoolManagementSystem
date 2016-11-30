namespace SchoolManagementSystem
{
    partial class Show_Teacher_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Teacher_Form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.teacher_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher_menuStrip = new System.Windows.Forms.MenuStrip();
            this.aCTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.actionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridView_All_Teacher = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachergenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherbloodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachercontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacheraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoStudentDataSet_Show_Teacher = new SchoolManagementSystem.DemoStudentDataSet_Show_Teacher();
            this.teacherTableAdapter = new SchoolManagementSystem.DemoStudentDataSet_Show_TeacherTableAdapters.teacherTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.teacher_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_All_Teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_Show_Teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.71951F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.28049F));
            this.tableLayoutPanel1.Controls.Add(this.teacher_Search, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(58, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 34);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // teacher_Search
            // 
            this.teacher_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_Search.Location = new System.Drawing.Point(129, 3);
            this.teacher_Search.Name = "teacher_Search";
            this.teacher_Search.Size = new System.Drawing.Size(187, 31);
            this.teacher_Search.TabIndex = 6;
            this.teacher_Search.TextChanged += new System.EventHandler(this.teacher_Search_TextChanged);
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
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "SEARCH";
            // 
            // teacher_menuStrip
            // 
            this.teacher_menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.teacher_menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCTIONToolStripMenuItem});
            this.teacher_menuStrip.Location = new System.Drawing.Point(412, 65);
            this.teacher_menuStrip.Name = "teacher_menuStrip";
            this.teacher_menuStrip.Size = new System.Drawing.Size(86, 29);
            this.teacher_menuStrip.TabIndex = 12;
            this.teacher_menuStrip.Text = "menuStrip1";
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
            this.actionEdit.Size = new System.Drawing.Size(131, 26);
            this.actionEdit.Text = "EDIT";
            this.actionEdit.Click += new System.EventHandler(this.actionEdit_Click);
            // 
            // actionDelete
            // 
            this.actionDelete.Name = "actionDelete";
            this.actionDelete.Size = new System.Drawing.Size(131, 26);
            this.actionDelete.Text = "DELETE";
            this.actionDelete.Click += new System.EventHandler(this.actionDelete_Click);
            // 
            // DataGridView_All_Teacher
            // 
            this.DataGridView_All_Teacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_All_Teacher.AutoGenerateColumns = false;
            this.DataGridView_All_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_All_Teacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.teachernameDataGridViewTextBoxColumn,
            this.teacheridDataGridViewTextBoxColumn,
            this.teacherpassDataGridViewTextBoxColumn,
            this.teacherposDataGridViewTextBoxColumn,
            this.teachersubDataGridViewTextBoxColumn,
            this.teacherdobDataGridViewTextBoxColumn,
            this.teachergenderDataGridViewTextBoxColumn,
            this.teacherbloodDataGridViewTextBoxColumn,
            this.teachersalaryDataGridViewTextBoxColumn,
            this.teachercontactDataGridViewTextBoxColumn,
            this.teacheraddressDataGridViewTextBoxColumn});
            this.DataGridView_All_Teacher.DataSource = this.teacherBindingSource;
            this.DataGridView_All_Teacher.Location = new System.Drawing.Point(58, 114);
            this.DataGridView_All_Teacher.Name = "DataGridView_All_Teacher";
            this.DataGridView_All_Teacher.Size = new System.Drawing.Size(1246, 570);
            this.DataGridView_All_Teacher.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "SL";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teachernameDataGridViewTextBoxColumn
            // 
            this.teachernameDataGridViewTextBoxColumn.DataPropertyName = "teacher_name";
            this.teachernameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.teachernameDataGridViewTextBoxColumn.Name = "teachernameDataGridViewTextBoxColumn";
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "ID";
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            // 
            // teacherpassDataGridViewTextBoxColumn
            // 
            this.teacherpassDataGridViewTextBoxColumn.DataPropertyName = "teacher_pass";
            this.teacherpassDataGridViewTextBoxColumn.HeaderText = "Password";
            this.teacherpassDataGridViewTextBoxColumn.Name = "teacherpassDataGridViewTextBoxColumn";
            // 
            // teacherposDataGridViewTextBoxColumn
            // 
            this.teacherposDataGridViewTextBoxColumn.DataPropertyName = "teacher_pos";
            this.teacherposDataGridViewTextBoxColumn.HeaderText = "Position";
            this.teacherposDataGridViewTextBoxColumn.Name = "teacherposDataGridViewTextBoxColumn";
            // 
            // teachersubDataGridViewTextBoxColumn
            // 
            this.teachersubDataGridViewTextBoxColumn.DataPropertyName = "teacher_sub";
            this.teachersubDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.teachersubDataGridViewTextBoxColumn.Name = "teachersubDataGridViewTextBoxColumn";
            // 
            // teacherdobDataGridViewTextBoxColumn
            // 
            this.teacherdobDataGridViewTextBoxColumn.DataPropertyName = "teacher_dob";
            this.teacherdobDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.teacherdobDataGridViewTextBoxColumn.Name = "teacherdobDataGridViewTextBoxColumn";
            // 
            // teachergenderDataGridViewTextBoxColumn
            // 
            this.teachergenderDataGridViewTextBoxColumn.DataPropertyName = "teacher_gender";
            this.teachergenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.teachergenderDataGridViewTextBoxColumn.Name = "teachergenderDataGridViewTextBoxColumn";
            // 
            // teacherbloodDataGridViewTextBoxColumn
            // 
            this.teacherbloodDataGridViewTextBoxColumn.DataPropertyName = "teacher_blood";
            this.teacherbloodDataGridViewTextBoxColumn.HeaderText = "Blood";
            this.teacherbloodDataGridViewTextBoxColumn.Name = "teacherbloodDataGridViewTextBoxColumn";
            // 
            // teachersalaryDataGridViewTextBoxColumn
            // 
            this.teachersalaryDataGridViewTextBoxColumn.DataPropertyName = "teacher_salary";
            this.teachersalaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.teachersalaryDataGridViewTextBoxColumn.Name = "teachersalaryDataGridViewTextBoxColumn";
            // 
            // teachercontactDataGridViewTextBoxColumn
            // 
            this.teachercontactDataGridViewTextBoxColumn.DataPropertyName = "teacher_contact";
            this.teachercontactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.teachercontactDataGridViewTextBoxColumn.Name = "teachercontactDataGridViewTextBoxColumn";
            // 
            // teacheraddressDataGridViewTextBoxColumn
            // 
            this.teacheraddressDataGridViewTextBoxColumn.DataPropertyName = "teacher_address";
            this.teacheraddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.teacheraddressDataGridViewTextBoxColumn.Name = "teacheraddressDataGridViewTextBoxColumn";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.demoStudentDataSet_Show_Teacher;
            // 
            // demoStudentDataSet_Show_Teacher
            // 
            this.demoStudentDataSet_Show_Teacher.DataSetName = "DemoStudentDataSet_Show_Teacher";
            this.demoStudentDataSet_Show_Teacher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(584, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "ALL TEACHER";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(1256, 731);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Show_Teacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridView_All_Teacher);
            this.Controls.Add(this.teacher_menuStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_Teacher_Form";
            this.Text = "Show_Teacher_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Show_Teacher_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.teacher_menuStrip.ResumeLayout(false);
            this.teacher_menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_All_Teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_Show_Teacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teacher_Search;
        private System.Windows.Forms.MenuStrip teacher_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aCTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionEdit;
        private System.Windows.Forms.ToolStripMenuItem actionDelete;
        private System.Windows.Forms.DataGridView DataGridView_All_Teacher;
        private DemoStudentDataSet_Show_Teacher demoStudentDataSet_Show_Teacher;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private DemoStudentDataSet_Show_TeacherTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherposDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachergenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherbloodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachercontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheraddressDataGridViewTextBoxColumn;
    }
}