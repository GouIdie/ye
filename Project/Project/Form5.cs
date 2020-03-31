using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Project
{
    public partial class MySub : Form
    {
        private OleDbConnection Conn;
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        private int CusD;
        public MySub(int Cid,OleDbConnection Con)
        {
            InitializeComponent();
            Conn = Con;
            CusD = Cid;
            cmd = new OleDbCommand("", Conn);
        }
        
        private void Form5_Load(object sender, EventArgs e)
        {
            LoadData();
            Conn.Open();
        }
        private void LoadData()
        {
            listBox1.Items.Clear();
           
            try
            {
                string query = "SELECT SubscriptionName FROM Subscriptions,CustSub WHERE CustSub.CustomerID="+CusD+"And CustSub.SubscriptionID = Subscriptions.SubscriptionID";
                cmd.CommandText = query;
                Conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listBox1.Items.Add(dr[0].ToString());
                
                    }
                }
                dr.Close();
                Conn.Close();

            }
            catch (Exception e)
            {
                Conn.Close();
                MessageBox.Show(e.Message.ToString());
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
