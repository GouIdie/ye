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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private const int WM_NCLBUTTONDBLCLK = 0x00A3;
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
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                m.Result = IntPtr.Zero;
                return;
            }


            base.WndProc(ref m);
        }
        Signup objForm = new Signup();
        Login objForm1 = new Login();
        Form4 objForm2 = new Form4();
        private void Form3_Load(object sender, System.EventArgs e)
        {
            
            button3.Hide();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();

            objForm2.TopLevel = false;
            panel3.Controls.Add(objForm2);
            objForm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm2.Dock = DockStyle.Fill;
            objForm2.Show();
            panel3.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {         
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //----------------------------------------------------------------------------------------------
        
        private void button2_Click(object sender, EventArgs e)
        {          
           objForm.Hide();
           button3.Show();
           button2.Hide();
           objForm1.TopLevel = false;
           panel1.Controls.Add(objForm1);
           objForm1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           objForm1.Dock = DockStyle.Fill;
           objForm1.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objForm1.Hide();
            button2.Show();
            button3.Hide();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }


        //----------------------------------------------------------------------------------------------
    }
}
