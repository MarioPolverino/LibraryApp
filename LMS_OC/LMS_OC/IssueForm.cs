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
    public partial class IssueForm : Form
    {
        public IssueForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IssueForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs() == false) return;
 
                    Book issuedBook = new Book();
                    issuedBook.BookID = int.Parse(txtBookID.Text);
                DataTable BookRequired = ConnectionManager.GetTable("select noOfAvailableBooks from Book where bookID=("+int.Parse(txtBookID.Text)+")");

                

                IssueBook newIssue = new IssueBook();
                newIssue.BookID = int.Parse(txtBookID.Text);
                newIssue.StudentID = int.Parse(txtStudentID.Text);
                newIssue.DoI = DateTime.Parse(txtDoI.Text);
                newIssue.DoR = DateTime.Parse(txtDoR.Text);
                newIssue.LibrarianID = int.Parse(txtLibrarianID.Text);

                DataTable BookAlreadyIssued = ConnectionManager.GetTable("select * from BookIssue where bookID=(" + int.Parse(txtBookID.Text) + ") and studentID=(" + int.Parse(txtStudentID.Text) + ")");

                if (BookAlreadyIssued.Rows.Count >= 1)
                {
                    MessageBox.Show("This student is currently in possess of one of this book already." + Environment.NewLine + "Please check again that all the Details inserted are correct.","Sorry NOT ALLOWED");
                    txtBookID.Focus();

                }
                else if(newIssue.DoR <= newIssue.DoI)
                {
                    MessageBox.Show(" Date  inserted must be wrong, as return date is previous or same to the date of issue.","Sorry NOT POSSIBLE");
                }
                else if (BookAlreadyIssued.Rows.Count == 0 )
                {
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


                            Book booksDetails = new Book();
                            booksDetails.AvailableBooks = int.Parse(rdr["noOfAvailableBooks"].ToString());

                            if (booksDetails.AvailableBooks <= 0)
                            {
                                DialogResult dialogResult = MessageBox.Show("Book Requested is not available at moment." + Environment.NewLine + "Do you want Reserve this book?", "Sorry,Not Available.", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    this.Hide();
                                    ReserveForm Procede = new ReserveForm();
                                    Procede.Show();



                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    txtBookID.Text = "";
                                    txtStudentID.Text = "";
                                    txtDoI.Text = "";
                                    txtDoR.Text = "";
                                    txtLibrarianID.Text = "";
                                    txtBookID.Focus();

                                    MessageBox.Show("Issue Resetted.");
                                }
                            }
                            else
                            {


                                newIssue.AddNewIssue();
                                issuedBook.updateBookQtyOnIssue();


                                MessageBox.Show("Book Issue Complete.");
                            }
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Please make sure the follow details are inserted in the right format as in this example:" + Environment.NewLine + "BookiD : 1" + Environment.NewLine + "Student ID : 1001" + Environment.NewLine + "Date of Issue: MM-DD-YYYY" + Environment.NewLine + "Date of Return: 12-31-2018" + Environment.NewLine + "LibrarianID : 2");

                    }

                }

                
            }catch  
            {
                MessageBox.Show("Please make sure the follow details are inserted in the right format as in this example:" + Environment.NewLine + "BookiD : 1" + Environment.NewLine + "Student ID : 1001" + Environment.NewLine + "Date of Issue: DD-MM-YYYY" + Environment.NewLine + "Date of Return: 31-12-2018" + Environment.NewLine + "LibrarianID : 2");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBookID.Text = "";
            txtStudentID.Text = "";
            txtDoI.Text = "";
            txtDoR.Text = "";
            txtLibrarianID.Text = "";
            txtBookID.Focus();
        }
    }
}
