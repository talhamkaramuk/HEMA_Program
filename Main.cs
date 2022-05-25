using HEMA_Program.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HEMA_Program
{
    public partial class Main : Form
    {
        // Fields
        private Form currentChildForm;
        private Button currentButton;
        private Panel buttonRightBorder;

        public Main()
        {
            InitializeComponent();
            buttonRightBorder = new Panel();
            buttonRightBorder.Size = new Size(7, 60);
            panelSide.Controls.Add(buttonRightBorder);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            OpenChildForm(new Home());
        }

        #region Activate Button
        private void ActiveButton(object sender)
        {
            if (sender != null)
            {
                DeactiveButton();

                currentButton = (Button)sender;
                currentButton.BackColor = Color.FromArgb(199, 200, 201);
                currentButton.ForeColor = Color.FromArgb(0, 0, 0);

                buttonRightBorder.BackColor = Color.FromArgb(236, 60, 60);
                buttonRightBorder.Location = new Point(174, currentButton.Location.Y);
                buttonRightBorder.Visible = true;
                buttonRightBorder.BringToFront();

                lblTitle.Text = (string)currentButton.Tag;
            }
        }
        #endregion

        #region Deactivate Button
        private void DeactiveButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(255, 255, 255);
                currentButton.ForeColor = Color.FromArgb(61, 61, 61);
            }
        }
        #endregion

        #region Open/Close Menu
        private void CollapseMenu()
        {
            if (panelSide.Width >= 180)
            {
                panelSide.Width = 80;
                pboxLogo.Visible = false;
                buttonRightBorder.Visible = false;

                foreach (Button btn in panelSide.Controls.OfType<Button>())
                {
                    btn.Text = "";

                }
            }
            else
            {
                panelSide.Width = 180;
                pboxLogo.Visible = true;
                buttonRightBorder.Visible = true;

                foreach (Button btn in panelSide.Controls.OfType<Button>())
                {
                    btn.Text = btn.Tag.ToString();
                }
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

        #region Menu Buttons Clicks
        private void btnCollapse_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Home());
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Setup());
        }

        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Diagnostic());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Dashboard());
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            OpenChildForm(new Logs());
        }
        #endregion
    }
}
