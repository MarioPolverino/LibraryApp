namespace LMS_OC
{
    partial class ReserveForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.bookIssueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDBDataSet = new LMS_OC.LMSDBDataSet();
            this.bookIssueTableAdapter = new LMS_OC.LMSDBDataSetTableAdapters.BookIssueTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblRSD = new System.Windows.Forms.Label();
            this.lblLibrarianID = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtRSD = new System.Windows.Forms.TextBox();
            this.txtLibrarianID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).BeginInit();
            this.gbDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookIssueBindingSource
            // 
            this.bookIssueBindingSource.DataMember = "BookIssue";
            this.bookIssueBindingSource.DataSource = this.lMSDBDataSet;
            // 
            // lMSDBDataSet
            // 
            this.lMSDBDataSet.DataSetName = "LMSDBDataSet";
            this.lMSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookIssueTableAdapter
            // 
            this.bookIssueTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookID,
            this.BookTitle,
            this.StudentID,
            this.ReturnDate});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewItem1.Tag = "BookID";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(6, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(616, 184);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // BookID
            // 
            this.BookID.Text = "BookID";
            this.BookID.Width = 76;
            // 
            // BookTitle
            // 
            this.BookTitle.Text = "BookTitle";
            this.BookTitle.Width = 250;
            // 
            // StudentID
            // 
            this.StudentID.Text = "StudentID";
            this.StudentID.Width = 88;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Text = "ReturnDate";
            this.ReturnDate.Width = 194;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reserve a Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(33, 49);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(74, 20);
            this.lblBookID.TabIndex = 2;
            this.lblBookID.Text = "Book ID:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(33, 101);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(93, 20);
            this.lblStudentID.TabIndex = 3;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblRSD
            // 
            this.lblRSD.AutoSize = true;
            this.lblRSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSD.Location = new System.Drawing.Point(33, 152);
            this.lblRSD.Name = "lblRSD";
            this.lblRSD.Size = new System.Drawing.Size(117, 20);
            this.lblRSD.TabIndex = 4;
            this.lblRSD.Text = "Reserve Date:";
            // 
            // lblLibrarianID
            // 
            this.lblLibrarianID.AutoSize = true;
            this.lblLibrarianID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarianID.Location = new System.Drawing.Point(33, 200);
            this.lblLibrarianID.Name = "lblLibrarianID";
            this.lblLibrarianID.Size = new System.Drawing.Size(102, 20);
            this.lblLibrarianID.TabIndex = 5;
            this.lblLibrarianID.Text = "Librarian ID:";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtLibrarianID);
            this.gbDetails.Controls.Add(this.txtRSD);
            this.gbDetails.Controls.Add(this.txtStudentID);
            this.gbDetails.Controls.Add(this.txtBookID);
            this.gbDetails.Controls.Add(this.btnReserve);
            this.gbDetails.Controls.Add(this.btnCancel);
            this.gbDetails.Controls.Add(this.lblBookID);
            this.gbDetails.Controls.Add(this.lblLibrarianID);
            this.gbDetails.Controls.Add(this.lblStudentID);
            this.gbDetails.Controls.Add(this.lblRSD);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(24, 314);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(633, 318);
            this.gbDetails.TabIndex = 6;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Insert Details:";
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(387, 253);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(106, 43);
            this.btnReserve.TabIndex = 6;
            this.btnReserve.Text = "&Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(521, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(545, 648);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 43);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(192, 42);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(435, 30);
            this.txtBookID.TabIndex = 8;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(192, 94);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(435, 30);
            this.txtStudentID.TabIndex = 9;
            // 
            // txtRSD
            // 
            this.txtRSD.Location = new System.Drawing.Point(192, 145);
            this.txtRSD.Name = "txtRSD";
            this.txtRSD.Size = new System.Drawing.Size(435, 30);
            this.txtRSD.TabIndex = 10;
            // 
            // txtLibrarianID
            // 
            this.txtLibrarianID.Location = new System.Drawing.Point(192, 193);
            this.txtLibrarianID.Name = "txtLibrarianID";
            this.txtLibrarianID.Size = new System.Drawing.Size(435, 30);
            this.txtLibrarianID.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 231);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books Borrowed:";
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 703);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.label1);
            this.Name = "ReserveForm";
            this.Text = "ReserveForm";
            this.Load += new System.EventHandler(this.ReserveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookIssueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDBDataSet)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LMSDBDataSet lMSDBDataSet;
        private System.Windows.Forms.BindingSource bookIssueBindingSource;
        private LMSDBDataSetTableAdapters.BookIssueTableAdapter bookIssueTableAdapter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BookID;
        private System.Windows.Forms.ColumnHeader StudentID;
        private System.Windows.Forms.ColumnHeader ReturnDate;
        private System.Windows.Forms.ColumnHeader BookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblRSD;
        private System.Windows.Forms.Label lblLibrarianID;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtLibrarianID;
        private System.Windows.Forms.TextBox txtRSD;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}