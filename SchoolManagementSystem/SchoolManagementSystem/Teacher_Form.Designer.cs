namespace SchoolManagementSystem
{
    partial class Teacher_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.dataGridMarks = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMrollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stumclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMbanglaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMenglishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMmathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMgnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMgpaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.demoStudentDataSet_Marks = new SchoolManagementSystem.DemoStudentDataSet_Marks();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMarks = new System.Windows.Forms.Button();
            this.txt_gn = new System.Windows.Forms.TextBox();
            this.txt_math = new System.Windows.Forms.TextBox();
            this.txt_english = new System.Windows.Forms.TextBox();
            this.txt_src = new System.Windows.Forms.TextBox();
            this.txt_bangla = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.marksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stuMarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marksTableAdapter = new SchoolManagementSystem.DemoStudentDataSet_MarksTableAdapters.marksTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_Marks)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuMarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_type.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_type.Location = new System.Drawing.Point(153, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(81, 29);
            this.lbl_type.TabIndex = 5;
            this.lbl_type.Text = "TYPE";
            this.lbl_type.Click += new System.EventHandler(this.lbl_type_Click);
            // 
            // dataGridMarks
            // 
            this.dataGridMarks.AutoGenerateColumns = false;
            this.dataGridMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stuMidDataGridViewTextBoxColumn,
            this.stuMrollDataGridViewTextBoxColumn,
            this.stumclassDataGridViewTextBoxColumn,
            this.stuMbanglaDataGridViewTextBoxColumn,
            this.stuMenglishDataGridViewTextBoxColumn,
            this.stuMmathDataGridViewTextBoxColumn,
            this.stuMgnDataGridViewTextBoxColumn,
            this.stuMgpaDataGridViewTextBoxColumn});
            this.dataGridMarks.DataSource = this.marksBindingSource1;
            this.dataGridMarks.Location = new System.Drawing.Point(389, 134);
            this.dataGridMarks.Name = "dataGridMarks";
            this.dataGridMarks.Size = new System.Drawing.Size(940, 466);
            this.dataGridMarks.TabIndex = 53;
            this.dataGridMarks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMarks_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "SL";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuMidDataGridViewTextBoxColumn
            // 
            this.stuMidDataGridViewTextBoxColumn.DataPropertyName = "stuM_id";
            this.stuMidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.stuMidDataGridViewTextBoxColumn.Name = "stuMidDataGridViewTextBoxColumn";
            // 
            // stuMrollDataGridViewTextBoxColumn
            // 
            this.stuMrollDataGridViewTextBoxColumn.DataPropertyName = "stuM_roll";
            this.stuMrollDataGridViewTextBoxColumn.HeaderText = "ROLL";
            this.stuMrollDataGridViewTextBoxColumn.Name = "stuMrollDataGridViewTextBoxColumn";
            // 
            // stumclassDataGridViewTextBoxColumn
            // 
            this.stumclassDataGridViewTextBoxColumn.DataPropertyName = "stum_class";
            this.stumclassDataGridViewTextBoxColumn.HeaderText = "CLASS";
            this.stumclassDataGridViewTextBoxColumn.Name = "stumclassDataGridViewTextBoxColumn";
            // 
            // stuMbanglaDataGridViewTextBoxColumn
            // 
            this.stuMbanglaDataGridViewTextBoxColumn.DataPropertyName = "stuM_bangla";
            this.stuMbanglaDataGridViewTextBoxColumn.HeaderText = "BANGLA";
            this.stuMbanglaDataGridViewTextBoxColumn.Name = "stuMbanglaDataGridViewTextBoxColumn";
            // 
            // stuMenglishDataGridViewTextBoxColumn
            // 
            this.stuMenglishDataGridViewTextBoxColumn.DataPropertyName = "stuM_english";
            this.stuMenglishDataGridViewTextBoxColumn.HeaderText = "ENGLISH";
            this.stuMenglishDataGridViewTextBoxColumn.Name = "stuMenglishDataGridViewTextBoxColumn";
            // 
            // stuMmathDataGridViewTextBoxColumn
            // 
            this.stuMmathDataGridViewTextBoxColumn.DataPropertyName = "stuM_math";
            this.stuMmathDataGridViewTextBoxColumn.HeaderText = "MATH";
            this.stuMmathDataGridViewTextBoxColumn.Name = "stuMmathDataGridViewTextBoxColumn";
            // 
            // stuMgnDataGridViewTextBoxColumn
            // 
            this.stuMgnDataGridViewTextBoxColumn.DataPropertyName = "stuM_gn";
            this.stuMgnDataGridViewTextBoxColumn.HeaderText = "GENERAL KNOWLEDGE";
            this.stuMgnDataGridViewTextBoxColumn.Name = "stuMgnDataGridViewTextBoxColumn";
            // 
            // stuMgpaDataGridViewTextBoxColumn
            // 
            this.stuMgpaDataGridViewTextBoxColumn.DataPropertyName = "stuM_gpa";
            this.stuMgpaDataGridViewTextBoxColumn.HeaderText = "GPA";
            this.stuMgpaDataGridViewTextBoxColumn.Name = "stuMgpaDataGridViewTextBoxColumn";
            // 
            // marksBindingSource1
            // 
            this.marksBindingSource1.DataMember = "marks";
            this.marksBindingSource1.DataSource = this.demoStudentDataSet_Marks;
            this.marksBindingSource1.CurrentChanged += new System.EventHandler(this.marksBindingSource1_CurrentChanged);
            // 
            // demoStudentDataSet_Marks
            // 
            this.demoStudentDataSet_Marks.DataSetName = "DemoStudentDataSet_Marks";
            this.demoStudentDataSet_Marks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject.Location = new System.Drawing.Point(1235, 87);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(94, 24);
            this.lbl_subject.TabIndex = 52;
            this.lbl_subject.Text = "SUBJECT";
            this.lbl_subject.Click += new System.EventHandler(this.lbl_subject_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "GN KNOWLEDGE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "SEARCH";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "BANGALI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "ENGLISH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAddMarks
            // 
            this.btnAddMarks.Location = new System.Drawing.Point(255, 451);
            this.btnAddMarks.Name = "btnAddMarks";
            this.btnAddMarks.Size = new System.Drawing.Size(73, 29);
            this.btnAddMarks.TabIndex = 50;
            this.btnAddMarks.Text = "Update";
            this.btnAddMarks.UseVisualStyleBackColor = true;
            this.btnAddMarks.Click += new System.EventHandler(this.btnAddMarks_Click);
            // 
            // txt_gn
            // 
            this.txt_gn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gn.Location = new System.Drawing.Point(197, 407);
            this.txt_gn.Name = "txt_gn";
            this.txt_gn.Size = new System.Drawing.Size(137, 26);
            this.txt_gn.TabIndex = 45;
            this.txt_gn.TextChanged += new System.EventHandler(this.txt_gn_TextChanged);
            // 
            // txt_math
            // 
            this.txt_math.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_math.Location = new System.Drawing.Point(197, 349);
            this.txt_math.Name = "txt_math";
            this.txt_math.Size = new System.Drawing.Size(137, 26);
            this.txt_math.TabIndex = 46;
            this.txt_math.TextChanged += new System.EventHandler(this.txt_math_TextChanged);
            // 
            // txt_english
            // 
            this.txt_english.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_english.Location = new System.Drawing.Point(197, 296);
            this.txt_english.Name = "txt_english";
            this.txt_english.Size = new System.Drawing.Size(137, 26);
            this.txt_english.TabIndex = 47;
            this.txt_english.TextChanged += new System.EventHandler(this.txt_english_TextChanged);
            // 
            // txt_src
            // 
            this.txt_src.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_src.Location = new System.Drawing.Point(197, 139);
            this.txt_src.Name = "txt_src";
            this.txt_src.Size = new System.Drawing.Size(137, 26);
            this.txt_src.TabIndex = 48;
            this.txt_src.TextChanged += new System.EventHandler(this.txt_src_TextChanged);
            // 
            // txt_bangla
            // 
            this.txt_bangla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bangla.Location = new System.Drawing.Point(197, 241);
            this.txt_bangla.Name = "txt_bangla";
            this.txt_bangla.Size = new System.Drawing.Size(137, 26);
            this.txt_bangla.TabIndex = 49;
            this.txt_bangla.TextChanged += new System.EventHandler(this.txt_bangla_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.41573F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.58427F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_type, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(688, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 39);
            this.tableLayoutPanel1.TabIndex = 51;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "MATHEMATICS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SlateGray;
            this.label7.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(492, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(430, 39);
            this.label7.TabIndex = 54;
            this.label7.Text = "SCHOOL MANAGEMENT SYSTEM";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1364, 50);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // marksBindingSource2
            // 
            this.marksBindingSource2.DataMember = "marks";
            this.marksBindingSource2.CurrentChanged += new System.EventHandler(this.marksBindingSource2_CurrentChanged);
            // 
            // stuMarksBindingSource
            // 
            this.stuMarksBindingSource.DataMember = "stuMarks";
            this.stuMarksBindingSource.CurrentChanged += new System.EventHandler(this.stuMarksBindingSource_CurrentChanged);
            // 
            // marksBindingSource
            // 
            this.marksBindingSource.DataMember = "marks";
            this.marksBindingSource.CurrentChanged += new System.EventHandler(this.marksBindingSource_CurrentChanged);
            // 
            // marksTableAdapter
            // 
            this.marksTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 29);
            this.label8.TabIndex = 56;
            this.label8.Text = "Add Grade :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(1227, 682);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 57;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Teacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridMarks);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddMarks);
            this.Controls.Add(this.txt_gn);
            this.Controls.Add(this.txt_math);
            this.Controls.Add(this.txt_english);
            this.Controls.Add(this.txt_src);
            this.Controls.Add(this.txt_bangla);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacher_Form";
            this.Text = "Teacher_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Teacher_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoStudentDataSet_Marks)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuMarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource stuMarksBindingSource;
        private System.Windows.Forms.BindingSource marksBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource marksBindingSource;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.DataGridView dataGridMarks;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMarks;
        private System.Windows.Forms.TextBox txt_gn;
        private System.Windows.Forms.TextBox txt_math;
        private System.Windows.Forms.TextBox txt_english;
        private System.Windows.Forms.TextBox txt_src;
        private System.Windows.Forms.TextBox txt_bangla;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DemoStudentDataSet_Marks demoStudentDataSet_Marks;
        private System.Windows.Forms.BindingSource marksBindingSource1;
        private DemoStudentDataSet_MarksTableAdapters.marksTableAdapter marksTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMrollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stumclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMbanglaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMenglishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMmathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMgnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMgpaDataGridViewTextBoxColumn;
    }
}