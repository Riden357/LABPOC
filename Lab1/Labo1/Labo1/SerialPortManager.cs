using System;
using System.IO.Ports;
using System.Windows.Forms;

public static class SerialPortManager
{
    private static SerialPort serialPort = new SerialPort();

    public static void Configure(string portName, int baudRate, int dataBits, StopBits stopBits, Parity parity)
    {
        if (serialPort.IsOpen)
        {
            serialPort.Close();
        }

        serialPort.PortName = portName;
        serialPort.BaudRate = baudRate;
        serialPort.DataBits = dataBits;
        serialPort.StopBits = stopBits;
        serialPort.Parity = parity;
    }

    public static void OpenPort()
    {
        try
        {
            if (!serialPort.IsOpen)
            {
                serialPort.Open();
                MessageBox.Show("Port opened successfully.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void ClosePort()
    {
        if (serialPort.IsOpen)
        {
            serialPort.Close();
            MessageBox.Show("Port closed successfully.");
        }
    }

    public static void SendMessage(byte[] message)
    {
        if (serialPort.IsOpen)
        {
            serialPort.Write(message, 0, message.Length);
            MessageBox.Show($"Data sent: {BitConverter.ToString(message)}");
        }
        else
        {
            MessageBox.Show("The serial port is not open.");
        }
    }
}
