using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Ado.net
{
    class AlterDatabase
    {
        public static void changedatabase()
        {
            string sc = "data source=.; database=sampledb; integrated security=SSPI";
            SqlConnection con = new SqlConnection(sc);
            String query = "Alter database testdb modify name=customdb";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("database name has changed");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

         public  void createTable()
        {
            string sc = "data source=.; database=customdb; integrated security=SSPI";
            SqlConnection con = new SqlConnection(sc);
            String query = "create table person(id int not null, firstname varchar(20), lasname varchar(20), mobileno int, location varchar(30))";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table created succesfully");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
