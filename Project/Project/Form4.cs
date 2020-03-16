﻿using System;
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
        public Home(int Cid,OleDbConnection Con)
        {
            InitializeComponent();
            CusD = Cid;
            Conn = Con;           
        }
       
        private void Form4_Load(object sender, EventArgs e)
        {
            Conn.Open();
            OleDbDataReader reader;
            OleDbCommand cmd = new OleDbCommand("SELECT Username FROM CUSTOMER WHERE CustomerID = " + CusD + ";", Conn);
            reader = cmd.ExecuteReader();
            reader.Read();
            label2.Text = reader[0].ToString();
            Conn.Close();
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnPress();
        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
