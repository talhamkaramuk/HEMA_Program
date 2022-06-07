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
            //ActiveButton(btnTroubleCodes);
            //OpenChildForm(new TroubleCodes());
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
    }
}
