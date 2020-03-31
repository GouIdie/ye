using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
namespace Project
{
    public partial class Home : Form
    {
        public delegate void MoveWin();
        public event MoveWin WinWasMoved;

        public delegate void FormClose();
        public event FormClose BtnPress;

        private int CusD;
        private OleDbConnection Conn;

        public MySub MySub;

        public Home(int Cid,OleDbConnection Con)
        {
            InitializeComponent();
            CusD = Cid;
            Conn = Con;
            MySub = new MySub(CusD,Conn);
        }
       
        private void Form4_Load(object sender, EventArgs e)
        {
            Conn.Open();
            OleDbDataReader reader;
            OleDbCommand cmd = new OleDbCommand("SELECT Username FROM CUSTOMER WHERE CustomerID = " + CusD + ";", Conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            label2.Text = ("- "+reader[0].ToString());
            Conn.Close();

            MySub.TopLevel = false; //Allows the Home Form to be docked
            panel2.Controls.Add(MySub); //Adds the form to the Panel
            MySub.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //removes any border
            MySub.Dock = DockStyle.Fill; //Docks the Form to the panel so it is aligned and fills the panel
            MySub.Show(); //Shows the Signup Form to the user   
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

         private void panel1_MouseMove(object sender, MouseEventArgs e)
         {

            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WinWasMoved();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnPress();
        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }

        private void MySubscriptions_Click(object sender, EventArgs e)
        {
            MySub.Show();
        }

        private void AddSubscription_Click(object sender, EventArgs e)
        {
            MySub.Hide();
        }

    }
}
