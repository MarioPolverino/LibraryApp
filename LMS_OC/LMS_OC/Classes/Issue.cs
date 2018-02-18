using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LMS_OC
{
    public class Issue
    {
        //Set-Get properties
        public int IssueID { get; set; }

        public int BookID { get; set; }

        public int StudentID { get; set; }

        public DateTime DoI { get; set; }
        public DateTime DoR { get; set; }

        public int LibrarianID { get; set; }


        //Declaring Default Constructor
        public Issue() { }

        //Parameterised Constructor
        public Issue(int issueid, int bookid, int studentid, DateTime doi, DateTime dor , int librarianid)
        {
           IssueID = issueid;
            BookID = bookid;
            StudentID = studentid;
            DoI= doi;
            DoR = dor;
            LibrarianID = librarianid;
            
        }

        public int AddnewIssue()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into BookIssue (issueID,bookID,studentID,issueDate,returnDate,librarianID) values('" + IssueID + "'," + BookID + "," + StudentID + ",'" + DoI + "'," + DoR + "," + LibrarianID + ")";
            cmd.Connection = con;
            con.Open();
            int recordInserted = cmd.ExecuteNonQuery();
            con.Close();
            return recordInserted;
        }
    }
}
