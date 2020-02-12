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

namespace Project
{

    public partial class Signup : Form
    {
        // string FormID = string.Empty;
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gouldie\source\repos\GouIdie\ye\Project\Project\ProjectData.accdb");
        
        public Signup()
        {
            //conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gouldie\source\repos\GouIdie\ye\Project\Project\ProjectData.accdb");
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }


       // public Signup(string id)
        //{
           // this.FormID = id;
           // InitializeComponent();
        //}

        public void Simulation_Load(object sender, EventArgs e)
        {

        }

        public void panel1_Paint(object sender, PaintEventArgs e)
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
        public bool Uempty = true;
        private void UsernameTB_TextChanged(object sender, EventArgs e) //UsernameTB
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
        private void PasswordTB_TextChanged(object sender, EventArgs e) //PasswordTB
        {  
        }
        private void PasswordTB_Enter(object sender, EventArgs e) //PasswordTB
        {
            if (string.IsNullOrWhiteSpace(PasswordTB.Text) || (Pempty == true))
            {                
                PasswordTB.Clear();                
            }
            PasswordTB.PasswordChar = '●';
            PasswordTB.ForeColor = SystemColors.WindowText;
        }
        private void PasswordTB_Leave(object sender, EventArgs e) //PasswordTB
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
        public bool Eempty = true;
        private void EmailTB_TextChanged(object sender, EventArgs e) //EmailTB
        {
        }
        private void EmailTB_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailTB.Text) || (Eempty == true))
            {
                EmailTB.Clear();
            }

            EmailTB.ForeColor = SystemColors.WindowText;
        }

        private void EmailTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailTB.Text))
            {
                EmailTB.PasswordChar = '\0';
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
                if (Ulength < 3 || Ulength > 32)
                {
                    MessageBox.Show("Username is not long enough");
                }
                else
                {
                        OleDbDataAdapter UdataAdapter = new OleDbDataAdapter("select Username from Customer", conn);
                        DataSet ds = new DataSet();
                        UdataAdapter.Fill(ds, "Customer");
                        bool Ufound=false;
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
                    if (Ufound == true)
                    {
                        MessageBox.Show("Username taken");
                    }
                    else 
                    { 
                            
                        string Password = PasswordTB.Text;

                        Regex hasNumber = new Regex(@"[0-9]+");
                        Regex hasUpperChar = new Regex(@"[A-Z]+");
                        Regex hasMiniMaxChars = new Regex(@".{8,15}");
                        Regex hasLowerChar = new Regex(@"[a-z]+");
                        Regex hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
                        Regex hasSpeech = new Regex(@"[]");/////////////

                        if (string.IsNullOrWhiteSpace(Password))
                        {
                            MessageBox.Show("Password should not be empty");
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
                        else
                        {

                            string Email = EmailTB.Text;
                            Regex ValEmail = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                            if (!ValEmail.IsMatch(Email))
                            {
                                MessageBox.Show("Invalid email");
                            }
                            else
                            {

                                OleDbDataAdapter EdataAdapter = new OleDbDataAdapter("select Email from Customer", conn);                               
                                EdataAdapter.Fill(ds, "Customer");
                                bool Efound = false;
                                foreach (DataRow dataRow in ds.Tables[0].Rows)
                                {
                                    if (dataRow["Email"].ToString() == Email)
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


                                OleDbCommand cmd = new OleDbCommand("INSERT into Customer (Username,[Password],Email) Values(@Username, @Password, @Email)");
                                cmd.Connection = conn;
                 
                                conn.Open();
                            


                                if (conn.State == ConnectionState.Open)
                                {

                                    cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = Username;
                                    cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = Password;
                                    cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = Email;
                                    try
                                    {
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Data Added");
                                        conn.Close();
                                    }
                                    catch (OleDbException ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                        conn.Close();
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
        //----------------------------------------------------------------------------------------------
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select Username from Customer", conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Customer");
            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                listBox1.Items.Add(dataRow["Username"].ToString());
            }
            conn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
