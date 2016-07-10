namespace Models.BaseForms
{
    partial class Temp_BaseForm
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
            this.shownRecordsLbl = new System.Windows.Forms.Label();
            this.editRecordBtn = new System.Windows.Forms.Button();
            this.showAllRecordsBtn = new System.Windows.Forms.Button();
            this.deleteRecordBtn = new System.Windows.Forms.Button();
            this.addRecordBtn = new System.Windows.Forms.Button();
            this.baseGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.baseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shownRecordsLbl
            // 
            this.shownRecordsLbl.AutoSize = true;
            this.shownRecordsLbl.Location = new System.Drawing.Point(259, 329);
            this.shownRecordsLbl.Name = "shownRecordsLbl";
            this.shownRecordsLbl.Size = new System.Drawing.Size(85, 13);
            this.shownRecordsLbl.TabIndex = 20;
            this.shownRecordsLbl.Text = "0 records shown";
            // 
            // editRecordBtn
            // 
            this.editRecordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editRecordBtn.Location = new System.Drawing.Point(690, 32);
            this.editRecordBtn.Name = "editRecordBtn";
            this.editRecordBtn.Size = new System.Drawing.Size(66, 23);
            this.editRecordBtn.TabIndex = 19;
            this.editRecordBtn.Text = "Edit...";
            this.editRecordBtn.UseVisualStyleBackColor = true;
            // 
            // showAllRecordsBtn
            // 
            this.showAllRecordsBtn.Location = new System.Drawing.Point(259, 34);
            this.showAllRecordsBtn.Name = "showAllRecordsBtn";
            this.showAllRecordsBtn.Size = new System.Drawing.Size(62, 23);
            this.showAllRecordsBtn.TabIndex = 18;
            this.showAllRecordsBtn.Text = "Show All";
            this.showAllRecordsBtn.UseVisualStyleBackColor = true;
            // 
            // deleteRecordBtn
            // 
            this.deleteRecordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteRecordBtn.Location = new System.Drawing.Point(668, 322);
            this.deleteRecordBtn.Name = "deleteRecordBtn";
            this.deleteRecordBtn.Size = new System.Drawing.Size(88, 23);
            this.deleteRecordBtn.TabIndex = 17;
            this.deleteRecordBtn.Text = "Delete Record";
            this.deleteRecordBtn.UseVisualStyleBackColor = true;
            // 
            // addRecordBtn
            // 
            this.addRecordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRecordBtn.Location = new System.Drawing.Point(618, 32);
            this.addRecordBtn.Name = "addRecordBtn";
            this.addRecordBtn.Size = new System.Drawing.Size(66, 23);
            this.addRecordBtn.TabIndex = 16;
            this.addRecordBtn.Text = "Add...";
            this.addRecordBtn.UseVisualStyleBackColor = true;
            // 
            // baseGridView
            // 
            this.baseGridView.AllowUserToAddRows = false;
            this.baseGridView.AllowUserToDeleteRows = false;
            this.baseGridView.AllowUserToOrderColumns = true;
            this.baseGridView.AllowUserToResizeRows = false;
            this.baseGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.baseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baseGridView.Location = new System.Drawing.Point(259, 63);
            this.baseGridView.MultiSelect = false;
            this.baseGridView.Name = "baseGridView";
            this.baseGridView.ReadOnly = true;
            this.baseGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.baseGridView.Size = new System.Drawing.Size(497, 253);
            this.baseGridView.TabIndex = 15;
            // 
            // Temp_BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 357);
            this.Controls.Add(this.shownRecordsLbl);
            this.Controls.Add(this.editRecordBtn);
            this.Controls.Add(this.showAllRecordsBtn);
            this.Controls.Add(this.deleteRecordBtn);
            this.Controls.Add(this.addRecordBtn);
            this.Controls.Add(this.baseGridView);
            this.Name = "Temp_BaseForm";
            this.Text = "Temp_BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.baseGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shownRecordsLbl;
        private System.Windows.Forms.Button editRecordBtn;
        private System.Windows.Forms.Button showAllRecordsBtn;
        private System.Windows.Forms.Button deleteRecordBtn;
        private System.Windows.Forms.Button addRecordBtn;
        private System.Windows.Forms.DataGridView baseGridView;
    }
}