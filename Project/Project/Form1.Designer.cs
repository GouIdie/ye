namespace Project
{
    partial class Simulation
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.SaveData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.projectDataDataSet = new Project.ProjectDataDataSet();
            this.projectDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(186, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 486);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.panel2.Location = new System.Drawing.Point(205, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 457);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.EmailTB);
            this.panel3.Controls.Add(this.PasswordTB);
            this.panel3.Controls.Add(this.UsernameTB);
            this.panel3.Controls.Add(this.SaveData);
            this.panel3.Location = new System.Drawing.Point(-21, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 460);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 95);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(33, 120);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(158, 20);
            this.EmailTB.TabIndex = 3;
            this.EmailTB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // PasswordTB
            // 
            this.PasswordTB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordTB.Location = new System.Drawing.Point(33, 84);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(158, 20);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.Text = "Password";
            this.PasswordTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.PasswordTB.Enter += new System.EventHandler(this.textBox3_Entering);
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(33, 48);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(158, 20);
            this.UsernameTB.TabIndex = 1;
            // 
            // SaveData
            // 
            this.SaveData.ForeColor = System.Drawing.Color.Black;
            this.SaveData.Location = new System.Drawing.Point(33, 156);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(158, 23);
            this.SaveData.TabIndex = 0;
            this.SaveData.Text = "Enter Data";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(855, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Maximize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Simulation";
            this.ShowIcon = false;
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.BindingSource projectDataDataSetBindingSource;
        private ProjectDataDataSet projectDataDataSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

