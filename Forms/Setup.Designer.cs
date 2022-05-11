namespace HEMA_Program.Forms
{
    partial class Setup
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.tabpanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnPid = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.tabpanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(this.tabpanelMenu);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(604, 456);
            this.panelMain.TabIndex = 0;
            // 
            // panelForm
            // 
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 56);
            this.panelForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(600, 396);
            this.panelForm.TabIndex = 1;
            // 
            // tabpanelMenu
            // 
            this.tabpanelMenu.ColumnCount = 4;
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tabpanelMenu.Controls.Add(this.btnConnection, 0, 0);
            this.tabpanelMenu.Controls.Add(this.btnPid, 1, 0);
            this.tabpanelMenu.Controls.Add(this.btnGeneral, 2, 0);
            this.tabpanelMenu.Controls.Add(this.btnInfo, 3, 0);
            this.tabpanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabpanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tabpanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabpanelMenu.Name = "tabpanelMenu";
            this.tabpanelMenu.RowCount = 1;
            this.tabpanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpanelMenu.Size = new System.Drawing.Size(600, 56);
            this.tabpanelMenu.TabIndex = 0;
            // 
            // btnConnection
            // 
            this.btnConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnection.FlatAppearance.BorderSize = 0;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnection.Image = global::HEMA_Program.Properties.Resources.icons8_electrical_28;
            this.btnConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnection.Location = new System.Drawing.Point(0, 0);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(0);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConnection.Size = new System.Drawing.Size(168, 56);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Tag = "Connection";
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnPid
            // 
            this.btnPid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPid.FlatAppearance.BorderSize = 0;
            this.btnPid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPid.Image = global::HEMA_Program.Properties.Resources.icons8_data_sheet_28;
            this.btnPid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPid.Location = new System.Drawing.Point(168, 0);
            this.btnPid.Margin = new System.Windows.Forms.Padding(0);
            this.btnPid.Name = "btnPid";
            this.btnPid.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPid.Size = new System.Drawing.Size(174, 56);
            this.btnPid.TabIndex = 1;
            this.btnPid.Tag = "PID Setup";
            this.btnPid.Text = "PID Setup";
            this.btnPid.UseVisualStyleBackColor = true;
            this.btnPid.Click += new System.EventHandler(this.btnPid_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeneral.Image = global::HEMA_Program.Properties.Resources.icons8_adjust_28;
            this.btnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.Location = new System.Drawing.Point(342, 0);
            this.btnGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGeneral.Size = new System.Drawing.Size(150, 56);
            this.btnGeneral.TabIndex = 2;
            this.btnGeneral.Tag = "General";
            this.btnGeneral.Text = "General";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInfo.Image = global::HEMA_Program.Properties.Resources.icons8_info_28;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(492, 0);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(108, 56);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Tag = "Info";
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 456);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setup";
            this.Tag = "Setup";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.panelMain.ResumeLayout(false);
            this.tabpanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TableLayoutPanel tabpanelMenu;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnPid;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnInfo;
    }
}