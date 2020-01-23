using System;
using System.Data;
using System.Data.OleDb;
namespace WebApplication3
{
    public partial class Home : System.Web.UI.Page
    {
        public OleDbConnection con;
        public OleDbDataAdapter dad;
        public OleDbCommand com;
        public DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            retrieveData();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            Server.MapPath("RevisionSubs.accdb") + "; Persist Security Info=False");
            con.Open();
            String data1;
            string product = TextBox1.Text;
            string stock = TextBox3.Text;
            data1 = "insert into Table1(Procduct,stock) values(" +"'"+ product + "','" + stock + "',')";
            com = new OleDbCommand(data1, con);
            com.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Data Has Been Saved";
            TextBox1.Text = "";
            TextBox3.Text = "";
            retrieveData();
        }
        private void retrieveData()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
            Server.MapPath("RevisionSubs.accdb") + "; Persist Security Info=False");
            con.Open();
            dad = new OleDbDataAdapter("select * from Table1", con);
            ds = new DataSet();
            dad.Fill(ds);
            //GridView1.DataSource = ds;
            //GridView1.DataBind();
        }
    }
}