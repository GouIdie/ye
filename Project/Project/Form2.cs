using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gouldie\source\repos\GouIdie\ye\Project\Project\ProjectData.accdb");
        public Login() 
        {
            InitializeComponent();
        }
        
        public void Form2_Load(object sender, EventArgs e)
        {
        }
        //----------------------------------------------------------------------------------------------
        public bool Uempty = true;
        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void UsernameTB_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTB.Text) || (Uempty == true))
            {
                UsernameTB.Clear();
            }

            UsernameTB.ForeColor = SystemColors.WindowText;
        }

        private void UsernameTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTB.Text))
            {

                UsernameTB.Text = "Username";
                UsernameTB.ForeColor = SystemColors.WindowFrame;
                Uempty = true;
            }
            else
            {
                PasswordTB.ForeColor = SystemColors.WindowText;
                Uempty = false;

            }
        }
        //----------------------------------------------------------------------------------------------
        public bool Pempty = true;
        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordTB_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTB.Text) || (Pempty == true))
            {
                PasswordTB.Clear();
            }
            PasswordTB.PasswordChar = '●';
            PasswordTB.ForeColor = SystemColors.WindowText;
        }

        private void PasswordTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTB.Text))
            {
                PasswordTB.PasswordChar = '\0';
                PasswordTB.Text = "Password";
                PasswordTB.ForeColor = SystemColors.WindowFrame;
                Pempty = true;
            }
            else
            {
                PasswordTB.ForeColor = SystemColors.WindowText;
                Pempty = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void SaveData_Click(object sender, EventArgs e)
        {
            string Username = UsernameTB.Text;
            string Password = PasswordTB.Text;
            OleDbDataAdapter UdataAdapter = new OleDbDataAdapter("select Username from Customer", conn);
            DataSet ds = new DataSet();
            UdataAdapter.Fill(ds, "Customer");
            bool Ufound = false;
            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                if (dataRow["Username"].ToString() == Username)
                {
                    Ufound = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (Ufound == false)
            {
                MessageBox.Show("Username not found");
            }
            else
            {
                conn.Open();
                OleDbDataReader reader = null;
                OleDbCommand cmd = new OleDbCommand("SELECT CustomerID,Username,Password FROM Customer WHERE Username ="+Username+"AND Password = "+Password+";", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    foreach (DataRow dataRow in ds.Tables[0].Rows)///////////////////////////
                {
                    MessageBox.Show(dataRow["Username"].ToString()+ dataRow["Password"].ToString());
                }
            }
        }
        //----------------------------------------------------------------------------------------------       
    }
}