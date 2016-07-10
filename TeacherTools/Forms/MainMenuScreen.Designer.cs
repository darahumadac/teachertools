namespace TeacherTools.Forms
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            this.studentListMenuDesc = new System.Windows.Forms.Label();
            this.studentsListMenuBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.classRecordMenuBtn = new System.Windows.Forms.Button();
            this.subjectMenuBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentListMenuDesc
            // 
            this.studentListMenuDesc.AutoSize = true;
            this.studentListMenuDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.studentListMenuDesc.Location = new System.Drawing.Point(100, 42);
            this.studentListMenuDesc.Name = "studentListMenuDesc";
            this.studentListMenuDesc.Size = new System.Drawing.Size(169, 26);
            this.studentListMenuDesc.TabIndex = 2;
            this.studentListMenuDesc.Text = "Manage Students.\r\nSearch, Add, Edit, Delete students";
            // 
            // studentsListMenuBtn
            // 
            this.studentsListMenuBtn.BackColor = System.Drawing.SystemColors.Control;
            this.studentsListMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentsListMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsListMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("studentsListMenuBtn.Image")));
            this.studentsListMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentsListMenuBtn.Location = new System.Drawing.Point(12, 12);
            this.studentsListMenuBtn.Name = "studentsListMenuBtn";
            this.studentsListMenuBtn.Size = new System.Drawing.Size(328, 76);
            this.studentsListMenuBtn.TabIndex = 3;
            this.studentsListMenuBtn.Text = "Students";
            this.studentsListMenuBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.studentsListMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.studentsListMenuBtn.UseVisualStyleBackColor = false;
            this.studentsListMenuBtn.Click += new System.EventHandler(this.studentsListMenuBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(100, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Class Records.\r\nSearch, Add, Edit, Delete class records";
            // 
            // classRecordMenuBtn
            // 
            this.classRecordMenuBtn.BackColor = System.Drawing.SystemColors.Control;
            this.classRecordMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classRecordMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classRecordMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("classRecordMenuBtn.Image")));
            this.classRecordMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classRecordMenuBtn.Location = new System.Drawing.Point(12, 186);
            this.classRecordMenuBtn.Name = "classRecordMenuBtn";
            this.classRecordMenuBtn.Size = new System.Drawing.Size(328, 79);
            this.classRecordMenuBtn.TabIndex = 5;
            this.classRecordMenuBtn.Text = "Class Record";
            this.classRecordMenuBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.classRecordMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.classRecordMenuBtn.UseVisualStyleBackColor = false;
            this.classRecordMenuBtn.Click += new System.EventHandler(this.classRecordMenuBtn_Click);
            // 
            // subjectMenuBtn
            // 
            this.subjectMenuBtn.BackColor = System.Drawing.SystemColors.Control;
            this.subjectMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subjectMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("subjectMenuBtn.Image")));
            this.subjectMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subjectMenuBtn.Location = new System.Drawing.Point(12, 94);
            this.subjectMenuBtn.Name = "subjectMenuBtn";
            this.subjectMenuBtn.Size = new System.Drawing.Size(328, 85);
            this.subjectMenuBtn.TabIndex = 6;
            this.subjectMenuBtn.Text = "Subjects / Requirements";
            this.subjectMenuBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.subjectMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.subjectMenuBtn.UseVisualStyleBackColor = false;
            this.subjectMenuBtn.Click += new System.EventHandler(this.subjectMenuBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.Location = new System.Drawing.Point(100, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Manage Subjects and its Requirements.\r\nAdd, Edit, and Delete subject requirements" +
    "";
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectMenuBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classRecordMenuBtn);
            this.Controls.Add(this.studentListMenuDesc);
            this.Controls.Add(this.studentsListMenuBtn);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "MainMenuScreen";
            this.Text = "Teacher Tools Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentListMenuDesc;
        private System.Windows.Forms.Button studentsListMenuBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button classRecordMenuBtn;
        private System.Windows.Forms.Button subjectMenuBtn;
        private System.Windows.Forms.Label label2;


    }
}