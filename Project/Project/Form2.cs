using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
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
            Signup.LS = false;
        }
        //----------------------------------------------------------------------------------------------

    }
}
