namespace HEMA_Program.Forms.DiagForms
{
    partial class TroubleCodes
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tabpanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelCodes = new System.Windows.Forms.Panel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.panelStored = new System.Windows.Forms.Panel();
            this.panelPending = new System.Windows.Forms.Panel();
            this.panelPermanent = new System.Windows.Forms.Panel();
            this.lblStored = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblPermanent = new System.Windows.Forms.Label();
            this.panelDivider1 = new System.Windows.Forms.Panel();
            this.panelDivider2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.tabpanelMenu.SuspendLayout();
            this.panelCodes.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panelStored.SuspendLayout();
            this.panelPending.SuspendLayout();
            this.panelPermanent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 396);
            this.panelMain.TabIndex = 0;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.panelDetails);
            this.panelForm.Controls.Add(this.panelCodes);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 50);
            this.panelForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(600, 346);
            this.panelForm.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.tabpanelMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(600, 50);
            this.panelMenu.TabIndex = 0;
            // 
            // tabpanelMenu
            // 
            this.tabpanelMenu.ColumnCount = 4;
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tabpanelMenu.Controls.Add(this.btnSave, 0, 0);
            this.tabpanelMenu.Controls.Add(this.btnRefresh, 1, 0);
            this.tabpanelMenu.Controls.Add(this.btnClear, 2, 0);
            this.tabpanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tabpanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tabpanelMenu.Name = "tabpanelMenu";
            this.tabpanelMenu.RowCount = 1;
            this.tabpanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpanelMenu.Size = new System.Drawing.Size(600, 50);
            this.tabpanelMenu.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Image = global::HEMA_Program.Properties.Resources.icons8_save_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnSave.Size = new System.Drawing.Size(90, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.Image = global::HEMA_Program.Properties.Resources.icons8_refresh_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(90, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnRefresh.Size = new System.Drawing.Size(120, 50);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Image = global::HEMA_Program.Properties.Resources.icons8_no_error_24;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(210, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 50);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Trouble Codes";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // panelCodes
            // 
            this.panelCodes.Controls.Add(this.panelPermanent);
            this.panelCodes.Controls.Add(this.panelPending);
            this.panelCodes.Controls.Add(this.panelStored);
            this.panelCodes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCodes.Location = new System.Drawing.Point(0, 0);
            this.panelCodes.Margin = new System.Windows.Forms.Padding(0);
            this.panelCodes.Name = "panelCodes";
            this.panelCodes.Size = new System.Drawing.Size(200, 346);
            this.panelCodes.TabIndex = 0;
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.White;
            this.panelDetails.Controls.Add(this.lblTitle);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(200, 0);
            this.panelDetails.Margin = new System.Windows.Forms.Padding(0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(400, 346);
            this.panelDetails.TabIndex = 1;
            // 
            // panelStored
            // 
            this.panelStored.Controls.Add(this.panelDivider1);
            this.panelStored.Controls.Add(this.lblStored);
            this.panelStored.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStored.Location = new System.Drawing.Point(0, 0);
            this.panelStored.Margin = new System.Windows.Forms.Padding(0);
            this.panelStored.Name = "panelStored";
            this.panelStored.Size = new System.Drawing.Size(200, 115);
            this.panelStored.TabIndex = 0;
            // 
            // panelPending
            // 
            this.panelPending.Controls.Add(this.panelDivider2);
            this.panelPending.Controls.Add(this.lblPending);
            this.panelPending.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPending.Location = new System.Drawing.Point(0, 115);
            this.panelPending.Margin = new System.Windows.Forms.Padding(0);
            this.panelPending.Name = "panelPending";
            this.panelPending.Size = new System.Drawing.Size(200, 115);
            this.panelPending.TabIndex = 1;
            // 
            // panelPermanent
            // 
            this.panelPermanent.Controls.Add(this.panel2);
            this.panelPermanent.Controls.Add(this.lblPermanent);
            this.panelPermanent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPermanent.Location = new System.Drawing.Point(0, 230);
            this.panelPermanent.Margin = new System.Windows.Forms.Padding(0);
            this.panelPermanent.Name = "panelPermanent";
            this.panelPermanent.Size = new System.Drawing.Size(200, 116);
            this.panelPermanent.TabIndex = 2;
            // 
            // lblStored
            // 
            this.lblStored.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStored.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStored.Location = new System.Drawing.Point(0, 0);
            this.lblStored.Name = "lblStored";
            this.lblStored.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblStored.Size = new System.Drawing.Size(200, 23);
            this.lblStored.TabIndex = 0;
            this.lblStored.Text = "Stored";
            this.lblStored.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPending
            // 
            this.lblPending.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPending.Location = new System.Drawing.Point(0, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblPending.Size = new System.Drawing.Size(200, 23);
            this.lblPending.TabIndex = 0;
            this.lblPending.Text = "Pending";
            this.lblPending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPermanent
            // 
            this.lblPermanent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPermanent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPermanent.Location = new System.Drawing.Point(0, 0);
            this.lblPermanent.Name = "lblPermanent";
            this.lblPermanent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblPermanent.Size = new System.Drawing.Size(200, 23);
            this.lblPermanent.TabIndex = 0;
            this.lblPermanent.Text = "Permanent";
            this.lblPermanent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDivider1
            // 
            this.panelDivider1.BackColor = System.Drawing.Color.Black;
            this.panelDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDivider1.Location = new System.Drawing.Point(0, 23);
            this.panelDivider1.Name = "panelDivider1";
            this.panelDivider1.Size = new System.Drawing.Size(200, 1);
            this.panelDivider1.TabIndex = 1;
            // 
            // panelDivider2
            // 
            this.panelDivider2.BackColor = System.Drawing.Color.Black;
            this.panelDivider2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDivider2.Location = new System.Drawing.Point(0, 23);
            this.panelDivider2.Name = "panelDivider2";
            this.panelDivider2.Size = new System.Drawing.Size(200, 1);
            this.panelDivider2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(31, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(333, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // TroubleCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 396);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TroubleCodes";
            this.Text = "TroubleCodes";
            this.panelMain.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.tabpanelMenu.ResumeLayout(false);
            this.panelCodes.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelStored.ResumeLayout(false);
            this.panelPending.ResumeLayout(false);
            this.panelPermanent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TableLayoutPanel tabpanelMenu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panelCodes;
        private System.Windows.Forms.Panel panelPermanent;
        private System.Windows.Forms.Panel panelPending;
        private System.Windows.Forms.Panel panelStored;
        private System.Windows.Forms.Label lblPermanent;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Panel panelDivider1;
        private System.Windows.Forms.Label lblStored;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDivider2;
        private System.Windows.Forms.Label lblTitle;
    }
}