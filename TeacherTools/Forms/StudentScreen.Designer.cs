namespace TeacherTools.Forms
{
    partial class StudentScreen
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
            this.studentNameSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.middleNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNoTxt = new System.Windows.Forms.TextBox();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.batchInfoSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sectionTxt = new System.Windows.Forms.TextBox();
            this.gradeLevelNum = new System.Windows.Forms.NumericUpDown();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.deleteStudentBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.editStudentBtn = new System.Windows.Forms.Button();
            this.studentNoError = new System.Windows.Forms.ErrorProvider(this.components);
            this.shownRecordsLbl = new System.Windows.Forms.Label();
            this.studentNameSearchGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.batchInfoSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentNoError)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNameSearchGroupBox
            // 
            this.studentNameSearchGroupBox.Controls.Add(this.label2);
            this.studentNameSearchGroupBox.Controls.Add(this.label4);
            this.studentNameSearchGroupBox.Controls.Add(this.firstNameTxt);
            this.studentNameSearchGroupBox.Controls.Add(this.label3);
            this.studentNameSearchGroupBox.Controls.Add(this.middleNameTxt);
            this.studentNameSearchGroupBox.Controls.Add(this.lastNameTxt);
            this.studentNameSearchGroupBox.Location = new System.Drawing.Point(6, 74);
            this.studentNameSearchGroupBox.Name = "studentNameSearchGroupBox";
            this.studentNameSearchGroupBox.Size = new System.Drawing.Size(224, 112);
            this.studentNameSearchGroupBox.TabIndex = 8;
            this.studentNameSearchGroupBox.TabStop = false;
            this.studentNameSearchGroupBox.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Middle Name";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(79, 22);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(132, 20);
            this.firstNameTxt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // middleNameTxt
            // 
            this.middleNameTxt.Location = new System.Drawing.Point(79, 48);
            this.middleNameTxt.Name = "middleNameTxt";
            this.middleNameTxt.Size = new System.Drawing.Size(132, 20);
            this.middleNameTxt.TabIndex = 1;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(79, 74);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(132, 20);
            this.lastNameTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student No.";
            // 
            // studentNoTxt
            // 
            this.studentNoTxt.Location = new System.Drawing.Point(85, 28);
            this.studentNoTxt.Name = "studentNoTxt";
            this.studentNoTxt.Size = new System.Drawing.Size(132, 20);
            this.studentNoTxt.TabIndex = 3;
            this.studentNoTxt.TextChanged += new System.EventHandler(this.studentNoTxt_TextChanged);
            this.studentNoTxt.Validating += studentNoTxt_Validating;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.clearBtn);
            this.searchGroupBox.Controls.Add(this.searchBtn);
            this.searchGroupBox.Controls.Add(this.batchInfoSearchGroupBox);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Controls.Add(this.studentNoTxt);
            this.searchGroupBox.Controls.Add(this.studentNameSearchGroupBox);
            this.searchGroupBox.Location = new System.Drawing.Point(13, 31);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(239, 320);
            this.searchGroupBox.TabIndex = 1;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search Student";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(6, 290);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(62, 23);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(153, 290);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(77, 23);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // batchInfoSearchGroupBox
            // 
            this.batchInfoSearchGroupBox.Controls.Add(this.label6);
            this.batchInfoSearchGroupBox.Controls.Add(this.label5);
            this.batchInfoSearchGroupBox.Controls.Add(this.sectionTxt);
            this.batchInfoSearchGroupBox.Controls.Add(this.gradeLevelNum);
            this.batchInfoSearchGroupBox.Location = new System.Drawing.Point(6, 203);
            this.batchInfoSearchGroupBox.Name = "batchInfoSearchGroupBox";
            this.batchInfoSearchGroupBox.Size = new System.Drawing.Size(224, 81);
            this.batchInfoSearchGroupBox.TabIndex = 2;
            this.batchInfoSearchGroupBox.TabStop = false;
            this.batchInfoSearchGroupBox.Text = "Batch Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Grade Level";
            // 
            // sectionTxt
            // 
            this.sectionTxt.Location = new System.Drawing.Point(79, 45);
            this.sectionTxt.Name = "sectionTxt";
            this.sectionTxt.Size = new System.Drawing.Size(132, 20);
            this.sectionTxt.TabIndex = 8;
            // 
            // gradeLevelNum
            // 
            this.gradeLevelNum.Location = new System.Drawing.Point(81, 21);
            this.gradeLevelNum.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.gradeLevelNum.Name = "gradeLevelNum";
            this.gradeLevelNum.Size = new System.Drawing.Size(52, 20);
            this.gradeLevelNum.TabIndex = 9;
            // 
            // studentGridView
            // 
            this.studentGridView.AllowUserToAddRows = false;
            this.studentGridView.AllowUserToDeleteRows = false;
            this.studentGridView.AllowUserToOrderColumns = true;
            this.studentGridView.AllowUserToResizeRows = false;
            this.studentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Location = new System.Drawing.Point(258, 60);
            this.studentGridView.MultiSelect = false;
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.ReadOnly = true;
            this.studentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGridView.Size = new System.Drawing.Size(497, 253);
            this.studentGridView.TabIndex = 2;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addStudentBtn.Location = new System.Drawing.Point(617, 29);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(66, 23);
            this.addStudentBtn.TabIndex = 3;
            this.addStudentBtn.Text = "Add...";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // deleteStudentBtn
            // 
            this.deleteStudentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteStudentBtn.Location = new System.Drawing.Point(667, 319);
            this.deleteStudentBtn.Name = "deleteStudentBtn";
            this.deleteStudentBtn.Size = new System.Drawing.Size(88, 23);
            this.deleteStudentBtn.TabIndex = 5;
            this.deleteStudentBtn.Text = "Delete Student";
            this.deleteStudentBtn.UseVisualStyleBackColor = true;
            this.deleteStudentBtn.Click += new System.EventHandler(this.deleteStudentBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(258, 31);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(62, 23);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Show All";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // editStudentBtn
            // 
            this.editStudentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editStudentBtn.Location = new System.Drawing.Point(689, 29);
            this.editStudentBtn.Name = "editStudentBtn";
            this.editStudentBtn.Size = new System.Drawing.Size(66, 23);
            this.editStudentBtn.TabIndex = 7;
            this.editStudentBtn.Text = "Edit...";
            this.editStudentBtn.UseVisualStyleBackColor = true;
            this.editStudentBtn.Click += new System.EventHandler(this.editStudentBtn_Click);
            // 
            // studentNoError
            // 
            this.studentNoError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.studentNoError.ContainerControl = this;
            // 
            // shownRecordsLbl
            // 
            this.shownRecordsLbl.AutoSize = true;
            this.shownRecordsLbl.Location = new System.Drawing.Point(258, 326);
            this.shownRecordsLbl.Name = "shownRecordsLbl";
            this.shownRecordsLbl.Size = new System.Drawing.Size(85, 13);
            this.shownRecordsLbl.TabIndex = 8;
            this.shownRecordsLbl.Text = "0 records shown";
            // 
            // StudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 357);
            this.Controls.Add(this.shownRecordsLbl);
            this.Controls.Add(this.editStudentBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deleteStudentBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.searchGroupBox);
            this.Name = "StudentScreen";
            this.Text = "Students";
            this.Activated += new System.EventHandler(this.StudentScreen_Load);
            this.Load += new System.EventHandler(this.StudentScreen_Load);
            this.studentNameSearchGroupBox.ResumeLayout(false);
            this.studentNameSearchGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.batchInfoSearchGroupBox.ResumeLayout(false);
            this.batchInfoSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentNoError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNoTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox middleNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.GroupBox studentNameSearchGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown gradeLevelNum;
        private System.Windows.Forms.TextBox sectionTxt;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox batchInfoSearchGroupBox;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button deleteStudentBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button editStudentBtn;
        private System.Windows.Forms.ErrorProvider studentNoError;
        private System.Windows.Forms.Label shownRecordsLbl;
    }
}

