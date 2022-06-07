using HEMA_Program.Properties;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace HEMA_Program.Forms.SetupForms
{
    public partial class Connection : Form
    {
        private bool _connected = Settings.Default.comConn;

        public static bool con;

        public Connection()
        {
            InitializeComponent();
            con = false;
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cboxCOMPorts.Items.Add(port);
            }
            tboxBaudRate.Enabled = false;
            cboxCOMPorts.Text = Settings.Default.comPort;
            cboxBaudRate.Text = Settings.Default.baudRate;
            tboxBaudRate.Text = Settings.Default.baudRate;
            btnDisconnect.Enabled = false;
        }

        #region Connect / Disconnect
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = cboxCOMPorts.Text;
                if (cboxBaudRate.Enabled && !tboxBaudRate.Enabled)
                {
                    serialPort.Close();
                    serialPort.BaudRate = Convert.ToInt32(cboxBaudRate.Text);
                    Settings.Default.baudRate = cboxBaudRate.Text;
                    serialPort.Open();
                    con = true;
                }
                if (!cboxBaudRate.Enabled && tboxBaudRate.Enabled)
                {
                    serialPort.Close();
                    serialPort.BaudRate = Convert.ToInt32(tboxBaudRate.Text);
                    Settings.Default.baudRate = tboxBaudRate.Text;
                    serialPort.Open();
                }
                if (serialPort.IsOpen)
                {
                    Settings.Default.comPort = cboxCOMPorts.Text;
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    cboxCOMPorts.Enabled = false;
                    cboxBaudRate.Enabled = false;
                    tboxBaudRate.Enabled = false;
                    chboxBaudRate.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    btnConnect.Enabled = true;
                    btnDisconnect.Enabled = false;
                    cboxCOMPorts.Enabled = true;
                    cboxBaudRate.Enabled = true;
                    tboxBaudRate.Enabled = true;
                    chboxBaudRate.Enabled = true;
                    con = false;
                }
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Handle Baud Rate
        private void chboxBaudRate_CheckedChanged(object sender, EventArgs e)
        {
            if (!chboxBaudRate.Checked)
            {
                cboxBaudRate.Enabled = true;
                tboxBaudRate.Enabled = false;
            }
            if (chboxBaudRate.Checked)
            {
                cboxBaudRate.Enabled = false;
                tboxBaudRate.Enabled = true;
            }
        }

        private void tboxBaudRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void Connection_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            Settings.Default.Save();
        }
    }
}
