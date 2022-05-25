namespace HEMA_Program.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.panelDivider2 = new System.Windows.Forms.Panel();
            this.panelDivider1 = new System.Windows.Forms.Panel();
            this.iconPassword = new System.Windows.Forms.Label();
            this.iconUsername = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.btnExit);
            this.panelMain.Controls.Add(this.btnHelp);
            this.panelMain.Controls.Add(this.btnLogin);
            this.panelMain.Controls.Add(this.tboxPassword);
            this.panelMain.Controls.Add(this.tboxUsername);
            this.panelMain.Controls.Add(this.panelDivider2);
            this.panelMain.Controls.Add(this.panelDivider1);
            this.panelMain.Controls.Add(this.iconPassword);
            this.panelMain.Controls.Add(this.iconUsername);
            this.panelMain.Controls.Add(this.pboxLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(280, 380);
            this.panelMain.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(103, 305);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::HEMA_Program.Properties.Resources.icons8_help_24;
            this.btnHelp.Location = new System.Drawing.Point(247, 9);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(24, 24);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(81, 253);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 33);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tboxPassword
            // 
            this.tboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxPassword.Location = new System.Drawing.Point(73, 201);
            this.tboxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxPassword.MaxLength = 8;
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '•';
            this.tboxPassword.Size = new System.Drawing.Size(167, 16);
            this.tboxPassword.TabIndex = 2;
            this.tboxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxPassword_KeyPress);
            // 
            // tboxUsername
            // 
            this.tboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxUsername.Location = new System.Drawing.Point(73, 158);
            this.tboxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxUsername.MaxLength = 8;
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(167, 16);
            this.tboxUsername.TabIndex = 1;
            this.tboxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxUsername_KeyPress);
            // 
            // panelDivider2
            // 
            this.panelDivider2.BackColor = System.Drawing.Color.Black;
            this.panelDivider2.Location = new System.Drawing.Point(40, 223);
            this.panelDivider2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDivider2.Name = "panelDivider2";
            this.panelDivider2.Size = new System.Drawing.Size(200, 1);
            this.panelDivider2.TabIndex = 9;
            // 
            // panelDivider1
            // 
            this.panelDivider1.BackColor = System.Drawing.Color.Black;
            this.panelDivider1.Location = new System.Drawing.Point(40, 182);
            this.panelDivider1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDivider1.Name = "panelDivider1";
            this.panelDivider1.Size = new System.Drawing.Size(200, 1);
            this.panelDivider1.TabIndex = 8;
            // 
            // iconPassword
            // 
            this.iconPassword.BackColor = System.Drawing.Color.White;
            this.iconPassword.Image = global::HEMA_Program.Properties.Resources.icons8_lock_24;
            this.iconPassword.Location = new System.Drawing.Point(40, 195);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(24, 24);
            this.iconPassword.TabIndex = 7;
            // 
            // iconUsername
            // 
            this.iconUsername.BackColor = System.Drawing.Color.White;
            this.iconUsername.Image = global::HEMA_Program.Properties.Resources.icons8_contacts_24;
            this.iconUsername.Location = new System.Drawing.Point(40, 154);
            this.iconUsername.Name = "iconUsername";
            this.iconUsername.Size = new System.Drawing.Size(24, 24);
            this.iconUsername.TabIndex = 6;
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = global::HEMA_Program.Properties.Resources.hema_logo;
            this.pboxLogo.Location = new System.Drawing.Point(73, 24);
            this.pboxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(135, 78);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 0;
            this.pboxLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 380);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | HEMA Industry Inc.";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Panel panelDivider1;
        private System.Windows.Forms.Label iconPassword;
        private System.Windows.Forms.Label iconUsername;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Panel panelDivider2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}