using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace WebApplication3

{
    public partial class Home : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            OleDbConnection conn = new
         OleDbConnection
            {
                // TODO: Modify the connection string and include any
                // additional required properties for your database.
                ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data Source=C:\Users\thomas.gould\source\repos\GouIdie\ye\WebApplication3\RevisionSubs.accdb;"
            };
            try
            {
                conn.Open();
                //Use a variable to hold the SQL statement.
                string selectString = "SELECT ID, Name1 from Table1";
                //Create an OleDbCommand object
                OleDbCommand cmd = new OleDbCommand(selectString, conn);

                //Send the CommandText to the connection, and then build an OleDbDataReader
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string record_data = reader["ID"].ToString() + " | " + reader["Name1"].ToString();

                }
            }


            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}