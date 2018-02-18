namespace LMS_OC
{
    partial class SearchForm
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
            this.gbSBD = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInAuthorName = new System.Windows.Forms.TextBox();
            this.txtInTitle = new System.Windows.Forms.TextBox();
            this.gbBD = new System.Windows.Forms.GroupBox();
            this.txtBorr = new System.Windows.Forms.TextBox();
            this.txtAvail = new System.Windows.Forms.TextBox();
            this.txtRackNo = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblborrNo = new System.Windows.Forms.Label();
            this.lblavailNo = new System.Windows.Forms.Label();
            this.lblRackNo = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbSBD.SuspendLayout();
            this.gbBD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(175, 18);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(198, 29);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "SEARCH BOOK";
            this.lblHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbSBD
            // 
            this.gbSBD.Controls.Add(this.radioButton2);
            this.gbSBD.Controls.Add(this.radioButton1);
            this.gbSBD.Controls.Add(this.btnSearch);
            this.gbSBD.Controls.Add(this.txtInAuthorName);
            this.gbSBD.Controls.Add(this.txtInTitle);
            this.gbSBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSBD.Location = new System.Drawing.Point(29, 71);
            this.gbSBD.Name = "gbSBD";
            this.gbSBD.Size = new System.Drawing.Size(497, 181);
            this.gbSBD.TabIndex = 1;
            this.gbSBD.TabStop = false;
            this.gbSBD.Text = "Search Book Details by:";
            this.gbSBD.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 29);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Author:";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 29);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Title:";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(335, 127);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 43);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtInAuthorName
            // 
            this.txtInAuthorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInAuthorName.Location = new System.Drawing.Point(151, 79);
            this.txtInAuthorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtInAuthorName.Name = "txtInAuthorName";
            this.txtInAuthorName.Size = new System.Drawing.Size(339, 26);
            this.txtInAuthorName.TabIndex = 3;
            this.txtInAuthorName.Visible = false;
            // 
            // txtInTitle
            // 
            this.txtInTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInTitle.Location = new System.Drawing.Point(151, 39);
            this.txtInTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtInTitle.Name = "txtInTitle";
            this.txtInTitle.Size = new System.Drawing.Size(339, 26);
            this.txtInTitle.TabIndex = 2;
            this.txtInTitle.Visible = false;
            // 
            // gbBD
            // 
            this.gbBD.Controls.Add(this.txtBorr);
            this.gbBD.Controls.Add(this.txtAvail);
            this.gbBD.Controls.Add(this.txtRackNo);
            this.gbBD.Controls.Add(this.txtPrice);
            this.gbBD.Controls.Add(this.txtAuthorID);
            this.gbBD.Controls.Add(this.txtTitle);
            this.gbBD.Controls.Add(this.txtISBN);
            this.gbBD.Controls.Add(this.txtID);
            this.gbBD.Controls.Add(this.lblborrNo);
            this.gbBD.Controls.Add(this.lblavailNo);
            this.gbBD.Controls.Add(this.lblRackNo);
            this.gbBD.Controls.Add(this.lblPrice);
            this.gbBD.Controls.Add(this.lblAuthorID);
            this.gbBD.Controls.Add(this.lblTitle);
            this.gbBD.Controls.Add(this.lblISBN);
            this.gbBD.Controls.Add(this.lblID);
            this.gbBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBD.Location = new System.Drawing.Point(29, 258);
            this.gbBD.Name = "gbBD";
            this.gbBD.Size = new System.Drawing.Size(497, 388);
            this.gbBD.TabIndex = 2;
            this.gbBD.TabStop = false;
            this.gbBD.Text = "Book Details";
            // 
            // txtBorr
            // 
            this.txtBorr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBorr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorr.Location = new System.Drawing.Point(151, 340);
            this.txtBorr.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorr.Name = "txtBorr";
            this.txtBorr.Size = new System.Drawing.Size(339, 26);
            this.txtBorr.TabIndex = 16;
            // 
            // txtAvail
            // 
            this.txtAvail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvail.Location = new System.Drawing.Point(151, 296);
            this.txtAvail.Margin = new System.Windows.Forms.Padding(4);
            this.txtAvail.Name = "txtAvail";
            this.txtAvail.Size = new System.Drawing.Size(339, 26);
            this.txtAvail.TabIndex = 15;
            // 
            // txtRackNo
            // 
            this.txtRackNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRackNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRackNo.Location = new System.Drawing.Point(151, 251);
            this.txtRackNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRackNo.Name = "txtRackNo";
            this.txtRackNo.Size = new System.Drawing.Size(339, 26);
            this.txtRackNo.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(151, 208);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(339, 26);
            this.txtPrice.TabIndex = 13;
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorID.Location = new System.Drawing.Point(151, 165);
            this.txtAuthorID.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(339, 26);
            this.txtAuthorID.TabIndex = 12;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(151, 121);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(339, 26);
            this.txtTitle.TabIndex = 11;
            // 
            // txtISBN
            // 
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(151, 79);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(339, 26);
            this.txtISBN.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(151, 34);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(339, 26);
            this.txtID.TabIndex = 4;
            // 
            // lblborrNo
            // 
            this.lblborrNo.AutoSize = true;
            this.lblborrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblborrNo.Location = new System.Drawing.Point(17, 338);
            this.lblborrNo.Name = "lblborrNo";
            this.lblborrNo.Size = new System.Drawing.Size(112, 20);
            this.lblborrNo.TabIndex = 9;
            this.lblborrNo.Text = "Borrowed No:";
            this.lblborrNo.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblavailNo
            // 
            this.lblavailNo.AutoSize = true;
            this.lblavailNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailNo.Location = new System.Drawing.Point(17, 298);
            this.lblavailNo.Name = "lblavailNo";
            this.lblavailNo.Size = new System.Drawing.Size(107, 20);
            this.lblavailNo.TabIndex = 8;
            this.lblavailNo.Text = "Available No:";
            // 
            // lblRackNo
            // 
            this.lblRackNo.AutoSize = true;
            this.lblRackNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRackNo.Location = new System.Drawing.Point(17, 253);
            this.lblRackNo.Name = "lblRackNo";
            this.lblRackNo.Size = new System.Drawing.Size(78, 20);
            this.lblRackNo.TabIndex = 7;
            this.lblRackNo.Text = "Rack No:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(17, 208);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorID.Location = new System.Drawing.Point(17, 165);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(85, 20);
            this.lblAuthorID.TabIndex = 5;
            this.lblAuthorID.Text = "Author ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(17, 121);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 20);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(17, 79);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(53, 20);
            this.lblISBN.TabIndex = 3;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(17, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 20);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(364, 664);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 43);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 735);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbBD);
            this.Controls.Add(this.gbSBD);
            this.Controls.Add(this.lblHeading);
            this.Name = "SearchForm";
            this.Text = "SeachForm";
            this.gbSBD.ResumeLayout(false);
            this.gbSBD.PerformLayout();
            this.gbBD.ResumeLayout(false);
            this.gbBD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox gbSBD;
        private System.Windows.Forms.GroupBox gbBD;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblborrNo;
        private System.Windows.Forms.Label lblavailNo;
        private System.Windows.Forms.Label lblRackNo;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtInAuthorName;
        private System.Windows.Forms.TextBox txtInTitle;
        private System.Windows.Forms.TextBox txtBorr;
        private System.Windows.Forms.TextBox txtAvail;
        private System.Windows.Forms.TextBox txtRackNo;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}