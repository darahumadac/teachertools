namespace TeacherTools.Forms
{
    partial class StudentMainScreen
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
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.batchInfoSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sectionTxt = new System.Windows.Forms.TextBox();
            this.gradeLevelNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNoTxt = new System.Windows.Forms.TextBox();
            this.studentNameSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.middleNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.studentNoError = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchGroupBox.SuspendLayout();
            this.batchInfoSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelNum)).BeginInit();
            this.studentNameSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentNoError)).BeginInit();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.clearBtn);
            this.searchGroupBox.Controls.Add(this.searchBtn);
            this.searchGroupBox.Controls.Add(this.batchInfoSearchGroupBox);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Controls.Add(this.studentNoTxt);
            this.searchGroupBox.Controls.Add(this.studentNameSearchGroupBox);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 23);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(239, 320);
            this.searchGroupBox.TabIndex = 2;
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
            this.studentNoTxt.TextChanged += studentNoTxt_TextChanged;
            this.studentNoTxt.Validating +=studentNoTxt_Validating;
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
            // studentNoError
            // 
            this.studentNoError.ContainerControl = this;
            // 
            // StudentMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 357);
            this.Controls.Add(this.searchGroupBox);
            this.Name = "StudentMainScreen";
            this.Text = "Student List Screen";
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.batchInfoSearchGroupBox.ResumeLayout(false);
            this.batchInfoSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelNum)).EndInit();
            this.studentNameSearchGroupBox.ResumeLayout(false);
            this.studentNameSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentNoError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox batchInfoSearchGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sectionTxt;
        private System.Windows.Forms.NumericUpDown gradeLevelNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNoTxt;
        private System.Windows.Forms.GroupBox studentNameSearchGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox middleNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.ErrorProvider studentNoError;
    }
}