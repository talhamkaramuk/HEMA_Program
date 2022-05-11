namespace HEMA_Program.Forms.SetupForms
{
    partial class Connection
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gboxBaudRate = new System.Windows.Forms.GroupBox();
            this.cboxBaudRate = new System.Windows.Forms.ComboBox();
            this.tboxBaudRate = new System.Windows.Forms.TextBox();
            this.chboxBaudRate = new System.Windows.Forms.CheckBox();
            this.gboxCOMPorts = new System.Windows.Forms.GroupBox();
            this.cboxCOMPorts = new System.Windows.Forms.ComboBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tabpanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gboxBaudRate.SuspendLayout();
            this.gboxCOMPorts.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.tabpanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 396);
            this.panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gboxBaudRate);
            this.panel1.Controls.Add(this.gboxCOMPorts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 342);
            this.panel1.TabIndex = 1;
            // 
            // gboxBaudRate
            // 
            this.gboxBaudRate.Controls.Add(this.cboxBaudRate);
            this.gboxBaudRate.Controls.Add(this.tboxBaudRate);
            this.gboxBaudRate.Controls.Add(this.chboxBaudRate);
            this.gboxBaudRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxBaudRate.Location = new System.Drawing.Point(274, 0);
            this.gboxBaudRate.Name = "gboxBaudRate";
            this.gboxBaudRate.Size = new System.Drawing.Size(322, 342);
            this.gboxBaudRate.TabIndex = 1;
            this.gboxBaudRate.TabStop = false;
            this.gboxBaudRate.Text = "Baud Rate";
            // 
            // cboxBaudRate
            // 
            this.cboxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBaudRate.FormattingEnabled = true;
            this.cboxBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "500000",
            "921600",
            "1000000",
            "2000000"});
            this.cboxBaudRate.Location = new System.Drawing.Point(6, 38);
            this.cboxBaudRate.Name = "cboxBaudRate";
            this.cboxBaudRate.Size = new System.Drawing.Size(306, 24);
            this.cboxBaudRate.TabIndex = 0;
            // 
            // tboxBaudRate
            // 
            this.tboxBaudRate.Location = new System.Drawing.Point(6, 127);
            this.tboxBaudRate.Name = "tboxBaudRate";
            this.tboxBaudRate.Size = new System.Drawing.Size(258, 23);
            this.tboxBaudRate.TabIndex = 2;
            this.tboxBaudRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxBaudRate_KeyPress);
            // 
            // chboxBaudRate
            // 
            this.chboxBaudRate.AutoSize = true;
            this.chboxBaudRate.Location = new System.Drawing.Point(6, 100);
            this.chboxBaudRate.Name = "chboxBaudRate";
            this.chboxBaudRate.Size = new System.Drawing.Size(207, 21);
            this.chboxBaudRate.TabIndex = 1;
            this.chboxBaudRate.Text = "Enter a particular Baud Rate";
            this.chboxBaudRate.UseVisualStyleBackColor = true;
            this.chboxBaudRate.CheckedChanged += new System.EventHandler(this.chboxBaudRate_CheckedChanged);
            // 
            // gboxCOMPorts
            // 
            this.gboxCOMPorts.Controls.Add(this.cboxCOMPorts);
            this.gboxCOMPorts.Dock = System.Windows.Forms.DockStyle.Left;
            this.gboxCOMPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gboxCOMPorts.Location = new System.Drawing.Point(0, 0);
            this.gboxCOMPorts.Name = "gboxCOMPorts";
            this.gboxCOMPorts.Size = new System.Drawing.Size(274, 342);
            this.gboxCOMPorts.TabIndex = 0;
            this.gboxCOMPorts.TabStop = false;
            this.gboxCOMPorts.Text = "COM Ports";
            // 
            // cboxCOMPorts
            // 
            this.cboxCOMPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCOMPorts.FormattingEnabled = true;
            this.cboxCOMPorts.Location = new System.Drawing.Point(10, 38);
            this.cboxCOMPorts.Name = "cboxCOMPorts";
            this.cboxCOMPorts.Size = new System.Drawing.Size(258, 24);
            this.cboxCOMPorts.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.tabpanelMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(596, 50);
            this.panelMenu.TabIndex = 0;
            // 
            // tabpanelMenu
            // 
            this.tabpanelMenu.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tabpanelMenu.ColumnCount = 3;
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabpanelMenu.Controls.Add(this.btnDisconnect, 1, 0);
            this.tabpanelMenu.Controls.Add(this.btnConnect, 0, 0);
            this.tabpanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tabpanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabpanelMenu.Name = "tabpanelMenu";
            this.tabpanelMenu.RowCount = 1;
            this.tabpanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpanelMenu.Size = new System.Drawing.Size(596, 50);
            this.tabpanelMenu.TabIndex = 0;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisconnect.Image = global::HEMA_Program.Properties.Resources.icons8_electrical_cross_24;
            this.btnDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisconnect.Location = new System.Drawing.Point(124, 2);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(0);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDisconnect.Size = new System.Drawing.Size(150, 46);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Image = global::HEMA_Program.Properties.Resources.icons8_electrical_plus_24;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(2, 2);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConnect.Size = new System.Drawing.Size(120, 46);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 396);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Connection";
            this.Tag = "Connection";
            this.Text = "Connection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Connection_FormClosed);
            this.Load += new System.EventHandler(this.Connection_Load);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gboxBaudRate.ResumeLayout(false);
            this.gboxBaudRate.PerformLayout();
            this.gboxCOMPorts.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.tabpanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TableLayoutPanel tabpanelMenu;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gboxBaudRate;
        private System.Windows.Forms.GroupBox gboxCOMPorts;
        private System.Windows.Forms.ComboBox cboxCOMPorts;
        private System.Windows.Forms.TextBox tboxBaudRate;
        private System.Windows.Forms.CheckBox chboxBaudRate;
        private System.Windows.Forms.ComboBox cboxBaudRate;
        private System.IO.Ports.SerialPort serialPort;
    }
}