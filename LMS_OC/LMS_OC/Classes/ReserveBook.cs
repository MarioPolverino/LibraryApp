using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LMS_OC
{
    class ReserveBook
    {
       
        public int BookID { get; set; }
        public int StudentID { get; set; }
        public DateTime RSD { get; set; }
        public int LibrarianID { get; set; }

        public int AddNewReserve()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into BookReserve (bookID,studentID,reserveDate,librarianID) values('" + BookID + "','" + StudentID + "','" + RSD + "','" + LibrarianID + "')";
            cmd.Connection = con;
            con.Open();
            int recordInserted = cmd.ExecuteNonQuery();
            con.Close();
            return recordInserted;
        }
    }
}
