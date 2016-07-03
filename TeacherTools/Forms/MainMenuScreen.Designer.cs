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
            this.classListMenuBtn = new System.Windows.Forms.Button();
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
            this.studentsListMenuBtn.Size = new System.Drawing.Size(267, 76);
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
            this.label1.Location = new System.Drawing.Point(100, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage class lists.\r\nSearch, Add, Edit, Delete class lists";
            // 
            // classListMenuBtn
            // 
            this.classListMenuBtn.BackColor = System.Drawing.SystemColors.Control;
            this.classListMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classListMenuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classListMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("classListMenuBtn.Image")));
            this.classListMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classListMenuBtn.Location = new System.Drawing.Point(12, 104);
            this.classListMenuBtn.Name = "classListMenuBtn";
            this.classListMenuBtn.Size = new System.Drawing.Size(267, 77);
            this.classListMenuBtn.TabIndex = 5;
            this.classListMenuBtn.Text = "Class List";
            this.classListMenuBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.classListMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.classListMenuBtn.UseVisualStyleBackColor = false;
            this.classListMenuBtn.Click += new System.EventHandler(this.classListMenuBtn_Click);
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classListMenuBtn);
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
        private System.Windows.Forms.Button classListMenuBtn;


    }
}