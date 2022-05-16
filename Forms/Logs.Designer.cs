namespace HEMA_Program.Forms
{
    partial class Logs
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
            this.btnDataLogging = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnPlots = new System.Windows.Forms.Button();
            this.btnPlotConfig = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.tabpanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.panelForm);
            this.panelMain.Controls.Add(this.panelMenu);
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
            this.tabpanelMenu.ColumnCount = 5;
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tabpanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tabpanelMenu.Controls.Add(this.btnDataLogging, 0, 0);
            this.tabpanelMenu.Controls.Add(this.btnStats, 0, 0);
            this.tabpanelMenu.Controls.Add(this.btnPlots, 0, 0);
            this.tabpanelMenu.Controls.Add(this.btnPlotConfig, 0, 0);
            this.tabpanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabpanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tabpanelMenu.Name = "tabpanelMenu";
            this.tabpanelMenu.RowCount = 1;
            this.tabpanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpanelMenu.Size = new System.Drawing.Size(600, 50);
            this.tabpanelMenu.TabIndex = 1;
            // 
            // btnDataLogging
            // 
            this.btnDataLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDataLogging.FlatAppearance.BorderSize = 0;
            this.btnDataLogging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataLogging.Image = global::HEMA_Program.Properties.Resources.icons8_data_backup_28;
            this.btnDataLogging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataLogging.Location = new System.Drawing.Point(186, 0);
            this.btnDataLogging.Margin = new System.Windows.Forms.Padding(0);
            this.btnDataLogging.Name = "btnDataLogging";
            this.btnDataLogging.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnDataLogging.Size = new System.Drawing.Size(120, 50);
            this.btnDataLogging.TabIndex = 5;
            this.btnDataLogging.Text = "Data Logging";
            this.btnDataLogging.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDataLogging.UseVisualStyleBackColor = false;
            this.btnDataLogging.Click += new System.EventHandler(this.btnDataLogging_Click);
            // 
            // btnStats
            // 
            this.btnStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Image = global::HEMA_Program.Properties.Resources.icons8_table_and_graph_28;
            this.btnStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStats.Location = new System.Drawing.Point(306, 0);
            this.btnStats.Margin = new System.Windows.Forms.Padding(0);
            this.btnStats.Name = "btnStats";
            this.btnStats.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnStats.Size = new System.Drawing.Size(84, 50);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "Stats";
            this.btnStats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnPlots
            // 
            this.btnPlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlots.FlatAppearance.BorderSize = 0;
            this.btnPlots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlots.Image = global::HEMA_Program.Properties.Resources.icons8_graph_report_28;
            this.btnPlots.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlots.Location = new System.Drawing.Point(0, 0);
            this.btnPlots.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlots.Name = "btnPlots";
            this.btnPlots.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnPlots.Size = new System.Drawing.Size(78, 50);
            this.btnPlots.TabIndex = 3;
            this.btnPlots.Text = "Plots";
            this.btnPlots.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlots.UseVisualStyleBackColor = false;
            this.btnPlots.Click += new System.EventHandler(this.btnPlots_Click);
            // 
            // btnPlotConfig
            // 
            this.btnPlotConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlotConfig.FlatAppearance.BorderSize = 0;
            this.btnPlotConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlotConfig.Image = global::HEMA_Program.Properties.Resources.icons8_edit_graph_report_28;
            this.btnPlotConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlotConfig.Location = new System.Drawing.Point(78, 0);
            this.btnPlotConfig.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlotConfig.Name = "btnPlotConfig";
            this.btnPlotConfig.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnPlotConfig.Size = new System.Drawing.Size(108, 50);
            this.btnPlotConfig.TabIndex = 2;
            this.btnPlotConfig.Text = "Plot Config";
            this.btnPlotConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlotConfig.UseVisualStyleBackColor = false;
            this.btnPlotConfig.Click += new System.EventHandler(this.btnPlotConfig_Click);
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 456);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Logs";
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.Logs_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.tabpanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.TableLayoutPanel tabpanelMenu;
        private System.Windows.Forms.Button btnDataLogging;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnPlots;
        private System.Windows.Forms.Button btnPlotConfig;
    }
}