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
        public MySub(int Cid,OleDbConnection Con)
        {
            InitializeComponent();
            Conn = Con;
            CusD = Cid;
            cmd = new OleDbCommand("", Conn);
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
                string query = "SELECT SubscriptionName FROM Subscriptions,CustSub WHERE CustSub.CustomerID=" + CusD + "And CustSub.SubscriptionID = Subscriptions.SubscriptionID";
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
            reader = null;
            string query = "SELECT SubscriptionName,Description,DateAdded FROM Subscriptions WHERE SubscriptionName ='"+listBox1.Text+"'";
            cmd.CommandText = query;
            Conn.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            try { 
            richTextBox2.Text = reader[0].ToString();
            richTextBox3.Text = reader[1].ToString();
            richTextBox1.Text = (reader[2].ToString()).Substring(0, 8);
            
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
            richTextBox1.Enabled = true;
            richTextBox2.Enabled = true;
            richTextBox3.Enabled = true;
            richTextBox4.Enabled = true;
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
                MessageBox.Show("This is good");
            }
            else
            {
                MessageBox.Show("Date must be in the format dd/mm/yy and must be a valid date");
            }
        }
    }
}
