using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace LMS_OC
{
    public partial class ReturnForm : Form
    {
        public ReturnForm()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs() == false) return;

                Book ReturnedBook = new Book();
                ReturnedBook.BookID = int.Parse(txtBookID.Text);

                ReturnBook newReturn = new ReturnBook();
                newReturn.BookID = int.Parse(txtBookID.Text);
                newReturn.StudentID = int.Parse(txtStudentID.Text);
                newReturn.RDoR = DateTime.Parse(txtRDoR.Text);
                newReturn.LibrarianID = int.Parse(txtLibrarianID.Text);
                DataTable IstheBookIssued = ConnectionManager.GetTable("select * from BookIssue where studentID=('" + newReturn.StudentID + "') AND librarianID=('" + newReturn.LibrarianID + "') AND bookID=('" + newReturn.BookID + "') AND returnDate=('" + newReturn.RDoR + "')");
                // suppose to be comparing return date

                string ConditionQuery;




                if (IstheBookIssued.Rows.Count == 1)
                {
                    //Just in Time
                    newReturn.AddNewReturn();
                    ReturnedBook.updateBookQtyOnReturn();
                    newReturn.RemoveIssue();




                    MessageBox.Show("GoodJob, Returned just in Time.", "Book Return Complete.");
                    

                }
                else if (IstheBookIssued.Rows.Count == 0)
                {


                    DataTable IstheBookIssued2 = ConnectionManager.GetTable("select * from BookIssue where studentID=('" + newReturn.StudentID + "') AND librarianID=('" + newReturn.LibrarianID + "') AND bookID=('" + newReturn.BookID + "') ");
                    if (IstheBookIssued2.Rows.Count == 1)
                    {

                        ConditionQuery = "select * from BookIssue where studentID=('" + newReturn.StudentID + "') AND librarianID=('" + newReturn.LibrarianID + "') AND bookID=('" + newReturn.BookID + "') ";

                        SqlConnection conn = ConnectionManager.DBConnection();
                        SqlDataReader rdr = null;

                        try
                        {

                            conn.Open();
                            SqlCommand cmd = new SqlCommand(ConditionQuery, conn);
                            rdr = cmd.ExecuteReader();


                            while (rdr.Read())
                            {


                                IssueBook dor = new IssueBook();
                                dor.StudentID = int.Parse(rdr["studentID"].ToString());
                                dor.BookID = int.Parse(rdr["bookID"].ToString());
                                dor.LibrarianID = int.Parse(rdr["librarianID"].ToString());
                                dor.DoR = DateTime.Parse(rdr["returnDate"].ToString());



                                if (newReturn.RDoR > dor.DoR)
                                {
                                    MessageBox.Show(" Return Date of this book is OverDue." + Environment.NewLine + "Fine Requested to Pay : 50$.", "Sorry YOU ARE LATE");

                                    newReturn.AddNewReturn();
                                    ReturnedBook.updateBookQtyOnReturn();
                                    newReturn.RemoveIssue();
                                    MessageBox.Show(" Fine is been paid." + Environment.NewLine + "Have a good Day ", " Book Return Complete.");

                                    txtBookID.Text = "";
                                    txtStudentID.Text = "";

                                    txtRDoR.Text = "";
                                    txtLibrarianID.Text = "";
                                    txtBookID.Focus();








                                }
                                else
                                {
                                    newReturn.AddNewReturn();
                                    ReturnedBook.updateBookQtyOnReturn();
                                    newReturn.RemoveIssue();




                                    MessageBox.Show("GoodJob, Returned before the expected date of return.", "Book Return Complete.");
                                    
                                    txtBookID.Text = "";
                                    txtStudentID.Text = "";

                                    txtRDoR.Text = "";
                                    txtLibrarianID.Text = "";
                                    txtBookID.Focus();

                                }
                            }






                        }
                        catch
                        {

                            MessageBox.Show("Please make sure the follow details are inserted in the right format as in this example:" + Environment.NewLine + "BookiD : 1"  + Environment.NewLine + "Date of Return: MM-DD-YYYY" + Environment.NewLine + "LibrarianID : 2");

                        }


                    }
                    else
                    {
                        MessageBox.Show("None of the books borrowed corrispond to the details inserted." + Environment.NewLine + "Please Check Again The Details.", "Sorry NOT FOUND");
                    }
                }
                
                
            

            }
            catch 
            {
                MessageBox.Show("Please make sure the follow details are inserted in the right format as in this example:" + Environment.NewLine + "BookiD : 1" + Environment.NewLine + "Student ID : 1001"  + Environment.NewLine + "Date of Return: MM-DD-YYYY" + Environment.NewLine + "LibrarianID : 2");

            }
        }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBookID.Text = "";
            txtStudentID.Text = "";
           
            txtRDoR.Text = "";
            txtLibrarianID.Text = "";
            txtBookID.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
