using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Ado.net
{
    class Insertiondata
    {
        public void insertion()
        {
            SqlConnection connection = new SqlConnection("data source=.; database=customdb; integrated security=SSPI");
            string sqlquery = "insert into person(id, firstname, lasname, mobileno, location) values(2, 'rahul', 'dev', 78969, 'bangalore')" + "," +
                "(21, 'virat', 'dev', 785669, 'mumbai')" + "," +
                "(1, 'mahi', 'bhay', 90876, 'hyd') " + "," +
                "(13, 'hussain', 'reddy', 8907, 'andhra')";
            SqlCommand command = new SqlCommand(sqlquery, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("inserted succesfully");

            }
            catch(SqlException x)
            {
                Console.WriteLine(x);
            }
            finally
            {
                if(connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
