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
            this.btnTroubleCodes = new System.Windows.Forms.Button();
            this.btnFreezeFrame = new System.Windows.Forms.Button();
            this.btnMonitorTests = new System.Windows.Forms.Button();
            this.btnPIDValues = new System.Windows.Forms.Button();
            this.btnRawData = new System.Windows.Forms.Button();
            this.btnConsole = new System.Windows.Forms.Button();
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
            this.tabpanelMenu.Controls.Add(this.btnTroubleCodes, 0, 0);
            this.tabpanelMenu.Controls.Add(this.btnFreezeFrame, 1, 0);
            this.tabpanelMenu.Controls.Add(this.btnMonitorTests, 2, 0);
            this.tabpanelMenu.Controls.Add(this.btnPIDValues, 3, 0);
            this.tabpanelMenu.Controls.Add(this.btnRawData, 4, 0);
            this.tabpanelMenu.Controls.Add(this.btnConsole, 5, 0);
            this.tabpanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabpanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tabpanelMenu.Name = "tabpanelMenu";
            this.tabpanelMenu.RowCount = 1;
            this.tabpanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpanelMenu.Size = new System.Drawing.Size(600, 50);
            this.tabpanelMenu.TabIndex = 0;
            // 
            // btnTroubleCodes
            // 
            this.btnTroubleCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTroubleCodes.FlatAppearance.BorderSize = 0;
            this.btnTroubleCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroubleCodes.Image = global::HEMA_Program.Properties.Resources.icons8_error_28;
            this.btnTroubleCodes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroubleCodes.Location = new System.Drawing.Point(0, 0);
            this.btnTroubleCodes.Margin = new System.Windows.Forms.Padding(0);
            this.btnTroubleCodes.Name = "btnTroubleCodes";
            this.btnTroubleCodes.Size = new System.Drawing.Size(100, 50);
            this.btnTroubleCodes.TabIndex = 0;
            this.btnTroubleCodes.Text = "Trouble\r\nCodes";
            this.btnTroubleCodes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroubleCodes.UseVisualStyleBackColor = false;
            // 
            // btnFreezeFrame
            // 
            this.btnFreezeFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFreezeFrame.FlatAppearance.BorderSize = 0;
            this.btnFreezeFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFreezeFrame.Image = global::HEMA_Program.Properties.Resources.icons8_data_sheet_error_28;
            this.btnFreezeFrame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFreezeFrame.Location = new System.Drawing.Point(100, 0);
            this.btnFreezeFrame.Margin = new System.Windows.Forms.Padding(0);
            this.btnFreezeFrame.Name = "btnFreezeFrame";
            this.btnFreezeFrame.Size = new System.Drawing.Size(100, 50);
            this.btnFreezeFrame.TabIndex = 1;
            this.btnFreezeFrame.Text = "Freeze\r\nFrame";
            this.btnFreezeFrame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFreezeFrame.UseVisualStyleBackColor = false;
            // 
            // btnMonitorTests
            // 
            this.btnMonitorTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMonitorTests.FlatAppearance.BorderSize = 0;
            this.btnMonitorTests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitorTests.Image = global::HEMA_Program.Properties.Resources.icons8_test_28;
            this.btnMonitorTests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitorTests.Location = new System.Drawing.Point(200, 0);
            this.btnMonitorTests.Margin = new System.Windows.Forms.Padding(0);
            this.btnMonitorTests.Name = "btnMonitorTests";
            this.btnMonitorTests.Size = new System.Drawing.Size(100, 50);
            this.btnMonitorTests.TabIndex = 2;
            this.btnMonitorTests.Text = "Monitor\r\nTests";
            this.btnMonitorTests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMonitorTests.UseVisualStyleBackColor = false;
            // 
            // btnPIDValues
            // 
            this.btnPIDValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPIDValues.FlatAppearance.BorderSize = 0;
            this.btnPIDValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPIDValues.Image = global::HEMA_Program.Properties.Resources.icons8_data_sheet_search_28;
            this.btnPIDValues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPIDValues.Location = new System.Drawing.Point(300, 0);
            this.btnPIDValues.Margin = new System.Windows.Forms.Padding(0);
            this.btnPIDValues.Name = "btnPIDValues";
            this.btnPIDValues.Size = new System.Drawing.Size(100, 50);
            this.btnPIDValues.TabIndex = 3;
            this.btnPIDValues.Text = "PID Values";
            this.btnPIDValues.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPIDValues.UseVisualStyleBackColor = false;
            // 
            // btnRawData
            // 
            this.btnRawData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRawData.FlatAppearance.BorderSize = 0;
            this.btnRawData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRawData.Image = global::HEMA_Program.Properties.Resources.icons8_new_document_28;
            this.btnRawData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRawData.Location = new System.Drawing.Point(400, 0);
            this.btnRawData.Margin = new System.Windows.Forms.Padding(0);
            this.btnRawData.Name = "btnRawData";
            this.btnRawData.Size = new System.Drawing.Size(100, 50);
            this.btnRawData.TabIndex = 4;
            this.btnRawData.Text = "Raw Data";
            this.btnRawData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRawData.UseVisualStyleBackColor = false;
            // 
            // btnConsole
            // 
            this.btnConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsole.FlatAppearance.BorderSize = 0;
            this.btnConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsole.Image = global::HEMA_Program.Properties.Resources.icons8_console_28;
            this.btnConsole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsole.Location = new System.Drawing.Point(500, 0);
            this.btnConsole.Margin = new System.Windows.Forms.Padding(0);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(100, 50);
            this.btnConsole.TabIndex = 5;
            this.btnConsole.Text = "Console";
            this.btnConsole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsole.UseVisualStyleBackColor = false;
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
            this.panelMain.ResumeLayout(false);
            this.tabpanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tabpanelMenu;
        private System.Windows.Forms.Button btnTroubleCodes;
        private System.Windows.Forms.Button btnFreezeFrame;
        private System.Windows.Forms.Button btnMonitorTests;
        private System.Windows.Forms.Button btnPIDValues;
        private System.Windows.Forms.Button btnRawData;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Panel panelForm;
    }
}