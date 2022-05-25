using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HEMA_Program.Forms
{
    public partial class Login : Form
    {
        // Fields
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;

        public Login()
        {
            InitializeComponent();
        }

        #region Username / Password Accept Onyl Digit
        private void tboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tboxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tboxUsername.Text;
            string password = tboxPassword.Text;
            conn = new SqlConnection("Data Source=CASPER;Initial Catalog=hema;Integrated Security=True");
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select * from users where username='" + username + "' and password='" + password + "'";
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {

            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

    }
}
