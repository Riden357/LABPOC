using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Labo1
{
    public partial class FormPortConfiguration : Form
    {
        public FormPortConfiguration()
        {
            InitializeComponent();
        }

        private void form_PortConfiguration_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbo_Ports.Items.AddRange(ports);
        }

        private void btn_OpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                string portName = cbo_Ports.Text;
                int baudRate = Convert.ToInt32(cbo_Bps.Text);
                int dataBits = Convert.ToInt32(cbo_Db.Text);
                StopBits stopBits = (StopBits)Enum.Parse(typeof(StopBits), cbo_StopBits.Text);
                Parity parity = (Parity)Enum.Parse(typeof(Parity), cbo_Parity.Text);

                SerialPortManager.Configure(portName, baudRate, dataBits, stopBits, parity);
                SerialPortManager.OpenPort();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ClosePort_Click(object sender, EventArgs e)
        {
            SerialPortManager.ClosePort();
        }
    }
}

