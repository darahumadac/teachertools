namespace TeacherTools.Forms
{
    partial class SubjectMainScreen
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
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.batchInfoSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sectionTxt = new System.Windows.Forms.TextBox();
            this.gradeLevelNum = new System.Windows.Forms.NumericUpDown();
            this.clearBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectNameTxt = new System.Windows.Forms.TextBox();
            this.teacherNameSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.middleNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.searchGroupBox.SuspendLayout();
            this.batchInfoSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelNum)).BeginInit();
            this.teacherNameSearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.batchInfoSearchGroupBox);
            this.searchGroupBox.Controls.Add(this.clearBtn);
            this.searchGroupBox.Controls.Add(this.searchBtn);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Controls.Add(this.subjectNameTxt);
            this.searchGroupBox.Controls.Add(this.teacherNameSearchGroupBox);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 23);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(239, 320);
            this.searchGroupBox.TabIndex = 22;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search Subject";
            // 
            // batchInfoSearchGroupBox
            // 
            this.batchInfoSearchGroupBox.Controls.Add(this.label6);
            this.batchInfoSearchGroupBox.Controls.Add(this.label5);
            this.batchInfoSearchGroupBox.Controls.Add(this.sectionTxt);
            this.batchInfoSearchGroupBox.Controls.Add(this.gradeLevelNum);
            this.batchInfoSearchGroupBox.Location = new System.Drawing.Point(6, 66);
            this.batchInfoSearchGroupBox.Name = "batchInfoSearchGroupBox";
            this.batchInfoSearchGroupBox.Size = new System.Drawing.Size(224, 81);
            this.batchInfoSearchGroupBox.TabIndex = 11;
            this.batchInfoSearchGroupBox.TabStop = false;
            this.batchInfoSearchGroupBox.Text = "Class Information";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject Name";
            // 
            // subjectNameTxt
            // 
            this.subjectNameTxt.Location = new System.Drawing.Point(85, 28);
            this.subjectNameTxt.Name = "subjectNameTxt";
            this.subjectNameTxt.Size = new System.Drawing.Size(132, 20);
            this.subjectNameTxt.TabIndex = 3;
            // 
            // teacherNameSearchGroupBox
            // 
            this.teacherNameSearchGroupBox.Controls.Add(this.label2);
            this.teacherNameSearchGroupBox.Controls.Add(this.label4);
            this.teacherNameSearchGroupBox.Controls.Add(this.firstNameTxt);
            this.teacherNameSearchGroupBox.Controls.Add(this.label3);
            this.teacherNameSearchGroupBox.Controls.Add(this.middleNameTxt);
            this.teacherNameSearchGroupBox.Controls.Add(this.lastNameTxt);
            this.teacherNameSearchGroupBox.Location = new System.Drawing.Point(6, 161);
            this.teacherNameSearchGroupBox.Name = "teacherNameSearchGroupBox";
            this.teacherNameSearchGroupBox.Size = new System.Drawing.Size(224, 112);
            this.teacherNameSearchGroupBox.TabIndex = 8;
            this.teacherNameSearchGroupBox.TabStop = false;
            this.teacherNameSearchGroupBox.Text = "Teacher Name";
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
            // SubjectMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(768, 357);
            this.Controls.Add(this.searchGroupBox);
            this.Name = "SubjectMainScreen";
            this.Controls.SetChildIndex(this.searchGroupBox, 0);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.batchInfoSearchGroupBox.ResumeLayout(false);
            this.batchInfoSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelNum)).EndInit();
            this.teacherNameSearchGroupBox.ResumeLayout(false);
            this.teacherNameSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectNameTxt;
        private System.Windows.Forms.GroupBox batchInfoSearchGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sectionTxt;
        private System.Windows.Forms.NumericUpDown gradeLevelNum;
        private System.Windows.Forms.GroupBox teacherNameSearchGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox middleNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
    }
}
