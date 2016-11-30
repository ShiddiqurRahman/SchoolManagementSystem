namespace SchoolManagementSystem
{
    partial class Salary_Teacher_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary_Teacher_Form));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1_T_Salary_Form = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoStudentDataSet1_Salary_Teacher_Form = new SchoolManagementSystem.DemoStudentDataSet1_Salary_Teacher_Form();
            this.teacherTableAdapter = new SchoolManagementSystem.DemoStudentDataSet1_Salary_Teacher_FormTableAdapters.teacherTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Bonus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_Bonus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add_salary = new System.Windows.Forms.Button();
            this.tk = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_T_Salary_Form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet1_Salary_Teacher_Form)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 37);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 25);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Search";
            // 
            // dataGridView1_T_Salary_Form
            // 
            this.dataGridView1_T_Salary_Form.AutoGenerateColumns = false;
            this.dataGridView1_T_Salary_Form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_T_Salary_Form.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.teachernameDataGridViewTextBoxColumn,
            this.teacheridDataGridViewTextBoxColumn,
            this.teacherposDataGridViewTextBoxColumn,
            this.teachersubDataGridViewTextBoxColumn,
            this.teachersalaryDataGridViewTextBoxColumn});
            this.dataGridView1_T_Salary_Form.DataSource = this.teacherBindingSource;
            this.dataGridView1_T_Salary_Form.Location = new System.Drawing.Point(27, 77);
            this.dataGridView1_T_Salary_Form.Name = "dataGridView1_T_Salary_Form";
            this.dataGridView1_T_Salary_Form.Size = new System.Drawing.Size(645, 384);
            this.dataGridView1_T_Salary_Form.TabIndex = 24;
            this.dataGridView1_T_Salary_Form.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_T_Salary_Form_CellContentClick);
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
            this.teachernameDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.teachernameDataGridViewTextBoxColumn.Name = "teachernameDataGridViewTextBoxColumn";
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "ID";
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            // 
            // teacherposDataGridViewTextBoxColumn
            // 
            this.teacherposDataGridViewTextBoxColumn.DataPropertyName = "teacher_pos";
            this.teacherposDataGridViewTextBoxColumn.HeaderText = "POSITION";
            this.teacherposDataGridViewTextBoxColumn.Name = "teacherposDataGridViewTextBoxColumn";
            // 
            // teachersubDataGridViewTextBoxColumn
            // 
            this.teachersubDataGridViewTextBoxColumn.DataPropertyName = "teacher_sub";
            this.teachersubDataGridViewTextBoxColumn.HeaderText = "SUBJECT";
            this.teachersubDataGridViewTextBoxColumn.Name = "teachersubDataGridViewTextBoxColumn";
            // 
            // teachersalaryDataGridViewTextBoxColumn
            // 
            this.teachersalaryDataGridViewTextBoxColumn.DataPropertyName = "teacher_salary";
            this.teachersalaryDataGridViewTextBoxColumn.HeaderText = "SALARY";
            this.teachersalaryDataGridViewTextBoxColumn.Name = "teachersalaryDataGridViewTextBoxColumn";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.demoStudentDataSet1_Salary_Teacher_Form;
            // 
            // demoStudentDataSet1_Salary_Teacher_Form
            // 
            this.demoStudentDataSet1_Salary_Teacher_Form.DataSetName = "DemoStudentDataSet1_Salary_Teacher_Form";
            this.demoStudentDataSet1_Salary_Teacher_Form.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Bonus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_add_Bonus);
            this.groupBox2.Location = new System.Drawing.Point(762, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 122);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BONUS";
            // 
            // txt_Bonus
            // 
            this.txt_Bonus.Location = new System.Drawing.Point(37, 41);
            this.txt_Bonus.Multiline = true;
            this.txt_Bonus.Name = "txt_Bonus";
            this.txt_Bonus.Size = new System.Drawing.Size(183, 23);
            this.txt_Bonus.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(226, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "%";
            // 
            // btn_add_Bonus
            // 
            this.btn_add_Bonus.Location = new System.Drawing.Point(37, 75);
            this.btn_add_Bonus.Name = "btn_add_Bonus";
            this.btn_add_Bonus.Size = new System.Drawing.Size(183, 23);
            this.btn_add_Bonus.TabIndex = 16;
            this.btn_add_Bonus.Text = "ADD BONUS ";
            this.btn_add_Bonus.UseVisualStyleBackColor = true;
            this.btn_add_Bonus.Click += new System.EventHandler(this.btn_add_Bonus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add_salary);
            this.groupBox1.Controls.Add(this.tk);
            this.groupBox1.Controls.Add(this.txt_salary);
            this.groupBox1.Location = new System.Drawing.Point(762, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 131);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SALARY";
            // 
            // btn_add_salary
            // 
            this.btn_add_salary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_salary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add_salary.Location = new System.Drawing.Point(37, 74);
            this.btn_add_salary.Name = "btn_add_salary";
            this.btn_add_salary.Size = new System.Drawing.Size(183, 23);
            this.btn_add_salary.TabIndex = 15;
            this.btn_add_salary.Text = "ADD SALARY";
            this.btn_add_salary.UseVisualStyleBackColor = true;
            this.btn_add_salary.Click += new System.EventHandler(this.btn_add_salary_Click);
            // 
            // tk
            // 
            this.tk.AutoSize = true;
            this.tk.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tk.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tk.Location = new System.Drawing.Point(226, 36);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(38, 21);
            this.tk.TabIndex = 19;
            this.tk.Text = "TK";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(37, 39);
            this.txt_salary.Multiline = true;
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(183, 23);
            this.txt_salary.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(1213, 654);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 58;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Salary_Teacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1346, 701);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1_T_Salary_Form);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary_Teacher_Form";
            this.Text = "Salary_Teacher_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Salary_Teacher_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_T_Salary_Form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet1_Salary_Teacher_Form)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1_T_Salary_Form;
        private DemoStudentDataSet1_Salary_Teacher_Form demoStudentDataSet1_Salary_Teacher_Form;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private DemoStudentDataSet1_Salary_Teacher_FormTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherposDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teachersalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Bonus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_Bonus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add_salary;
        private System.Windows.Forms.Label tk;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Button button2;
    }
}