using HEMA_Program.Forms.SetupForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HEMA_Program.Forms
{
    public partial class Setup : Form
    {
        // Fields
        private Form currentChildForm;
        private Button currentButton;

        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            ActiveButton(btnConnection);
            OpenChildForm(new Connection());
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
                currentChildForm.Close();
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

        #region Menu Button Click Events
        private void btnConnection_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Connection());
        }

        private void btnPid_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new PIDSetup());
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new General());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Info());
        }
        #endregion
    }
}
