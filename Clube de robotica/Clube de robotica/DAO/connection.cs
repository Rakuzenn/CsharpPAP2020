using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clube_de_robotica.DAO
{
    class connection
    {
        public static SqlConnection connect()
        {
            string Server = "DESKTOP-L3B0OFV";
            string connection = "Data Source=" + Server + ";Initial Catalog=Clube_informatica;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            return sqlcon;
        }

        public static void CRUD(SqlCommand com)
        {
            SqlConnection sqlcon = connect();
            com.Connection = sqlcon;
            com.ExecuteNonQuery();
            sqlcon.Close();
        }

        public static SqlDataReader Select(SqlCommand com)
        {
            SqlConnection sqlcon = connect();
            com.Connection = sqlcon;
            SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return dr;
        }
        public static SqlDataAdapter Selectt(SqlCommand com)
        {
            SqlConnection sqlcon = connect();
            com.Connection = sqlcon;
            SqlDataAdapter adpt = new SqlDataAdapter(com);
            return adpt;
        }
        public static String Email(String id)
        {
            SqlConnection sqlcon = connect();
            SqlCommand com = new SqlCommand();
            com.CommandText = @"select Email from utilizador where UserID = '" + id + "'";
            com.Connection = sqlcon;
            SqlDataReader dr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            dr.Read();
            return dr[0].ToString();
        }
        
    }

    class ID
    {
        private string id; // field

        public string IDs   // property
        {
            get { return id; }   // get method
            set { id = value; }  // set method
        }
    }

}
