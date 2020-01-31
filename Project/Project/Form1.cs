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
                    MessageBox.Show(ex.Message);
                }
                string Password = PasswordTB.Text;
                string Email = EmailTB.Text;

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

    }
}
