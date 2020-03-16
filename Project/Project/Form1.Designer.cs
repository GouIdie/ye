namespace Project
{
    partial class Signup
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.SaveData = new System.Windows.Forms.Button();
            this.projectDataDataSet = new Project.ProjectDataDataSet();
            this.projectDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new Project.ProjectDataDataSetTableAdapters.CustomerTableAdapter();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(176, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 486);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(205, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 460);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(518, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(518, 174);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 95);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.EmailTB);
            this.panel3.Controls.Add(this.PasswordTB);
            this.panel3.Controls.Add(this.UsernameTB);
            this.panel3.Controls.Add(this.SaveData);
            this.panel3.Location = new System.Drawing.Point(-21, -9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 497);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Create your account";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.panel6.Location = new System.Drawing.Point(146, 155);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 2);
            this.panel6.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.panel5.Location = new System.Drawing.Point(146, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 2);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.panel4.Location = new System.Drawing.Point(146, 206);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 2);
            this.panel4.TabIndex = 4;
            // 
            // EmailTB
            // 
            this.EmailTB.BackColor = System.Drawing.Color.SeaShell;
            this.EmailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.EmailTB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.EmailTB.Location = new System.Drawing.Point(146, 232);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(158, 20);
            this.EmailTB.TabIndex = 3;
            this.EmailTB.Text = "Email";
            this.EmailTB.TextChanged += new System.EventHandler(this.EmailTB_TextChanged);
            this.EmailTB.Enter += new System.EventHandler(this.EmailTB_Enter);
            this.EmailTB.Leave += new System.EventHandler(this.EmailTB_Leave);
            // 
            // PasswordTB
            // 
            this.PasswordTB.BackColor = System.Drawing.Color.SeaShell;
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordTB.Location = new System.Drawing.Point(148, 180);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(158, 20);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.Text = "Password";
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            this.PasswordTB.Enter += new System.EventHandler(this.PasswordTB_Enter);
            this.PasswordTB.Leave += new System.EventHandler(this.PasswordTB_Leave);
            // 
            // UsernameTB
            // 
            this.UsernameTB.BackColor = System.Drawing.Color.SeaShell;
            this.UsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UsernameTB.Location = new System.Drawing.Point(146, 129);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(158, 20);
            this.UsernameTB.TabIndex = 1;
            this.UsernameTB.Text = "Username";
            this.UsernameTB.TextChanged += new System.EventHandler(this.UsernameTB_TextChanged);
            this.UsernameTB.Enter += new System.EventHandler(this.UsernameTB_Enter);
            this.UsernameTB.Leave += new System.EventHandler(this.UsernameTB_Leave);
            // 
            // SaveData
            // 
            this.SaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.SaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveData.ForeColor = System.Drawing.Color.SeaShell;
            this.SaveData.Location = new System.Drawing.Point(146, 323);
            this.SaveData.Name = "SaveData";
            this.SaveData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SaveData.Size = new System.Drawing.Size(158, 34);
            this.SaveData.TabIndex = 0;
            this.SaveData.Text = "Sign up";
            this.SaveData.UseVisualStyleBackColor = false;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // projectDataDataSet
            // 
            this.projectDataDataSet.DataSetName = "ProjectDataDataSet";
            this.projectDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectDataDataSetBindingSource
            // 
            this.projectDataDataSetBindingSource.DataSource = this.projectDataDataSet;
            this.projectDataDataSetBindingSource.Position = 0;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(440, 485);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Signup";
            this.ShowIcon = false;
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            this.Leave += new System.EventHandler(this.PasswordTB_Leave);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.BindingSource projectDataDataSetBindingSource;
        private ProjectDataDataSet projectDataDataSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox PasswordTB;
        private ProjectDataDataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}

