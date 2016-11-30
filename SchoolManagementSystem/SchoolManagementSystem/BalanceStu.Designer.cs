namespace SchoolManagementSystem
{
    partial class BalanceStu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceStu));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1_BALANCE = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gardianStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scholoshipStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeAfterScholarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoStudentDataSet_BalanceStu = new SchoolManagementSystem.DemoStudentDataSet_BalanceStu();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Schlr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_schlr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add_fees = new System.Windows.Forms.Button();
            this.tk = new System.Windows.Forms.Label();
            this.txt_fees = new System.Windows.Forms.TextBox();
            this.studentTableAdapter = new SchoolManagementSystem.DemoStudentDataSet_BalanceStuTableAdapters.studentTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_BALANCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_BalanceStu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(166, 29);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 25);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search";
            // 
            // dataGridView1_BALANCE
            // 
            this.dataGridView1_BALANCE.AutoGenerateColumns = false;
            this.dataGridView1_BALANCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_BALANCE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameStdDataGridViewTextBoxColumn,
            this.idStdDataGridViewTextBoxColumn,
            this.rollStdDataGridViewTextBoxColumn,
            this.classStdDataGridViewTextBoxColumn,
            this.dobStdDataGridViewTextBoxColumn,
            this.genderStdDataGridViewTextBoxColumn,
            this.bloodStdDataGridViewTextBoxColumn,
            this.gardianStdDataGridViewTextBoxColumn,
            this.contactStdDataGridViewTextBoxColumn,
            this.addressStdDataGridViewTextBoxColumn,
            this.feeStdDataGridViewTextBoxColumn,
            this.scholoshipStdDataGridViewTextBoxColumn,
            this.feeAfterScholarDataGridViewTextBoxColumn});
            this.dataGridView1_BALANCE.DataSource = this.studentBindingSource;
            this.dataGridView1_BALANCE.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1_BALANCE.Name = "dataGridView1_BALANCE";
            this.dataGridView1_BALANCE.Size = new System.Drawing.Size(731, 334);
            this.dataGridView1_BALANCE.TabIndex = 22;
            this.dataGridView1_BALANCE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_BALANCE_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameStdDataGridViewTextBoxColumn
            // 
            this.nameStdDataGridViewTextBoxColumn.DataPropertyName = "nameStd";
            this.nameStdDataGridViewTextBoxColumn.HeaderText = "nameStd";
            this.nameStdDataGridViewTextBoxColumn.Name = "nameStdDataGridViewTextBoxColumn";
            // 
            // idStdDataGridViewTextBoxColumn
            // 
            this.idStdDataGridViewTextBoxColumn.DataPropertyName = "idStd";
            this.idStdDataGridViewTextBoxColumn.HeaderText = "idStd";
            this.idStdDataGridViewTextBoxColumn.Name = "idStdDataGridViewTextBoxColumn";
            // 
            // rollStdDataGridViewTextBoxColumn
            // 
            this.rollStdDataGridViewTextBoxColumn.DataPropertyName = "rollStd";
            this.rollStdDataGridViewTextBoxColumn.HeaderText = "rollStd";
            this.rollStdDataGridViewTextBoxColumn.Name = "rollStdDataGridViewTextBoxColumn";
            // 
            // classStdDataGridViewTextBoxColumn
            // 
            this.classStdDataGridViewTextBoxColumn.DataPropertyName = "classStd";
            this.classStdDataGridViewTextBoxColumn.HeaderText = "classStd";
            this.classStdDataGridViewTextBoxColumn.Name = "classStdDataGridViewTextBoxColumn";
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
            // scholoshipStdDataGridViewTextBoxColumn
            // 
            this.scholoshipStdDataGridViewTextBoxColumn.DataPropertyName = "scholoshipStd";
            this.scholoshipStdDataGridViewTextBoxColumn.HeaderText = "scholoshipStd";
            this.scholoshipStdDataGridViewTextBoxColumn.Name = "scholoshipStdDataGridViewTextBoxColumn";
            // 
            // feeAfterScholarDataGridViewTextBoxColumn
            // 
            this.feeAfterScholarDataGridViewTextBoxColumn.DataPropertyName = "feeAfterScholar";
            this.feeAfterScholarDataGridViewTextBoxColumn.HeaderText = "feeAfterScholar";
            this.feeAfterScholarDataGridViewTextBoxColumn.Name = "feeAfterScholarDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.demoStudentDataSet_BalanceStu;
            // 
            // demoStudentDataSet_BalanceStu
            // 
            this.demoStudentDataSet_BalanceStu.DataSetName = "DemoStudentDataSet_BalanceStu";
            this.demoStudentDataSet_BalanceStu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Schlr);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_add_schlr);
            this.groupBox2.Location = new System.Drawing.Point(792, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 122);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SCHOLARSHIP";
            // 
            // txt_Schlr
            // 
            this.txt_Schlr.Location = new System.Drawing.Point(37, 41);
            this.txt_Schlr.Multiline = true;
            this.txt_Schlr.Name = "txt_Schlr";
            this.txt_Schlr.Size = new System.Drawing.Size(183, 23);
            this.txt_Schlr.TabIndex = 18;
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
            // btn_add_schlr
            // 
            this.btn_add_schlr.Location = new System.Drawing.Point(37, 75);
            this.btn_add_schlr.Name = "btn_add_schlr";
            this.btn_add_schlr.Size = new System.Drawing.Size(183, 23);
            this.btn_add_schlr.TabIndex = 16;
            this.btn_add_schlr.Text = "ADD SCHOLARSHIP ";
            this.btn_add_schlr.UseVisualStyleBackColor = true;
            this.btn_add_schlr.Click += new System.EventHandler(this.btn_add_schlr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add_fees);
            this.groupBox1.Controls.Add(this.tk);
            this.groupBox1.Controls.Add(this.txt_fees);
            this.groupBox1.Location = new System.Drawing.Point(792, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 131);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FEE";
            // 
            // btn_add_fees
            // 
            this.btn_add_fees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_fees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add_fees.Location = new System.Drawing.Point(37, 74);
            this.btn_add_fees.Name = "btn_add_fees";
            this.btn_add_fees.Size = new System.Drawing.Size(183, 23);
            this.btn_add_fees.TabIndex = 15;
            this.btn_add_fees.Text = "ADD FEES";
            this.btn_add_fees.UseVisualStyleBackColor = true;
            this.btn_add_fees.Click += new System.EventHandler(this.btn_add_fees_Click);
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
            // txt_fees
            // 
            this.txt_fees.Location = new System.Drawing.Point(37, 39);
            this.txt_fees.Multiline = true;
            this.txt_fees.Name = "txt_fees";
            this.txt_fees.Size = new System.Drawing.Size(183, 23);
            this.txt_fees.TabIndex = 17;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(1237, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 59;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BalanceStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1362, 740);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1_BALANCE);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BalanceStu";
            this.Text = "BalanceStu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BalanceStu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_BALANCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_BalanceStu)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1_BALANCE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Schlr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_schlr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add_fees;
        private System.Windows.Forms.Label tk;
        private System.Windows.Forms.TextBox txt_fees;
        private DemoStudentDataSet_BalanceStu demoStudentDataSet_BalanceStu;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DemoStudentDataSet_BalanceStuTableAdapters.studentTableAdapter studentTableAdapter;
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
        private System.Windows.Forms.Button button2;
    }
}