using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Project
{

    public partial class Signup : Form
    {

        public delegate void ClickButton();  // Points towards the ButtonWasClicked event in the Main Form
        public event ClickButton ButtonWasClicked;
        public int getID; // Variable to get the users ID once they have signed in

        private OleDbConnection Conn;

        public Signup(OleDbConnection Con)
        {
            InitializeComponent();
            Conn = Con; // The connection string is passed from the Main form
        }

        public void Simulation_Load(object sender, EventArgs e)
        {

        }

        public void Panel1_Paint(object sender, PaintEventArgs e)
        {
  
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------
        public bool Uempty = true; // On startup, The username text box is empty
        private void UsernameTB_TextChanged(object sender, EventArgs e) //UsernameTB
        {   
        }
        private void UsernameTB_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTB.Text) || (Uempty == true)) // If the textbox is empty when leaving the textbox, It is filled with the original instruction
            {
                UsernameTB.Clear();
            }
        
            UsernameTB.ForeColor = SystemColors.WindowText;
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
        private void PasswordTB_TextChanged(object sender, EventArgs e) //PasswordTB
        {  
        }
        private void PasswordTB_Enter(object sender, EventArgs e) //PasswordTB
        {
            if (string.IsNullOrWhiteSpace(PasswordTB.Text) || (Pempty == true)) // If there is no text in the textbox or the inital message is there, the text box is cleared
            {                
                PasswordTB.Clear();                
            }
            PasswordTB.PasswordChar = '●'; // The password characters are set to hide the data as the user inputs it
            PasswordTB.ForeColor = SystemColors.WindowText;
        }
        private void PasswordTB_Leave(object sender, EventArgs e) //PasswordTB
        {
            if (string.IsNullOrWhiteSpace(PasswordTB.Text))
            {
                PasswordTB.PasswordChar = '\0'; // If the textbox is empty when leaving the textbox, It is filled with the original instruction
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
       
        public bool Eempty = true; // On startup, The Email text box is empty
        private void EmailTB_TextChanged(object sender, EventArgs e) //EmailTB
        {
        }
        private void EmailTB_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailTB.Text) || (Eempty == true)) // If there is no text in the textbox or the inital message is there, the text box is cleared
            {
                EmailTB.Clear();
            }

            EmailTB.ForeColor = SystemColors.WindowText;
        }

        private void EmailTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailTB.Text)) // If the textbox is empty when leaving the textbox, It is filled with the original instruction
            {
                EmailTB.Text = "Email";
                EmailTB.ForeColor = SystemColors.WindowFrame;
                Eempty = true;
            }
            else
            {
                EmailTB.ForeColor = SystemColors.WindowText;
                Eempty = false;

            }
        }
        
        //----------------------------------------------------------------------------------------------

        private void SaveData_Click(object sender, EventArgs e)
        {
            {               
                string Username = UsernameTB.Text;
                int Ulength = Username.Length;
                if (Ulength < 3 || Ulength > 32) // The username length is validated
                {
                    MessageBox.Show("Username shoule be between 3 and 32 characters long");
                }
                else
                {
                        OleDbDataAdapter UdataAdapter = new OleDbDataAdapter("select Username from Customer", Conn); // All usernames are selected from the table
                        DataSet ds = new DataSet();
                        UdataAdapter.Fill(ds, "Customer");
                        bool Ufound=false;
                    foreach (DataRow dataRow in ds.Tables[0].Rows)
                    {
                        if (dataRow["Username"].ToString() == Username) // The username is checked to make sure it does not already exist
                        {                           
                            Ufound = true;
                            break;

                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (Ufound == true)
                    {
                        MessageBox.Show("Username taken");
                    }
                    else
                    {
                        //----------------------------------------------------------------------------------------------
                        // The password is validated to be of the required complexity
                        string Password = PasswordTB.Text;

                        Regex hasNumber = new Regex(@"[0-9]+"); 
                        Regex hasUpperChar = new Regex(@"[A-Z]+");
                        Regex hasMiniMaxChars = new Regex(@".{8,15}");
                        Regex hasLowerChar = new Regex(@"[a-z]+");
                        Regex hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
                        Regex hasSpeech = new Regex(@"[""']");

                        if (string.IsNullOrWhiteSpace(Password))
                        {
                            MessageBox.Show("Password should not be empty");
                        }
                        else if (hasSpeech.IsMatch(Password))
                        {
                            MessageBox.Show("Password can not contain certain characters");

                        }
                        else if (!hasLowerChar.IsMatch(Password))
                        {
                            MessageBox.Show("Password should contain at least one lower case letter");

                        }
                        else if (!hasUpperChar.IsMatch(Password))
                        {
                            MessageBox.Show("Password should contain at least one upper case letter");

                        }
                        else if (!hasMiniMaxChars.IsMatch(Password))
                        {
                            MessageBox.Show("Password should not be less than or greater than 12 characters");

                        }
                        else if (!hasNumber.IsMatch(Password))
                        {
                            MessageBox.Show("Password should contain at least one numeric value");

                        }

                        else if (!hasSymbols.IsMatch(Password))
                        {
                            MessageBox.Show("Password should contain at least one special case characters");

                        }
                        //----------------------------------------------------------------------------------------------
                        else
                        {
                            //----------------------------------------------------------------------------------------------
                            // The password is hashed and stored with the salt
                            byte[] salt;
                            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                            var pbkdf2 = new Rfc2898DeriveBytes(Password,salt,10000);
                            byte[] hash = pbkdf2.GetBytes(20);
                            byte[] hashBytes = new byte[36];
                            Array.Copy(salt, 0, hashBytes, 0, 16);
                            Array.Copy(hash, 0, hashBytes, 16, 20);
                            string Salty = Convert.ToBase64String(salt);
                            string SavedPassword = Convert.ToBase64String(hashBytes);

                            //----------------------------------------------------------------------------------------------

                            string Email = EmailTB.Text; // The email is validated be in the correct format
                            Regex ValEmail = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                            if (!ValEmail.IsMatch(Email))
                            {
                                MessageBox.Show("Invalid email");
                            }
                            else
                            {

                                OleDbDataAdapter EdataAdapter = new OleDbDataAdapter("select Email from Customer", Conn); // Selects all email from the table                               
                                EdataAdapter.Fill(ds, "Customer");
                                bool Efound = false;
                                foreach (DataRow dataRow in ds.Tables[0].Rows)
                                {
                                    if (dataRow["Email"].ToString() == Email) // Checks the email is not already in use
                                    {
                                        Efound = true;
                                        break;

                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                                if (Efound == true)
                                {
                                    MessageBox.Show("Email in use");                                  
                                }
                                else 
                                { 

                                 // Data is inputted into the table
                                OleDbCommand cmd = new OleDbCommand("INSERT into Customer (Username,[Password],Email) Values(@Username, @SavedPassword, @Email)"); 
                                cmd.Connection = Conn;
                 
                                Conn.Open();
                            


                                if (Conn.State == ConnectionState.Open)
                                {

                                    cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = Username;
                                    cmd.Parameters.Add("@SavedPassword", OleDbType.VarChar).Value = SavedPassword;
                                    cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = Email;
                                    
                                        try
                                        {
                                            cmd.ExecuteNonQuery();                                            
                                            MessageBox.Show("Data Added");
                                            Conn.Close();

                                            Conn.Open();
                                            OleDbDataReader reader;
                                            OleDbCommand Getid = new OleDbCommand("SELECT CustomerID FROM CUSTOMER WHERE Username = '" + Username + "';", Conn);
                                            reader = Getid.ExecuteReader();
                                            reader.Read();
                                            getID = Convert.ToInt32(reader[0].ToString()); // The customerID is stored as a variable
                                            Conn.Close();

                                            ButtonWasClicked(); // Calls the subroutine

                                        }
                                    catch (OleDbException ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                        Conn.Close();
                                    }


                                    }
                                else
                                {
                                    MessageBox.Show("Connection Failed");
                                }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
