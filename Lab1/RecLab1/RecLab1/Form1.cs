using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace RecLab1
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            InitializeLabelStates();
            InitializeSerialPort();
        }

        private void InitializeLabelStates()
        {
            foreach (var labelName in new[] { "F1", "F2", "F3", "F4", "P1", "P2", "P3", "P4", "P5" })
            {
                var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.BackColor = Color.Red; // Estado cerrado por defecto
                }
            }
        }

        private void InitializeSerialPort()
        {
            serialPort = new SerialPort
            {
                BaudRate = 9600,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None
            };

            serialPort.DataReceived += SerialPort_DataReceived;

            // Configurar el nombre del puerto COM
            serialPort.PortName = "COM2"; // Cambia esto según sea necesario

            try
            {
                serialPort.Open();
                MessageBox.Show("Port opened successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytesToRead = serialPort.BytesToRead;
            byte[] receivedBytes = new byte[bytesToRead];
            serialPort.Read(receivedBytes, 0, bytesToRead);
            ProcessReceivedData(receivedBytes);
        }

        //private void ProcessReceivedData(byte[] data)
        //{
        //    if (data.Length < 3) return;

        //    int type = data[0];
        //    int number = data[1];
        //    int state = data[2];

        //    this.Invoke(new Action(() =>
        //    {
        //        Label targetLabel = null;

        //        if (type == 0)
        //        {
        //            targetLabel = this.Controls.Find($"F{number + 1}", true).FirstOrDefault() as Label;
        //        }
        //        else if (type == 1)
        //        {
        //            targetLabel = this.Controls.Find($"P{number + 1}", true).FirstOrDefault() as Label;
        //        }

        //        if (targetLabel != null)
        //        {
        //            targetLabel.BackColor = state == 1 ? Color.Green : Color.Red;
        //        }
        //    }));
        //}
        private void ProcessReceivedData(byte[] data)
        {
            if (data.Length < 3) return;

            int type = data[0];
            int number = data[1];
            int state = data[2];

            MessageBox.Show($"Data received: Type {type}, Number {number}, State {state}");

            this.Invoke(new Action(() =>
            {
                Label targetLabel = null;

                if (type == 0)
                {
                    targetLabel = this.Controls.Find($"F{number + 1}", true).FirstOrDefault() as Label;
                }
                else if (type == 1)
                {
                    targetLabel = this.Controls.Find($"P{number + 1}", true).FirstOrDefault() as Label;
                }

                if (targetLabel != null)
                {
                    targetLabel.BackColor = state == 1 ? Color.Green : Color.Red;
                }
                else
                {
                    MessageBox.Show("Label not found.");
                }
            }));
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            base.OnFormClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
