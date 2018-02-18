namespace LMS_OC
{
    partial class IssueForm
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblDoI = new System.Windows.Forms.Label();
            this.lblDoR = new System.Windows.Forms.Label();
            this.lblLibrarianID = new System.Windows.Forms.Label();
            this.gbIssueDetails = new System.Windows.Forms.GroupBox();
            this.txtDoR = new System.Windows.Forms.TextBox();
            this.txtDoI = new System.Windows.Forms.TextBox();
            this.txtLibrarianID = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbIssueDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(179, 26);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(163, 29);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Issue a Book";
            this.lblHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(22, 99);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(74, 20);
            this.lblBookID.TabIndex = 1;
            this.lblBookID.Text = "Book ID:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(22, 143);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(93, 20);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblDoI
            // 
            this.lblDoI.AutoSize = true;
            this.lblDoI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoI.Location = new System.Drawing.Point(22, 188);
            this.lblDoI.Name = "lblDoI";
            this.lblDoI.Size = new System.Drawing.Size(114, 20);
            this.lblDoI.TabIndex = 3;
            this.lblDoI.Text = "Date of Issue:";
            // 
            // lblDoR
            // 
            this.lblDoR.AutoSize = true;
            this.lblDoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoR.Location = new System.Drawing.Point(22, 230);
            this.lblDoR.Name = "lblDoR";
            this.lblDoR.Size = new System.Drawing.Size(124, 20);
            this.lblDoR.TabIndex = 4;
            this.lblDoR.Text = "Date of Return:";
            // 
            // lblLibrarianID
            // 
            this.lblLibrarianID.AutoSize = true;
            this.lblLibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarianID.Location = new System.Drawing.Point(22, 279);
            this.lblLibrarianID.Name = "lblLibrarianID";
            this.lblLibrarianID.Size = new System.Drawing.Size(102, 20);
            this.lblLibrarianID.TabIndex = 5;
            this.lblLibrarianID.Text = "Librarian ID:";
            // 
            // gbIssueDetails
            // 
            this.gbIssueDetails.Controls.Add(this.txtDoR);
            this.gbIssueDetails.Controls.Add(this.txtDoI);
            this.gbIssueDetails.Controls.Add(this.txtLibrarianID);
            this.gbIssueDetails.Controls.Add(this.txtStudentID);
            this.gbIssueDetails.Controls.Add(this.txtBookID);
            this.gbIssueDetails.Controls.Add(this.lblBookID);
            this.gbIssueDetails.Controls.Add(this.btnCancel);
            this.gbIssueDetails.Controls.Add(this.lblLibrarianID);
            this.gbIssueDetails.Controls.Add(this.btnIssue);
            this.gbIssueDetails.Controls.Add(this.lblStudentID);
            this.gbIssueDetails.Controls.Add(this.lblDoR);
            this.gbIssueDetails.Controls.Add(this.lblDoI);
            this.gbIssueDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIssueDetails.Location = new System.Drawing.Point(12, 81);
            this.gbIssueDetails.Name = "gbIssueDetails";
            this.gbIssueDetails.Size = new System.Drawing.Size(504, 417);
            this.gbIssueDetails.TabIndex = 6;
            this.gbIssueDetails.TabStop = false;
            this.gbIssueDetails.Text = "Insert Details:";
            // 
            // txtDoR
            // 
            this.txtDoR.Location = new System.Drawing.Point(158, 230);
            this.txtDoR.Name = "txtDoR";
            this.txtDoR.Size = new System.Drawing.Size(321, 30);
            this.txtDoR.TabIndex = 12;
            // 
            // txtDoI
            // 
            this.txtDoI.Location = new System.Drawing.Point(158, 181);
            this.txtDoI.Name = "txtDoI";
            this.txtDoI.Size = new System.Drawing.Size(321, 30);
            this.txtDoI.TabIndex = 11;
            // 
            // txtLibrarianID
            // 
            this.txtLibrarianID.Location = new System.Drawing.Point(158, 272);
            this.txtLibrarianID.Name = "txtLibrarianID";
            this.txtLibrarianID.Size = new System.Drawing.Size(321, 30);
            this.txtLibrarianID.TabIndex = 13;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(158, 136);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(321, 30);
            this.txtStudentID.TabIndex = 10;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(158, 92);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(321, 30);
            this.txtBookID.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(358, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 46);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(209, 336);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(121, 46);
            this.btnIssue.TabIndex = 7;
            this.btnIssue.Text = "&Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(370, 530);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 46);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // IssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 598);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbIssueDetails);
            this.Controls.Add(this.lblHeading);
            this.Name = "IssueForm";
            this.Text = "IssueForm";
            this.Load += new System.EventHandler(this.IssueForm_Load);
            this.gbIssueDetails.ResumeLayout(false);
            this.gbIssueDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblDoI;
        private System.Windows.Forms.Label lblDoR;
        private System.Windows.Forms.Label lblLibrarianID;
        private System.Windows.Forms.GroupBox gbIssueDetails;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLibrarianID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtDoR;
        private System.Windows.Forms.TextBox txtDoI;
    }
}