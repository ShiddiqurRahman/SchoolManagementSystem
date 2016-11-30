namespace SchoolManagementSystem
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.dataGridViewLogin = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logintypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoStudentDataSet_Login = new SchoolManagementSystem.DemoStudentDataSet_Login();
            this.loginTableAdapter = new SchoolManagementSystem.DemoStudentDataSet_LoginTableAdapters.loginTableAdapter();
            this.dataGridView_t_login = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.demoStudentDataSet_Teacher = new SchoolManagementSystem.DemoStudentDataSet_Teacher();
            this.teacherTableAdapter = new SchoolManagementSystem.DemoStudentDataSet_TeacherTableAdapters.teacherTableAdapter();
            this.Key = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_t_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_Teacher)).BeginInit();
            this.Key.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID :";
            // 
            // btnlogin
            // 
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(290, 155);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(111, 29);
            this.btnlogin.TabIndex = 22;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(193, 107);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(208, 31);
            this.txt_pass.TabIndex = 20;
            // 
            // txt_userid
            // 
            this.txt_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userid.Location = new System.Drawing.Point(193, 58);
            this.txt_userid.MaxLength = 10;
            this.txt_userid.Multiline = true;
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(208, 31);
            this.txt_userid.TabIndex = 21;
            this.txt_userid.TextChanged += new System.EventHandler(this.txt_userid_TextChanged);
            // 
            // dataGridViewLogin
            // 
            this.dataGridViewLogin.AutoGenerateColumns = false;
            this.dataGridViewLogin.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dataGridViewLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginidDataGridViewTextBoxColumn,
            this.loginpassDataGridViewTextBoxColumn,
            this.logintypeDataGridViewTextBoxColumn});
            this.dataGridViewLogin.DataSource = this.loginBindingSource;
            this.dataGridViewLogin.Location = new System.Drawing.Point(42, 85);
            this.dataGridViewLogin.Name = "dataGridViewLogin";
            this.dataGridViewLogin.Size = new System.Drawing.Size(433, 198);
            this.dataGridViewLogin.TabIndex = 25;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginidDataGridViewTextBoxColumn
            // 
            this.loginidDataGridViewTextBoxColumn.DataPropertyName = "login_id";
            this.loginidDataGridViewTextBoxColumn.HeaderText = "login_id";
            this.loginidDataGridViewTextBoxColumn.Name = "loginidDataGridViewTextBoxColumn";
            // 
            // loginpassDataGridViewTextBoxColumn
            // 
            this.loginpassDataGridViewTextBoxColumn.DataPropertyName = "login_pass";
            this.loginpassDataGridViewTextBoxColumn.HeaderText = "login_pass";
            this.loginpassDataGridViewTextBoxColumn.Name = "loginpassDataGridViewTextBoxColumn";
            // 
            // logintypeDataGridViewTextBoxColumn
            // 
            this.logintypeDataGridViewTextBoxColumn.DataPropertyName = "login_type";
            this.logintypeDataGridViewTextBoxColumn.HeaderText = "login_type";
            this.logintypeDataGridViewTextBoxColumn.Name = "logintypeDataGridViewTextBoxColumn";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.demoStudentDataSet_Login;
            // 
            // demoStudentDataSet_Login
            // 
            this.demoStudentDataSet_Login.DataSetName = "DemoStudentDataSet_Login";
            this.demoStudentDataSet_Login.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_t_login
            // 
            this.dataGridView_t_login.AutoGenerateColumns = false;
            this.dataGridView_t_login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_t_login.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
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
            this.dataGridView_t_login.DataSource = this.teacherBindingSource;
            this.dataGridView_t_login.Location = new System.Drawing.Point(33, 289);
            this.dataGridView_t_login.Name = "dataGridView_t_login";
            this.dataGridView_t_login.Size = new System.Drawing.Size(510, 168);
            this.dataGridView_t_login.TabIndex = 26;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // teachernameDataGridViewTextBoxColumn
            // 
            this.teachernameDataGridViewTextBoxColumn.DataPropertyName = "teacher_name";
            this.teachernameDataGridViewTextBoxColumn.HeaderText = "teacher_name";
            this.teachernameDataGridViewTextBoxColumn.Name = "teachernameDataGridViewTextBoxColumn";
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            // 
            // teacherpassDataGridViewTextBoxColumn
            // 
            this.teacherpassDataGridViewTextBoxColumn.DataPropertyName = "teacher_pass";
            this.teacherpassDataGridViewTextBoxColumn.HeaderText = "teacher_pass";
            this.teacherpassDataGridViewTextBoxColumn.Name = "teacherpassDataGridViewTextBoxColumn";
            // 
            // teacherposDataGridViewTextBoxColumn
            // 
            this.teacherposDataGridViewTextBoxColumn.DataPropertyName = "teacher_pos";
            this.teacherposDataGridViewTextBoxColumn.HeaderText = "teacher_pos";
            this.teacherposDataGridViewTextBoxColumn.Name = "teacherposDataGridViewTextBoxColumn";
            // 
            // teachersubDataGridViewTextBoxColumn
            // 
            this.teachersubDataGridViewTextBoxColumn.DataPropertyName = "teacher_sub";
            this.teachersubDataGridViewTextBoxColumn.HeaderText = "teacher_sub";
            this.teachersubDataGridViewTextBoxColumn.Name = "teachersubDataGridViewTextBoxColumn";
            // 
            // teacherdobDataGridViewTextBoxColumn
            // 
            this.teacherdobDataGridViewTextBoxColumn.DataPropertyName = "teacher_dob";
            this.teacherdobDataGridViewTextBoxColumn.HeaderText = "teacher_dob";
            this.teacherdobDataGridViewTextBoxColumn.Name = "teacherdobDataGridViewTextBoxColumn";
            // 
            // teachergenderDataGridViewTextBoxColumn
            // 
            this.teachergenderDataGridViewTextBoxColumn.DataPropertyName = "teacher_gender";
            this.teachergenderDataGridViewTextBoxColumn.HeaderText = "teacher_gender";
            this.teachergenderDataGridViewTextBoxColumn.Name = "teachergenderDataGridViewTextBoxColumn";
            // 
            // teacherbloodDataGridViewTextBoxColumn
            // 
            this.teacherbloodDataGridViewTextBoxColumn.DataPropertyName = "teacher_blood";
            this.teacherbloodDataGridViewTextBoxColumn.HeaderText = "teacher_blood";
            this.teacherbloodDataGridViewTextBoxColumn.Name = "teacherbloodDataGridViewTextBoxColumn";
            // 
            // teachersalaryDataGridViewTextBoxColumn
            // 
            this.teachersalaryDataGridViewTextBoxColumn.DataPropertyName = "teacher_salary";
            this.teachersalaryDataGridViewTextBoxColumn.HeaderText = "teacher_salary";
            this.teachersalaryDataGridViewTextBoxColumn.Name = "teachersalaryDataGridViewTextBoxColumn";
            // 
            // teachercontactDataGridViewTextBoxColumn
            // 
            this.teachercontactDataGridViewTextBoxColumn.DataPropertyName = "teacher_contact";
            this.teachercontactDataGridViewTextBoxColumn.HeaderText = "teacher_contact";
            this.teachercontactDataGridViewTextBoxColumn.Name = "teachercontactDataGridViewTextBoxColumn";
            // 
            // teacheraddressDataGridViewTextBoxColumn
            // 
            this.teacheraddressDataGridViewTextBoxColumn.DataPropertyName = "teacher_address";
            this.teacheraddressDataGridViewTextBoxColumn.HeaderText = "teacher_address";
            this.teacheraddressDataGridViewTextBoxColumn.Name = "teacheraddressDataGridViewTextBoxColumn";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.demoStudentDataSet_Teacher;
            // 
            // demoStudentDataSet_Teacher
            // 
            this.demoStudentDataSet_Teacher.DataSetName = "DemoStudentDataSet_Teacher";
            this.demoStudentDataSet_Teacher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // Key
            // 
            this.Key.BackColor = System.Drawing.Color.Transparent;
            this.Key.Controls.Add(this.txt_pass);
            this.Key.Controls.Add(this.txt_userid);
            this.Key.Controls.Add(this.btnlogin);
            this.Key.Controls.Add(this.label3);
            this.Key.Controls.Add(this.label1);
            this.Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Key.ForeColor = System.Drawing.Color.White;
            this.Key.Location = new System.Drawing.Point(910, 12);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(432, 224);
            this.Key.TabIndex = 27;
            this.Key.TabStop = false;
            this.Key.Text = "Key";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1213, 682);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 50);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.dataGridView_t_login);
            this.Controls.Add(this.dataGridViewLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_t_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_Teacher)).EndInit();
            this.Key.ResumeLayout(false);
            this.Key.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.DataGridView dataGridViewLogin;
        private DemoStudentDataSet_Login demoStudentDataSet_Login;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private DemoStudentDataSet_LoginTableAdapters.loginTableAdapter loginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logintypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_t_login;
        private DemoStudentDataSet_Teacher demoStudentDataSet_Teacher;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private DemoStudentDataSet_TeacherTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
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
        private System.Windows.Forms.GroupBox Key;
        private System.Windows.Forms.Button button2;
    }
}

