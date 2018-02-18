using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_OC
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtInAuthorName.Visible = false;
            txtInTitle.Visible = true;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtInTitle.Visible = false;
            txtInAuthorName.Visible = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked== false && radioButton2.Checked == false)
            {
                MessageBox.Show("Please Select Title or Author Option to search the book."); 
            }

            DataTable bookTitle = ConnectionManager.GetTable("select * from Book where title LIKE '%" + txtInTitle.Text + "%'");
            DataTable bookAuthorName = ConnectionManager.GetTable("select * from Author JOIN Book ON Author.AuthorID = Book.AuthorID where AuthorName LIKE '%" + txtInAuthorName.Text + "%'");


            if ((radioButton1.Checked == true && txtInTitle.Text == "") || (radioButton2.Checked == true && txtInAuthorName.Text == ""))  
            {
                txtID.Clear();
                txtISBN.Clear();
                txtTitle.Clear();
                txtAuthorID.Clear();
                txtPrice.Clear();
                txtRackNo.Clear();
                txtAvail.Clear();
                txtBorr.Clear();
                txtInTitle.Clear();
                txtInAuthorName.Clear();
                MessageBox.Show("Please provide Title or Author of the Book to search.");
                txtInTitle.Focus();
                return;
            }
            else if (radioButton1.Checked == true && txtInTitle.Text != "")
            {

                if (bookTitle.Rows.Count == 0)
                {
                    txtID.Clear();
                    txtISBN.Clear();
                    txtTitle.Clear();
                    txtAuthorID.Clear();
                    txtPrice.Clear();
                    txtRackNo.Clear();
                    txtAvail.Clear();
                    txtBorr.Clear();
                    txtInTitle.Clear();
                    txtInAuthorName.Clear();
                    MessageBox.Show("Sorry Book doesn't exist, Try Again!");


                }
                else
                {
                    MessageBox.Show("Book found successfully.");
                    txtID.Text = bookTitle.Rows[0]["bookID"].ToString();
                    txtISBN.Text = bookTitle.Rows[0]["ISBN"].ToString();
                    txtTitle.Text = bookTitle.Rows[0]["title"].ToString();
                    txtAuthorID.Text = bookTitle.Rows[0]["AuthorID"].ToString();
                    txtPrice.Text = bookTitle.Rows[0]["price"].ToString();
                    txtRackNo.Text = bookTitle.Rows[0]["rackNo"].ToString();
                    txtAvail.Text = bookTitle.Rows[0]["noofAvailablebooks"].ToString();
                    txtBorr.Text = bookTitle.Rows[0]["noofBorrowedbooks"].ToString();

                }
            }
            else if (radioButton2.Checked == true && txtInAuthorName.Text != "")
            {
                if (bookAuthorName.Rows.Count == 0)
                {
                    txtID.Clear();
                    txtISBN.Clear();
                    txtTitle.Clear();
                    txtAuthorID.Clear();
                    txtPrice.Clear();
                    txtRackNo.Clear();
                    txtAvail.Clear();
                    txtBorr.Clear();
                    txtInTitle.Clear();
                    txtInAuthorName.Clear();
                    MessageBox.Show("Sorry Book doesn't exist, Try Again!");


                }
                else
                {
                    MessageBox.Show("Book found successfully.");
                   
                    txtAuthorID.Text = bookAuthorName.Rows[0]["AuthorID"].ToString();
                    
                   
                    txtID.Text = bookAuthorName.Rows[0]["bookID"].ToString();
                    txtISBN.Text = bookAuthorName.Rows[0]["ISBN"].ToString();
                    txtTitle.Text = bookAuthorName.Rows[0]["title"].ToString();
                    txtAuthorID.Text = bookAuthorName.Rows[0]["AuthorID"].ToString();
                    txtPrice.Text = bookAuthorName.Rows[0]["price"].ToString();
                    txtRackNo.Text = bookAuthorName.Rows[0]["rackNo"].ToString();
                    txtAvail.Text = bookAuthorName.Rows[0]["noofAvailablebooks"].ToString();
                    txtBorr.Text = bookAuthorName.Rows[0]["noofBorrowedbooks"].ToString();

                }

            
            }
       
        }

       

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
