using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Main : Form
    {       
        Signup objForm = new Signup();

        Login objForm1 = new Login();

        public static int ID;

      //  Form4 objForm2 = new Form4();
        


        public Main()
        {
            InitializeComponent();
            
            objForm1.ButtonWasClicked += new Login.ClickButton(objForm1_ButtonWasClicked);
           
            
            //objForm1.SendID += new Login.ID(objForm1_SendID);
            
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        void objForm2_BtnPress()
        {
            this.Close();
        }

        void objForm2_WinWasMoved()
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

       // void objForm1_SendID()
       

        void objForm1_ButtonWasClicked()
        {
            ID = objForm1.getID;
            Form4 objForm2 = new Form4(ID,objForm1.conn);
            objForm2.BtnPress += new Form4.Close(objForm2_BtnPress);
            objForm2.WinWasMoved += new Form4.MoveWin(objForm2_WinWasMoved);
            
            objForm.Close();
            objForm1.Close();
            panel3.Show();
            
            objForm2.TopLevel = false;
            panel3.Controls.Add(objForm2);
            objForm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm2.Dock = DockStyle.Fill;
            objForm2.Show();
            
            
        }

  
       /* private const int WM_NCLBUTTONDBLCLK = 0x00A3;
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
        */

        private void Form3_Load(object sender, System.EventArgs e)
        {
            panel3.Hide();
            button3.Hide();
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
         

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------



        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

            }
        }
    }

}
