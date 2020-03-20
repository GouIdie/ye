using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{
    public partial class Login : Form
    {
        public OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gouldie\source\repos\GouIdie\ye\Project\Project\ProjectData.accdb");

        public delegate void ClickButton();
        public event ClickButton ButtonWasClicked;
        public int getID;

        // public delegate void ID ();
        // public event ID SendID;

        public Login() 
        {
            InitializeComponent();
            
           
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            UsernameTB.ForeColor = SystemColors.WindowFrame;
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
        //----------------------------------------------------------------------------------------------
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
                OleDbDataReader reader;
                OleDbCommand cmd = new OleDbCommand("SELECT Password, CustomerID FROM CUSTOMER WHERE Username = '"+Username +"';",conn);
                reader = cmd.ExecuteReader();
                reader.Read();

                string hashedP = reader[0].ToString();               
            
                byte[] hashBytes = Convert.FromBase64String(hashedP);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(Password,salt,10000);
                byte[] hash = pbkdf2.GetBytes(20); //https://medium.com/@mehanix/lets-talk-security-salted-password-hashing-in-c-5460be5c3aae
               

                bool pass = true;
                for (int i=0; i<20; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        pass = false;
                    }
                }
                if (pass == true)
                {
                    getID = Convert.ToInt32(reader[1].ToString());
                    // SendID();
                    conn.Close();
                    ButtonWasClicked();                                                       
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
               
                
                
                conn.Close();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //----------------------------------------------------------------------------------------------       
    }
}