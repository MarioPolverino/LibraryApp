using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LMS_OC
{

    class IssueBook
    {
        
        public int BookID { get; set; }
        public int StudentID { get; set; }
        public DateTime DoI { get; set; }
        public DateTime DoR { get; set; }
        public int LibrarianID { get; set; }




        public int AddNewIssue()
        {
           
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into BookIssue (bookID,studentID,issueDate,returnDate,librarianID) values('" + BookID + "','" + StudentID + "','" + DoI + "','" + DoR + "','" + LibrarianID + "')";
            cmd.Connection = con;
            con.Open();
            int recordInserted = cmd.ExecuteNonQuery();
            con.Close();
            return recordInserted;
        }
    }


}
