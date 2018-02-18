using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LMS_OC
{
    class ReturnBook
    {
        public int BookID { get; set; }
        public int StudentID { get; set; }
        public DateTime RDoR { get; set; }
        public int LibrarianID { get; set; }

        public int AddNewReturn()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into BookReturn (bookID,studentID,returnDate,librarianID) values('" + BookID + "','" + StudentID + "','" + RDoR + "','" + LibrarianID + "')";
            cmd.Connection = con;
            con.Open();
            int recordInserted = cmd.ExecuteNonQuery();
            con.Close();
            return recordInserted;
        }

        public int RemoveIssue()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from BookIssue where studentID=('" + StudentID + "') AND librarianID=('" + LibrarianID + "') AND bookID=('" + BookID + "')";
            cmd.Connection = con;
            con.Open();
            int recordInserted = cmd.ExecuteNonQuery();
            con.Close();
            return recordInserted;
        }
        
    }
}
