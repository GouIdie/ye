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
    public partial class Addsub : Form
    {
        private int CusD;
        private OleDbConnection Conn;
        public Addsub(int Cid, OleDbConnection Con)
        {
            InitializeComponent();
            CusD = Cid;
            Conn = Con;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
