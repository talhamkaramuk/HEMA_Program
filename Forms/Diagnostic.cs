using HEMA_Program.Forms.DiagForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HEMA_Program.Forms
{
    public partial class Diagnostic : Form
    {
        // Fields
        private Form currentChildForm;
        private Button currentButton;

        public Diagnostic()
        {
            InitializeComponent();
        }

        private void Diagnostic_Load(object sender, EventArgs e)
        {
            ActiveButton(btnTroubleCodes);
            OpenChildForm(new TroubleCodes());
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
        private void btnTroubleCodes_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new TroubleCodes());
        }

        private void btnFreezeFrame_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new FreezeFrame());
        }

        private void btnMonitorTests_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new MonitorTests());
        }

        private void btnPIDValues_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new PIDValues());
        }

        private void btnRawData_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new RawData());
        }
        #endregion
    }
}
