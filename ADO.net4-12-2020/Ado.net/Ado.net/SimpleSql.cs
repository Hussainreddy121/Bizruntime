using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace Ado.net
{
    class SimpleSql
    {
        public void serverpage_load()
        {
            String sc = "data source=.; database=sampledb; integrated security=SSPI";
            SqlConnection con = new SqlConnection(sc);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from students", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("id " + reader[0].ToString() + " name " + reader[1].ToString() + " marks " + reader[2].ToString() + " location " + reader[3].ToString());
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
               
            }

        }
    }
}
