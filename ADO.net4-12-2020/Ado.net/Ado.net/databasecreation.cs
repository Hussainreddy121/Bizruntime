using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Ado.net
{
    class databasecreation
    {
        public static void databasemethod()
        {
            string sc = "data source=.; database=sampledb; integrated security=SSPI";
            SqlConnection con = new SqlConnection(sc);
            string query = "create database testdb";
            SqlCommand command = new SqlCommand(query, con);
            try
            {
                con.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("database created succesfully");
            }
            catch(SqlException s)
            {
                Console.WriteLine(s);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
