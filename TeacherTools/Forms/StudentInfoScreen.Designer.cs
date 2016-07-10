using System.Windows.Forms.VisualStyles;

namespace TeacherTools.Forms
{
    partial class StudentInfoScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.studentNoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.middleNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sectionTxt = new System.Windows.Forms.TextBox();
            this.gradeLevelNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.studentNumError = new System.Windows.Forms.ErrorProvider(this.components);
            this.firstNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.middleNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gradeLevelError = new System.Windows.Forms.ErrorProvider(this.components);
            this.sectionError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.genderDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentNumError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student No.";
            // 
            // studentNoTxt
            // 
            this.studentNoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentNoTxt.Location = new System.Drawing.Point(109, 16);
            this.studentNoTxt.Name = "studentNoTxt";
            this.studentNoTxt.Size = new System.Drawing.Size(133, 20);
            this.studentNoTxt.TabIndex = 10;
            this.studentNoTxt.Validating += studentNoTxt_Validating;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Middle Name";
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTxt.Location = new System.Drawing.Point(79, 20);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(148, 20);
            this.firstNameTxt.TabIndex = 12;
            this.firstNameTxt.Validating +=firstNameTxt_Validating;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Name";
            // 
            // middleNameTxt
            // 
            this.middleNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleNameTxt.Location = new System.Drawing.Point(79, 53);
            this.middleNameTxt.Name = "middleNameTxt";
            this.middleNameTxt.Size = new System.Drawing.Size(148, 20);
            this.middleNameTxt.TabIndex = 13;
            this.middleNameTxt.Validating += middleNameTxt_Validating;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTxt.Location = new System.Drawing.Point(79, 87);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(148, 20);
            this.lastNameTxt.TabIndex = 14;
            this.lastNameTxt.Validating += lastNameTxt_Validating;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Grade Level";
            // 
            // sectionTxt
            // 
            this.sectionTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionTxt.Location = new System.Drawing.Point(79, 49);
            this.sectionTxt.Name = "sectionTxt";
            this.sectionTxt.Size = new System.Drawing.Size(132, 20);
            this.sectionTxt.TabIndex = 19;
            this.sectionTxt.Validating += sectionTxt_Validating;
            // 
            // gradeLevelNum
            // 
            this.gradeLevelNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradeLevelNum.Location = new System.Drawing.Point(79, 23);
            this.gradeLevelNum.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.gradeLevelNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gradeLevelNum.Name = "gradeLevelNum";
            this.gradeLevelNum.Size = new System.Drawing.Size(52, 20);
            this.gradeLevelNum.TabIndex = 20;
            this.gradeLevelNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.genderDropdown);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.birthdatePicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lastNameTxt);
            this.groupBox1.Controls.Add(this.middleNameTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.firstNameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 188);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gradeLevelNum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.sectionTxt);
            this.groupBox2.Location = new System.Drawing.Point(13, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 90);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Batch Information";
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addStudentBtn.Location = new System.Drawing.Point(191, 352);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.addStudentBtn.TabIndex = 24;
            this.addStudentBtn.Text = "Add";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addEditStudentBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(17, 352);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 25;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click); 
            // 
            // studentNumError
            // 
            this.studentNumError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.studentNumError.ContainerControl = this;
            // 
            // firstNameError
            // 
            this.firstNameError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.firstNameError.ContainerControl = this;
            // 
            // middleNameError
            // 
            this.middleNameError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.middleNameError.ContainerControl = this;
            // 
            // lastNameError
            // 
            this.lastNameError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.lastNameError.ContainerControl = this;
            // 
            // gradeLevelError
            // 
            this.gradeLevelError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.gradeLevelError.ContainerControl = this;
            // 
            // sectionError
            // 
            this.sectionError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.sectionError.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Birthdate";
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdatePicker.Location = new System.Drawing.Point(76, 124);
            this.birthdatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(105, 20);
            this.birthdatePicker.TabIndex = 19;
            this.birthdatePicker.Value = new System.DateTime(2016, 7, 10, 15, 8, 21, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Gender";
            // 
            // genderDropdown
            // 
            this.genderDropdown.FormattingEnabled = true;
            this.genderDropdown.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.genderDropdown.Location = new System.Drawing.Point(76, 151);
            this.genderDropdown.MaxDropDownItems = 2;
            this.genderDropdown.MaxLength = 2;
            this.genderDropdown.Name = "genderDropdown";
            this.genderDropdown.Size = new System.Drawing.Size(105, 21);
            this.genderDropdown.Sorted = true;
            this.genderDropdown.TabIndex = 21;
            this.genderDropdown.Text = "Female";
            // 
            // StudentInfoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 387);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentNoTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentInfoScreen";
            this.Text = "Add Student";
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentNumError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeLevelError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNoTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox middleNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sectionTxt;
        private System.Windows.Forms.NumericUpDown gradeLevelNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider studentNumError;
        private System.Windows.Forms.ErrorProvider firstNameError;
        private System.Windows.Forms.ErrorProvider middleNameError;
        private System.Windows.Forms.ErrorProvider lastNameError;
        private System.Windows.Forms.ErrorProvider gradeLevelError;
        private System.Windows.Forms.ErrorProvider sectionError;
        private System.Windows.Forms.ComboBox genderDropdown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
        private System.Windows.Forms.Label label7;
    }
}