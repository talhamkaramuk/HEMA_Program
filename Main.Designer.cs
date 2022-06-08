namespace HEMA_Program
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnDiagnostic = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelSpace = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.tabpanelStatus = new System.Windows.Forms.TableLayoutPanel();
            this.panelInterface = new System.Windows.Forms.Panel();
            this.pbarInterface = new System.Windows.Forms.ProgressBar();
            this.lblInterface = new System.Windows.Forms.Label();
            this.panelECU = new System.Windows.Forms.Panel();
            this.pbarECU = new System.Windows.Forms.ProgressBar();
            this.lblECU = new System.Windows.Forms.Label();
            this.panelCol3 = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.panelStatus.SuspendLayout();
            this.tabpanelStatus.SuspendLayout();
            this.panelInterface.SuspendLayout();
            this.panelECU.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.panelSide);
            this.panelMain.Controls.Add(this.panelStatus);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(784, 561);
            this.panelMain.TabIndex = 0;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(180, 80);
            this.panelForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(604, 456);
            this.panelForm.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(180, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(604, 80);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(604, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Controls.Add(this.btnLogs);
            this.panelSide.Controls.Add(this.btnDashboard);
            this.panelSide.Controls.Add(this.btnDiagnostic);
            this.panelSide.Controls.Add(this.btnSetup);
            this.panelSide.Controls.Add(this.btnHome);
            this.panelSide.Controls.Add(this.panelSpace);
            this.panelSide.Controls.Add(this.panelLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(180, 536);
            this.panelSide.TabIndex = 1;
            // 
            // btnLogs
            // 
            this.btnLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogs.FlatAppearance.BorderSize = 0;
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogs.Image = global::HEMA_Program.Properties.Resources.icons8_system_task_32;
            this.btnLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.Location = new System.Drawing.Point(0, 340);
            this.btnLogs.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Padding = new System.Windows.Forms.Padding(22, 0, 64, 0);
            this.btnLogs.Size = new System.Drawing.Size(180, 60);
            this.btnLogs.TabIndex = 6;
            this.btnLogs.Tag = "Logs";
            this.btnLogs.Text = "Logs";
            this.btnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.Image = global::HEMA_Program.Properties.Resources.icons8_speed_35;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 280);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 26, 0);
            this.btnDashboard.Size = new System.Drawing.Size(180, 60);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Tag = "Dashboard";
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnDiagnostic
            // 
            this.btnDiagnostic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiagnostic.FlatAppearance.BorderSize = 0;
            this.btnDiagnostic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnostic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiagnostic.Image = global::HEMA_Program.Properties.Resources.icons8_car_32;
            this.btnDiagnostic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiagnostic.Location = new System.Drawing.Point(0, 220);
            this.btnDiagnostic.Margin = new System.Windows.Forms.Padding(0);
            this.btnDiagnostic.Name = "btnDiagnostic";
            this.btnDiagnostic.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btnDiagnostic.Size = new System.Drawing.Size(180, 60);
            this.btnDiagnostic.TabIndex = 4;
            this.btnDiagnostic.Tag = "Diagnostic";
            this.btnDiagnostic.Text = "Diagnostic";
            this.btnDiagnostic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiagnostic.UseVisualStyleBackColor = true;
            this.btnDiagnostic.Click += new System.EventHandler(this.btnDiagnostic_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetup.FlatAppearance.BorderSize = 0;
            this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSetup.Image = global::HEMA_Program.Properties.Resources.icons8_maintenance_32;
            this.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.Location = new System.Drawing.Point(0, 160);
            this.btnSetup.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Padding = new System.Windows.Forms.Padding(20, 0, 63, 0);
            this.btnSetup.Size = new System.Drawing.Size(180, 60);
            this.btnSetup.TabIndex = 3;
            this.btnSetup.Tag = "Setup";
            this.btnSetup.Text = "Setup";
            this.btnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.Image = global::HEMA_Program.Properties.Resources.icons8_home_32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 62, 0);
            this.btnHome.Size = new System.Drawing.Size(180, 60);
            this.btnHome.TabIndex = 2;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelSpace
            // 
            this.panelSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpace.Location = new System.Drawing.Point(0, 80);
            this.panelSpace.Margin = new System.Windows.Forms.Padding(0);
            this.panelSpace.Name = "panelSpace";
            this.panelSpace.Size = new System.Drawing.Size(180, 20);
            this.panelSpace.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnCollapse);
            this.panelLogo.Controls.Add(this.pboxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // btnCollapse
            // 
            this.btnCollapse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Image = global::HEMA_Program.Properties.Resources.icons8_menu_28;
            this.btnCollapse.Location = new System.Drawing.Point(140, 0);
            this.btnCollapse.Margin = new System.Windows.Forms.Padding(0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(40, 80);
            this.btnCollapse.TabIndex = 1;
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // pboxLogo
            // 
            this.pboxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboxLogo.Image = global::HEMA_Program.Properties.Resources.hema_logo;
            this.pboxLogo.Location = new System.Drawing.Point(0, 0);
            this.pboxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(140, 80);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 0;
            this.pboxLogo.TabStop = false;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.White;
            this.panelStatus.Controls.Add(this.tabpanelStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 536);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(784, 25);
            this.panelStatus.TabIndex = 0;
            // 
            // tabpanelStatus
            // 
            this.tabpanelStatus.ColumnCount = 3;
            this.tabpanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tabpanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tabpanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabpanelStatus.Controls.Add(this.panelInterface, 0, 0);
            this.tabpanelStatus.Controls.Add(this.panelECU, 1, 0);
            this.tabpanelStatus.Controls.Add(this.panelCol3, 2, 0);
            this.tabpanelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpanelStatus.Location = new System.Drawing.Point(0, 0);
            this.tabpanelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.tabpanelStatus.Name = "tabpanelStatus";
            this.tabpanelStatus.RowCount = 1;
            this.tabpanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpanelStatus.Size = new System.Drawing.Size(784, 25);
            this.tabpanelStatus.TabIndex = 0;
            // 
            // panelInterface
            // 
            this.panelInterface.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInterface.Controls.Add(this.pbarInterface);
            this.panelInterface.Controls.Add(this.lblInterface);
            this.panelInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInterface.Location = new System.Drawing.Point(0, 0);
            this.panelInterface.Margin = new System.Windows.Forms.Padding(0);
            this.panelInterface.Name = "panelInterface";
            this.panelInterface.Size = new System.Drawing.Size(140, 25);
            this.panelInterface.TabIndex = 0;
            // 
            // pbarInterface
            // 
            this.pbarInterface.ForeColor = System.Drawing.Color.Lime;
            this.pbarInterface.Location = new System.Drawing.Point(70, 3);
            this.pbarInterface.Margin = new System.Windows.Forms.Padding(0);
            this.pbarInterface.Maximum = 1;
            this.pbarInterface.Name = "pbarInterface";
            this.pbarInterface.Size = new System.Drawing.Size(60, 16);
            this.pbarInterface.TabIndex = 1;
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInterface.Location = new System.Drawing.Point(0, 0);
            this.lblInterface.Margin = new System.Windows.Forms.Padding(0);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(67, 17);
            this.lblInterface.TabIndex = 0;
            this.lblInterface.Text = "Interface:";
            // 
            // panelECU
            // 
            this.panelECU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelECU.Controls.Add(this.pbarECU);
            this.panelECU.Controls.Add(this.lblECU);
            this.panelECU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelECU.Location = new System.Drawing.Point(140, 0);
            this.panelECU.Margin = new System.Windows.Forms.Padding(0);
            this.panelECU.Name = "panelECU";
            this.panelECU.Size = new System.Drawing.Size(110, 25);
            this.panelECU.TabIndex = 1;
            // 
            // pbarECU
            // 
            this.pbarECU.ForeColor = System.Drawing.Color.Lime;
            this.pbarECU.Location = new System.Drawing.Point(40, 3);
            this.pbarECU.Margin = new System.Windows.Forms.Padding(0);
            this.pbarECU.Maximum = 1;
            this.pbarECU.Name = "pbarECU";
            this.pbarECU.Size = new System.Drawing.Size(60, 16);
            this.pbarECU.TabIndex = 2;
            // 
            // lblECU
            // 
            this.lblECU.AutoSize = true;
            this.lblECU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblECU.Location = new System.Drawing.Point(0, 0);
            this.lblECU.Margin = new System.Windows.Forms.Padding(0);
            this.lblECU.Name = "lblECU";
            this.lblECU.Size = new System.Drawing.Size(40, 17);
            this.lblECU.TabIndex = 1;
            this.lblECU.Text = "ECU:";
            // 
            // panelCol3
            // 
            this.panelCol3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCol3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCol3.Location = new System.Drawing.Point(250, 0);
            this.panelCol3.Margin = new System.Windows.Forms.Padding(0);
            this.panelCol3.Name = "panelCol3";
            this.panelCol3.Size = new System.Drawing.Size(534, 25);
            this.panelCol3.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program | HEMA Industry Inc.";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.panelStatus.ResumeLayout(false);
            this.tabpanelStatus.ResumeLayout(false);
            this.panelInterface.ResumeLayout(false);
            this.panelInterface.PerformLayout();
            this.panelECU.ResumeLayout(false);
            this.panelECU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnDiagnostic;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelSpace;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tabpanelStatus;
        private System.Windows.Forms.Panel panelInterface;
        private System.Windows.Forms.Panel panelECU;
        private System.Windows.Forms.ProgressBar pbarInterface;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.ProgressBar pbarECU;
        private System.Windows.Forms.Label lblECU;
        private System.Windows.Forms.Panel panelCol3;
    }
}

