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
using System.Text.RegularExpressions;

namespace Project
{
    public partial class MySub : Form
    {
        private OleDbConnection Conn;
        private OleDbDataReader reader;
        private OleDbCommand cmd;
        private int CusD;
        int SubID;
        bool Dataloaded;
        string SubName;
        string Notes;
        string DateAdded;
        public MySub(int Cid,OleDbConnection Con)
        {
            InitializeComponent();
            Conn = Con;
            CusD = Cid;
            cmd = new OleDbCommand("", Conn);
            Dataloaded = false;
            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;
            richTextBox3.Enabled = false;
            richTextBox4.Enabled = false;
           
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
                string query = "SELECT Nickname FROM Subscriptions,CustSub WHERE CustSub.CustomerID=" + CusD + "And CustSub.SubscriptionID = Subscriptions.SubscriptionID";
                cmd.CommandText = query;
                Conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader[0].ToString());                                            
                    }
                }
                reader.Close();
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
        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Refresh();
            //-----------------------------------------------------------------
            reader = null;
            string query = "SELECT Subscriptions.SubscriptionName,CustSub.Notes,CustSub.DateAdded,Subscriptions.SubscriptionID,CustSub.Nickname FROM Subscriptions,CustSub WHERE CustSub.CustomerID=" + CusD + "And CustSub.SubscriptionID = Subscriptions.SubscriptionID And CustSub.Nickname='"+listBox1.Text+"'";
            cmd.CommandText = query;
            Conn.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            try {
                label6.Text = reader[0].ToString();
                
                richTextBox3.Text = reader[1].ToString();
                richTextBox1.Text = (reader[2].ToString()).Substring(0, 8);
                SubID = Convert.ToInt32(reader[3].ToString());
                richTextBox2.Text = reader[4].ToString();

                SubName = reader[0].ToString();
                Notes = reader[1].ToString();
                DateAdded = reader[2].ToString();

                Dataloaded = true;
            }
            catch
            {               
            }
            Conn.Close();           
        }

        private void label2_Click(object sender, EventArgs e)
        {    

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (Dataloaded == true)
            { 
            richTextBox1.Enabled = true;
            richTextBox2.Enabled = true;
            richTextBox3.Enabled = true;
            richTextBox4.Enabled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        protected bool CheckDate(String date)
        {
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }

        Regex DateLength = new Regex(@"^\d{2}\/\d{2}\/\d{2}$");
        
        private void button2_Click(object sender, EventArgs e)
        {

            bool date = CheckDate(richTextBox1.Text);
            if ((date == true) && (DateLength.IsMatch(richTextBox1.Text)))
            {
                if (string.IsNullOrWhiteSpace(richTextBox1.Text))
                {
                    richTextBox1.Text = DateAdded;
                }
                if (string.IsNullOrWhiteSpace(richTextBox2.Text))
                {
                    richTextBox2.Text = SubName;
                }
                if (string.IsNullOrWhiteSpace(richTextBox3.Text))
                {
                    richTextBox3.Text = Notes;
                }

                reader = null;
                string query = "UPDATE Subscriptions SET SubscriptionName='"+richTextBox2.Text+"' WHERE SubscriptionID ="+SubID+";";
                cmd.CommandText = query;
                Conn.Open();
                reader = cmd.ExecuteReader();
                Conn.Close();

                Conn.Open();
                reader = null;
                query = "UPDATE CustSub SET Notes = '" + richTextBox3.Text + "' WHERE SubscriptionID =" + SubID + " AND CustomerID=" + CusD + ";";
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                Conn.Close();

                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
                richTextBox3.Enabled = false;
                richTextBox4.Enabled = false;

            }
            else
            {
             MessageBox.Show("Date must be in the format dd/mm/yy and must be a valid date");              
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
