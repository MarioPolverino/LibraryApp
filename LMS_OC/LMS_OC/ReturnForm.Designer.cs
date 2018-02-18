namespace LMS_OC
{
    partial class ReturnForm
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
            this.lblRDoR = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtLibrarianID = new System.Windows.Forms.TextBox();
            this.lblLibrarianID = new System.Windows.Forms.Label();
            this.txtRDoR = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(191, 13);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(157, 29);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Return Book";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(24, 49);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(74, 20);
            this.lblBookID.TabIndex = 1;
            this.lblBookID.Text = "Book ID:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(24, 94);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(93, 20);
            this.lblStudentID.TabIndex = 2;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblRDoR
            // 
            this.lblRDoR.AutoSize = true;
            this.lblRDoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRDoR.Location = new System.Drawing.Point(24, 139);
            this.lblRDoR.Name = "lblRDoR";
            this.lblRDoR.Size = new System.Drawing.Size(124, 20);
            this.lblRDoR.TabIndex = 3;
            this.lblRDoR.Text = "Date of Return:";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtLibrarianID);
            this.gbDetails.Controls.Add(this.lblLibrarianID);
            this.gbDetails.Controls.Add(this.txtRDoR);
            this.gbDetails.Controls.Add(this.txtStudentID);
            this.gbDetails.Controls.Add(this.txtBookID);
            this.gbDetails.Controls.Add(this.btnCancel);
            this.gbDetails.Controls.Add(this.btnReturn);
            this.gbDetails.Controls.Add(this.lblBookID);
            this.gbDetails.Controls.Add(this.lblRDoR);
            this.gbDetails.Controls.Add(this.lblStudentID);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(36, 68);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(447, 329);
            this.gbDetails.TabIndex = 4;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Insert Details:";
            // 
            // txtLibrarianID
            // 
            this.txtLibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibrarianID.Location = new System.Drawing.Point(160, 180);
            this.txtLibrarianID.Name = "txtLibrarianID";
            this.txtLibrarianID.Size = new System.Drawing.Size(256, 26);
            this.txtLibrarianID.TabIndex = 10;
            // 
            // lblLibrarianID
            // 
            this.lblLibrarianID.AutoSize = true;
            this.lblLibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarianID.Location = new System.Drawing.Point(24, 183);
            this.lblLibrarianID.Name = "lblLibrarianID";
            this.lblLibrarianID.Size = new System.Drawing.Size(102, 20);
            this.lblLibrarianID.TabIndex = 9;
            this.lblLibrarianID.Text = "Librarian ID:";
            this.lblLibrarianID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRDoR
            // 
            this.txtRDoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRDoR.Location = new System.Drawing.Point(160, 132);
            this.txtRDoR.Name = "txtRDoR";
            this.txtRDoR.Size = new System.Drawing.Size(256, 26);
            this.txtRDoR.TabIndex = 8;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(160, 87);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(256, 26);
            this.txtStudentID.TabIndex = 7;
            // 
            // txtBookID
            // 
            this.txtBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookID.Location = new System.Drawing.Point(160, 42);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(256, 26);
            this.txtBookID.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(327, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(210, 257);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(89, 45);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(363, 422);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 480);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lblHeading);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblRDoR;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtRDoR;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtLibrarianID;
        private System.Windows.Forms.Label lblLibrarianID;
    }
}