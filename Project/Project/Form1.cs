﻿using System;
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

    public partial class Simulation : Form
    {
        string FormID = string.Empty;
        OleDbConnection connection;

        public Simulation()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\thomas.gould\source\repos\GouIdie\ye\Project\Project\ProjectData.accdb");
            InitializeComponent();
        }

        public Simulation(string id)
        {
            this.FormID = id;
            InitializeComponent();
        }

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
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.ShowDialog(); // Shows Form2
            //WindowState = FormWindowState.Maximized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //CustTB
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e) //UsernameTB
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) //PasswordTB
        {

        }
        private void textBox3_Entering(object sender, EventArgs e) //PasswordTB
        {
            PasswordTB.Clear();
            PasswordTB.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox4_TextChanged(object sender, EventArgs e) //EmailTB
        {
        }


        private void SaveData_Click(object sender, EventArgs e)
        {
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\thomas.gould\source\repos\GouIdie\ye\Project\Project\ProjectData.accdb";


                string Username = UsernameTB.Text;//////////////////////////
                int Ulength = Username.Length;
                if (Ulength < 3 || Ulength > 32)
                {
                    MessageBox.Show("Username is not long enough");
                }
                else
                {
                    string Password = PasswordTB.Text;

                    Regex hasNumber = new Regex(@"[0-9]+");
                    Regex hasUpperChar = new Regex(@"[A-Z]+");
                    Regex hasMiniMaxChars = new Regex(@".{8,15}");
                    Regex hasLowerChar = new Regex(@"[a-z]+");
                    Regex hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

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
                            MessageBox.Show("Email is bad");
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select Username from Customer", connection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Customer");
            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                listBox1.Items.Add(dataRow["Username"].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
