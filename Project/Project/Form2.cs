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
using System.Configuration;

namespace Project
{
    public partial class Login : Form
    {
        public OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gouldie\source\repos\GouIdie\ye\Project\Project\ProjectData.accdb"); // Connection string to connect to database
        public delegate void ClickButton(); 
        public event ClickButton ButtonWasClicked; // Points towards the ButtonWasClicked event in the Main Form
        public int getID; // Variable to get the users ID once they have signed in

        public Login() 
        {
            InitializeComponent();        
        }
     
        public void Form2_Load(object sender, EventArgs e)
        {
            UsernameTB.ForeColor = SystemColors.WindowFrame;
        }
        //----------------------------------------------------------------------------------------------
        public bool Uempty = true; // On startup, The username text box is empty
        
        private void UsernameTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void UsernameTB_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTB.Text) || (Uempty == true)) // If there is no text in the textbox or the inital message is there, the text box is cleared
            {
                UsernameTB.Clear();
            }

            UsernameTB.ForeColor = SystemColors.WindowText; // Sets the text colour to windowText

        }

        private void UsernameTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTB.Text)) // If the textbox is empty when leaving the textbox, It is filled with the original instruction
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
        public bool Pempty = true; // On startup, The password text box is empty


        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordTB_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTB.Text) || (Pempty == true)) // If there is no text in the textbox or the inital message is there, the text box is cleared
            {
                PasswordTB.Clear();
            }
            PasswordTB.PasswordChar = '●'; // The password characters are set to hide the data as the user inputs it
            PasswordTB.ForeColor = SystemColors.WindowText;
        }

        private void PasswordTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTB.Text)) // If the textbox is empty when leaving the textbox, It is filled with the original instruction
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
            OleDbDataAdapter UdataAdapter = new OleDbDataAdapter("select Username from Customer", conn); // All current usernames are selected from the Customer table
            DataSet ds = new DataSet();
            UdataAdapter.Fill(ds, "Customer");
            bool Ufound = false;
            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                if (dataRow["Username"].ToString() == Username) // Checks if the username exists
                {
                    Ufound = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (Ufound == false) // If the username is not in the table then the user is notified
            {
                MessageBox.Show("Username not found");
            }
            else
            {
                conn.Open();
                OleDbDataReader reader;
                OleDbCommand cmd = new OleDbCommand("SELECT Password, CustomerID FROM CUSTOMER WHERE Username = '"+Username +"';",conn); // Selects the password and CustomerID of the user
                reader = cmd.ExecuteReader();
                reader.Read();

                //----------------------------------------------------------------------------------------------
                
                string hashedP = reader[0].ToString(); // The hashed password is read from the table and converted to a byte array               
                byte[] hashBytes = Convert.FromBase64String(hashedP);
                byte[] salt = new byte[16];
                Array.Copy(hashBytes, 0, salt, 0, 16);
                var pbkdf2 = new Rfc2898DeriveBytes(Password,salt,10000); // The entered password is hashed with the same salt
                byte[] hash = pbkdf2.GetBytes(20); 
                //----------------------------------------------------------------------------------------------                                  

                bool pass = true;
                for (int i=0; i<20; i++) // The byte arrays are checked against each other to determine if the passwords match
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        pass = false;
                    }
                }
                if (pass == true)
                {
                    getID = Convert.ToInt32(reader[1].ToString()); // The users ID is stored
                    conn.Close();
                    ButtonWasClicked(); // Subroutine is called             
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