using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS_OC
{
    public partial class ReserveForm : Form
    {
        public ReserveForm()
        {
            InitializeComponent();
        }

        private void ReserveForm_Load(object sender, EventArgs e)
        {
            DisplayIssued();

        }
        private void DisplayIssued()
        {
            string selectQuery;

            selectQuery = "SELECT BookIssue.bookID,Book.title,BookIssue.StudentID,BookIssue.returnDate From BookIssue JOIN Book ON BookIssue.bookID = Book.bookID";
           
           

            SqlConnection conn = ConnectionManager.DBConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // Define the list items

                    Book booksDetails = new Book();
                    booksDetails.BookTitle = rdr["title"].ToString();
                    IssueBook books = new IssueBook();
                    books.BookID = int.Parse(rdr["bookID"].ToString());
                    books.StudentID = int.Parse(rdr["StudentID"].ToString());
                    books.DoR = DateTime.Parse(rdr["returnDate"].ToString());

                    ListViewItem lvi = new ListViewItem(books.BookID.ToString());
                    lvi.SubItems.Add(booksDetails.BookTitle);
                    lvi.SubItems.Add(books.StudentID.ToString());
                    lvi.SubItems.Add(books.DoR.ToString());
                   
                    listView1.Items.Add(lvi);
                }
                if (rdr != null)
                    rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }
        }
        private bool ValidateInputs()
        {
            if (txtBookID.Text == "" || int.Parse(txtBookID.Text) == 0)
            {
                MessageBox.Show("Please inset a Valid BookID .");
                txtBookID.Focus();
                return false;
            }
            if (txtStudentID.Text == "" || int.Parse(txtStudentID.Text) < 1000)
            {
                MessageBox.Show("Please inset a Valid StudentID");
                txtStudentID.Focus();
                return false;
            }

            if (txtLibrarianID.Text == "" || int.Parse(txtLibrarianID.Text) == 0)
            {
                MessageBox.Show("Please inset a Valid Librarian ID");
                txtLibrarianID.Focus();
                return false;
            }


            return true;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs() == false)
                {
                    return;
                }
                Book ToReserveBook = new Book();
                ToReserveBook.BookID = int.Parse(txtBookID.Text);

                string ConditionQuery;

                ConditionQuery = "select noOfAvailableBooks from Book where bookID=(" + int.Parse(txtBookID.Text) + ")";



                SqlConnection conn = ConnectionManager.DBConnection();
                SqlDataReader rdr = null;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(ConditionQuery, conn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {



                        ToReserveBook.AvailableBooks = int.Parse(rdr["noOfAvailableBooks"].ToString());

                        if (ToReserveBook.AvailableBooks <= 0)
                        {
                            ReserveBook ReserveBook = new ReserveBook();
                            ReserveBook.BookID = int.Parse(txtBookID.Text);
                            ReserveBook.StudentID = int.Parse(txtStudentID.Text);
                            ReserveBook.RSD = DateTime.Parse(txtRSD.Text);
                            ReserveBook.LibrarianID = int.Parse(txtLibrarianID.Text);
                            ReserveBook.AddNewReserve();
                            MessageBox.Show(" Book Reservation Complete.", "Reserve");


                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Book Requested is available at moment." + Environment.NewLine + "Do you want Issue this book now?", "Hey The Book is Available.", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                this.Hide();
                                IssueForm Procede = new IssueForm();
                                Procede.Show();



                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show(" It's not allowed to reserve book , unless they are not Available.", "Sorry NOT ALLOWED");
                                txtBookID.Text = "";
                                txtStudentID.Text = "";
                                txtRSD.Text = "";
                                txtLibrarianID.Text = "";
                                txtBookID.Focus();
                            }

                        }
                    }


                }
                catch
                {
                    MessageBox.Show("Please make sure the follow details are inserted in the right format as in this example:" + Environment.NewLine + "BookiD : 1" + Environment.NewLine + "Student ID : 1001" + Environment.NewLine + "Date of Reserve: MM-DD-YYYY" + Environment.NewLine + "LibrarianID : 2");

                }
            }
            catch
            {
                MessageBox.Show("Please make sure the follow details are inserted in the right format as in this example:" + Environment.NewLine + "BookiD : 1" + Environment.NewLine + "Student ID : 1001" + Environment.NewLine + "Date of Reserve: MM-DD-YYYY" + Environment.NewLine + "LibrarianID : 2");

            }
        }
    }
}
