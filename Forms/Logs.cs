using HEMA_Program.Forms.LogsForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEMA_Program.Forms
{
    public partial class Logs : Form
    {
        // Fields
        private Form currentChildForm;
        private Button currentButton;

        public Logs()
        {
            InitializeComponent();
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            ActiveButton(btnPlots);
            OpenChildForm(new Plots());
        }

        #region Activate Button
        private void ActiveButton(object sender)
        {
            if (sender != null)
            {
                DeactiveButton();

                currentButton = (Button)sender;
                currentButton.BackColor = Color.FromArgb(199, 200, 201);
            }
        }
        #endregion

        #region Deactivate Button
        private void DeactiveButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromName("Control");
            }
        }
        #endregion

        #region Open Child Form
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        #region Button Click Events
        private void btnPlots_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Plots());
        }

        private void btnPlotConfig_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new PlotsConfig());
        }

        private void btnDataLogging_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new DataLogging());
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Stats());
        }
        #endregion
    }
}
