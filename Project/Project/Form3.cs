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

        public Login Login;
        public Signup Signup;
        
        // new object for the signup form is created using the Signup class

        public static int ID; // ID is declared as static as there only needs to be one instance of it once it has been generated/ found

        //----------------------------------------------------------------------------------------------
        
        //These allow the user to control the movement of the form on their desktop
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        //----------------------------------------------------------------------------------------------        
      
        public Main()
        {
            InitializeComponent();
            Login = new Login(); //new object for the login form is created using the Login class
            Signup = new Signup(Login.conn); //new object for the login form is created using the Login class
            Login.ButtonWasClicked += new Login.ClickButton(ButtonWasClicked); //Allows a new method to be created to respond to the ButtonWasClicked event from the login form         
            Signup.ButtonWasClicked += new Signup.ClickButton(ButtonWasClicked); //Allows a new method to be created to respond to the ButtonWasClicked event from the Signup form   
        }

        private void Home_BtnPress()
        {
            this.Close(); //CLoses the window on the button press
        }
        
        //----------------------------------------------------------------------------------------------
       
        private void Home_WinWasMoved() //Moves the whole Form with the mouse
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e) //Allows the user to move the form 
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
      
        //----------------------------------------------------------------------------------------------



        private void Form3_Load(object sender, System.EventArgs e)
        {
            
            
            panel3.Hide(); //panel3 is hidden on startup as the user has to login or signup to show it
            SwitchToSign.Hide(); //Hides the Button to swtich from login to signup
            
            Signup.TopLevel = false; //Allows the Home Form to be docked
            panel1.Controls.Add(Signup); //Adds the form to the Panel
            Signup.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //removes any border
            Signup.Dock = DockStyle.Fill; //Docks the Form to the panel so it is aligned and fills the panel
            Signup.Show(); //Shows the Signup Form to the user      
        }

        private void ButtonWasClicked()
        {
            ID = Login.getID + Signup.getID; //Uses the getID method from login and signup to find the users ID
            Home Home = new Home(ID, Login.conn); // new object for the home form is created using the Home class

            Home.BtnPress += new Home.FormClose(Home_BtnPress); //Allows a new method to be created to respond to the BtnPress event from the Home form    
            Home.WinWasMoved += new Home.MoveWin(Home_WinWasMoved); //Allows a new method to be created to respond to the WinWasMoved event from the Home form    

            Signup.Close(); //Signup form closes
            Login.Close(); //Login form closes
            panel3.Show(); //Panel 3 is shown( this panel has the Home form docked in it)

            Home.TopLevel = false; //Allows the Home Form to be docked
            panel3.Controls.Add(Home); //Adds the form to the Panel
            Home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //removes any border
            Home.Dock = DockStyle.Fill; //Docks the Form to the panel so it is aligned and fills the panel
            Home.Show(); //Shows the Home Form to the user
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {         
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //CLoses the window on the button press
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {          
           Signup.Hide(); //Signup form is hidden
           SwitchToSign.Show(); //The signup button is shown
           
           SwitchToLog.Hide(); //The login button is hidden
           Login.TopLevel = false; //Allows the Login Form to be docked
           panel1.Controls.Add(Login);  //Adds the form to the Panel
           Login.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //removes any border
           Login.Dock = DockStyle.Fill; //Docks the Form to the panel so it is aligned and fills the panel
           Login.Show(); //Shows the Signup Form to the user           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login.Hide(); //Login form is hidden
            SwitchToLog.Show(); //The login button is shown
           
            SwitchToSign.Hide(); //The signup button is hidden
            Signup.TopLevel = false; //Allows the Login Form to be docked
            panel1.Controls.Add(Signup); //Adds the form to the Panel
            Signup.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //removes any border
            Signup.Dock = DockStyle.Fill; //Docks the Form to the panel so it is aligned and fills the panel
            Signup.Show(); //Shows the Signup Form to the user
        }

        //----------------------------------------------------------------------------------------------


    }

}
