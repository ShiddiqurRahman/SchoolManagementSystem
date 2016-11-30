namespace SchoolManagementSystem
{
    partial class Show_Accountant_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Accountant_Form));
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Acc_Search = new System.Windows.Forms.TextBox();
            this.menuStrip_Acc = new System.Windows.Forms.MenuStrip();
            this.aCTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.actionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGrid_All_Acc = new System.Windows.Forms.DataGridView();
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
            this.accountantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.demoStudentDataSet_Show_Accountant = new SchoolManagementSystem.DemoStudentDataSet_Show_Accountant();
            this.accountantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountantTableAdapter = new SchoolManagementSystem.DemoStudentDataSet_Show_AccountantTableAdapters.accountantTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip_Acc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_All_Acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_Show_Accountant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(541, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "ALL ACCOUNTANT ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.71951F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.28049F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Acc_Search, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(99, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 34);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Acc_Search
            // 
            this.Acc_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc_Search.Location = new System.Drawing.Point(129, 3);
            this.Acc_Search.Name = "Acc_Search";
            this.Acc_Search.Size = new System.Drawing.Size(187, 31);
            this.Acc_Search.TabIndex = 6;
            this.Acc_Search.TextChanged += new System.EventHandler(this.Acc_Search_TextChanged);
            // 
            // menuStrip_Acc
            // 
            this.menuStrip_Acc.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_Acc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip_Acc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCTIONToolStripMenuItem});
            this.menuStrip_Acc.Location = new System.Drawing.Point(437, 67);
            this.menuStrip_Acc.Name = "menuStrip_Acc";
            this.menuStrip_Acc.Size = new System.Drawing.Size(86, 29);
            this.menuStrip_Acc.TabIndex = 15;
            this.menuStrip_Acc.Text = "menuStrip1";
            this.menuStrip_Acc.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_Acc_ItemClicked);
            // 
            // aCTIONToolStripMenuItem
            // 
            this.aCTIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionEdit,
            this.actionDelete});
            this.aCTIONToolStripMenuItem.Name = "aCTIONToolStripMenuItem";
            this.aCTIONToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.aCTIONToolStripMenuItem.Text = "ACTION";
            this.aCTIONToolStripMenuItem.Click += new System.EventHandler(this.aCTIONToolStripMenuItem_Click);
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
            // DataGrid_All_Acc
            // 
            this.DataGrid_All_Acc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_All_Acc.AutoGenerateColumns = false;
            this.DataGrid_All_Acc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_All_Acc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn11});
            this.DataGrid_All_Acc.DataSource = this.accountantBindingSource1;
            this.DataGrid_All_Acc.Location = new System.Drawing.Point(99, 109);
            this.DataGrid_All_Acc.Name = "DataGrid_All_Acc";
            this.DataGrid_All_Acc.Size = new System.Drawing.Size(1150, 570);
            this.DataGrid_All_Acc.TabIndex = 16;
            this.DataGrid_All_Acc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_All_Acc_CellContentClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "aName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "aId";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "aPass";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pass";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "aPosition";
            this.dataGridViewTextBoxColumn5.HeaderText = "Position";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "aDob";
            this.dataGridViewTextBoxColumn6.HeaderText = "Dob";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "aGender";
            this.dataGridViewTextBoxColumn7.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "aBlood";
            this.dataGridViewTextBoxColumn8.HeaderText = "Blood";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "aSalary";
            this.dataGridViewTextBoxColumn9.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "aContact";
            this.dataGridViewTextBoxColumn10.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "aAddress";
            this.dataGridViewTextBoxColumn11.HeaderText = "Address";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // accountantBindingSource1
            // 
            this.accountantBindingSource1.DataMember = "accountant";
            this.accountantBindingSource1.DataSource = this.demoStudentDataSet_Show_Accountant;
            this.accountantBindingSource1.CurrentChanged += new System.EventHandler(this.accountantBindingSource1_CurrentChanged);
            // 
            // demoStudentDataSet_Show_Accountant
            // 
            this.demoStudentDataSet_Show_Accountant.DataSetName = "DemoStudentDataSet_Show_Accountant";
            this.demoStudentDataSet_Show_Accountant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountantBindingSource
            // 
            this.accountantBindingSource.DataMember = "accountant";
            this.accountantBindingSource.CurrentChanged += new System.EventHandler(this.accountantBindingSource_CurrentChanged);
            // 
            // accountantTableAdapter
            // 
            this.accountantTableAdapter.ClearBeforeFill = true;
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
            // Show_Accountant_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGrid_All_Acc);
            this.Controls.Add(this.menuStrip_Acc);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_Accountant_Form";
            this.Text = "Show_Accountant_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Show_Accountant_Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip_Acc.ResumeLayout(false);
            this.menuStrip_Acc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_All_Acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_Show_Accountant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Acc_Search;
        private System.Windows.Forms.MenuStrip menuStrip_Acc;
        private System.Windows.Forms.ToolStripMenuItem aCTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionEdit;
        private System.Windows.Forms.ToolStripMenuItem actionDelete;
        private System.Windows.Forms.DataGridView DataGrid_All_Acc;
        
        private System.Windows.Forms.BindingSource accountantBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aBloodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aAddressDataGridViewTextBoxColumn;
        private DemoStudentDataSet_Show_Accountant demoStudentDataSet_Show_Accountant;
        private System.Windows.Forms.BindingSource accountantBindingSource1;
        private DemoStudentDataSet_Show_AccountantTableAdapters.accountantTableAdapter accountantTableAdapter;
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
    }
}