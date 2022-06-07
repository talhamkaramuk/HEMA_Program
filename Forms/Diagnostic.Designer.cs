namespace HEMA_Program.Forms
{
    partial class Diagnostic
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
            this.btnConn = new System.Windows.Forms.Button();
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
            this.panelForm.Location = new System.Drawing.Point(0, 50);
            this.panelForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(600, 402);
            this.panelForm.TabIndex = 1;
            // 
            // tabpanelMenu
            // 
            this.tabpanelMenu.ColumnCount = 6;
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabpanelMenu.Controls.Add(this.btnConn, 0, 0);
            this.tabpanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabpanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tabpanelMenu.Name = "tabpanelMenu";
            this.tabpanelMenu.RowCount = 1;
            this.tabpanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpanelMenu.Size = new System.Drawing.Size(600, 50);
            this.tabpanelMenu.TabIndex = 0;
            // 
            // btnConn
            // 
            this.btnConn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConn.FlatAppearance.BorderSize = 0;
            this.btnConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConn.Image = global::HEMA_Program.Properties.Resources.icons8_link_28;
            this.btnConn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConn.Location = new System.Drawing.Point(0, 0);
            this.btnConn.Margin = new System.Windows.Forms.Padding(0);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(100, 50);
            this.btnConn.TabIndex = 0;
            this.btnConn.Text = "Connection";
            this.btnConn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConn.UseVisualStyleBackColor = false;
            // 
            // Diagnostic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 456);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagnostic";
            this.Text = "Diagnostic";
            this.Load += new System.EventHandler(this.Diagnostic_Load);
            this.panelMain.ResumeLayout(false);
            this.tabpanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tabpanelMenu;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnConn;
    }
}