namespace HEMA_Program.Forms.SetupForms
{
    partial class PIDSetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tabpanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnSDefaults = new System.Windows.Forms.Button();
            this.btnSNone = new System.Windows.Forms.Button();
            this.btnSAll = new System.Windows.Forms.Button();
            this.btnAutoConfig = new System.Windows.Forms.Button();
            this.btnPolling = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.panelMain.SuspendLayout();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.tabpanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.panelTable);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 396);
            this.panelMain.TabIndex = 0;
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dgvTable);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable.Location = new System.Drawing.Point(0, 50);
            this.panelTable.Margin = new System.Windows.Forms.Padding(0);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(596, 342);
            this.panelTable.TabIndex = 2;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.EnableHeadersVisualStyles = false;
            this.dgvTable.Location = new System.Drawing.Point(0, 0);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(596, 342);
            this.dgvTable.TabIndex = 0;
            this.dgvTable.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvTable_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.tabpanelMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(596, 50);
            this.panelMenu.TabIndex = 1;
            // 
            // tabpanelMenu
            // 
            this.tabpanelMenu.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tabpanelMenu.ColumnCount = 7;
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tabpanelMenu.Controls.Add(this.btnSDefaults, 6, 0);
            this.tabpanelMenu.Controls.Add(this.btnSNone, 5, 0);
            this.tabpanelMenu.Controls.Add(this.btnSAll, 4, 0);
            this.tabpanelMenu.Controls.Add(this.btnAutoConfig, 3, 0);
            this.tabpanelMenu.Controls.Add(this.btnPolling, 2, 0);
            this.tabpanelMenu.Controls.Add(this.btnSave, 1, 0);
            this.tabpanelMenu.Controls.Add(this.btnOpen, 0, 0);
            this.tabpanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tabpanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabpanelMenu.Name = "tabpanelMenu";
            this.tabpanelMenu.RowCount = 1;
            this.tabpanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpanelMenu.Size = new System.Drawing.Size(596, 50);
            this.tabpanelMenu.TabIndex = 0;
            // 
            // btnSDefaults
            // 
            this.btnSDefaults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSDefaults.Image = global::HEMA_Program.Properties.Resources.icons8_data_sheet_24;
            this.btnSDefaults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSDefaults.Location = new System.Drawing.Point(506, 2);
            this.btnSDefaults.Margin = new System.Windows.Forms.Padding(0);
            this.btnSDefaults.Name = "btnSDefaults";
            this.btnSDefaults.Size = new System.Drawing.Size(88, 46);
            this.btnSDefaults.TabIndex = 7;
            this.btnSDefaults.Text = "Select\r\nDefaults";
            this.btnSDefaults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSDefaults.UseVisualStyleBackColor = true;
            // 
            // btnSNone
            // 
            this.btnSNone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSNone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSNone.Image = global::HEMA_Program.Properties.Resources.icons8_data_sheet_x_24;
            this.btnSNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSNone.Location = new System.Drawing.Point(422, 2);
            this.btnSNone.Margin = new System.Windows.Forms.Padding(0);
            this.btnSNone.Name = "btnSNone";
            this.btnSNone.Size = new System.Drawing.Size(82, 46);
            this.btnSNone.TabIndex = 6;
            this.btnSNone.Text = "Select\r\nNone";
            this.btnSNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSNone.UseVisualStyleBackColor = true;
            this.btnSNone.Click += new System.EventHandler(this.btnSNone_Click);
            // 
            // btnSAll
            // 
            this.btnSAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSAll.Image = global::HEMA_Program.Properties.Resources.icons8_data_sheet_tick_24;
            this.btnSAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSAll.Location = new System.Drawing.Point(338, 2);
            this.btnSAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnSAll.Name = "btnSAll";
            this.btnSAll.Size = new System.Drawing.Size(82, 46);
            this.btnSAll.TabIndex = 5;
            this.btnSAll.Text = "Select All";
            this.btnSAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAll.UseVisualStyleBackColor = true;
            this.btnSAll.Click += new System.EventHandler(this.btnSAll_Click);
            // 
            // btnAutoConfig
            // 
            this.btnAutoConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAutoConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutoConfig.Image = global::HEMA_Program.Properties.Resources.icons8_close_24;
            this.btnAutoConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoConfig.Location = new System.Drawing.Point(254, 2);
            this.btnAutoConfig.Margin = new System.Windows.Forms.Padding(0);
            this.btnAutoConfig.Name = "btnAutoConfig";
            this.btnAutoConfig.Size = new System.Drawing.Size(82, 46);
            this.btnAutoConfig.TabIndex = 4;
            this.btnAutoConfig.Text = "Auto Configure";
            this.btnAutoConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutoConfig.UseVisualStyleBackColor = true;
            // 
            // btnPolling
            // 
            this.btnPolling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPolling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPolling.Image = global::HEMA_Program.Properties.Resources.icons8_clock_settings_24;
            this.btnPolling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPolling.Location = new System.Drawing.Point(170, 2);
            this.btnPolling.Margin = new System.Windows.Forms.Padding(0);
            this.btnPolling.Name = "btnPolling";
            this.btnPolling.Size = new System.Drawing.Size(82, 46);
            this.btnPolling.TabIndex = 3;
            this.btnPolling.Text = "Set Polling Rate";
            this.btnPolling.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPolling.UseVisualStyleBackColor = true;
            this.btnPolling.Click += new System.EventHandler(this.btnPolling_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = global::HEMA_Program.Properties.Resources.icons8_save_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(86, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 46);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Image = global::HEMA_Program.Properties.Resources.icons8_opened_folder_24;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(2, 2);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(82, 46);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "Excel Files (*.xlsx)|*.xlsx|*.xls|*.xl";
            // 
            // PIDSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 396);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PIDSetup";
            this.Tag = "PID Setup";
            this.Text = "PID Setup";
            this.panelMain.ResumeLayout(false);
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.tabpanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TableLayoutPanel tabpanelMenu;
        private System.Windows.Forms.Button btnSDefaults;
        private System.Windows.Forms.Button btnSNone;
        private System.Windows.Forms.Button btnSAll;
        private System.Windows.Forms.Button btnAutoConfig;
        private System.Windows.Forms.Button btnPolling;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}