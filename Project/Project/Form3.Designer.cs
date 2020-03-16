namespace Project
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.SwitchToSign = new System.Windows.Forms.Button();
            this.SwitchToLog = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerTableAdapter1 = new Project.ProjectDataDataSetTableAdapters.CustomerTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.SeaShell;
            panel2.ForeColor = System.Drawing.Color.Transparent;
            panel2.Location = new System.Drawing.Point(51, 234);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(281, 4);
            panel2.TabIndex = 2;
            panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SwitchToSign);
            this.panel1.Controls.Add(this.SwitchToLog);
            this.panel1.Location = new System.Drawing.Point(406, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 487);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.SwitchToSign.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.SwitchToSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwitchToSign.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchToSign.Location = new System.Drawing.Point(166, 401);
            this.SwitchToSign.Name = "button3";
            this.SwitchToSign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SwitchToSign.Size = new System.Drawing.Size(78, 30);
            this.SwitchToSign.TabIndex = 18;
            this.SwitchToSign.Text = "Sign up";
            this.SwitchToSign.UseVisualStyleBackColor = true;
            this.SwitchToSign.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.SwitchToLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.SwitchToLog.FlatAppearance.BorderSize = 2;
            this.SwitchToLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwitchToLog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchToLog.Location = new System.Drawing.Point(166, 401);
            this.SwitchToLog.Name = "button2";
            this.SwitchToLog.Size = new System.Drawing.Size(78, 30);
            this.SwitchToLog.TabIndex = 9;
            this.SwitchToLog.Text = "Log in";
            this.SwitchToLog.UseVisualStyleBackColor = true;
            this.SwitchToLog.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.button1.Location = new System.Drawing.Point(361, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = " X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(43, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROJECT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 476);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 476);
            this.MinimumSize = new System.Drawing.Size(800, 476);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ProjectDataDataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SwitchToLog;
        private System.Windows.Forms.Button SwitchToSign;
        public System.Windows.Forms.Panel panel3;
    }
}