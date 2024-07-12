using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Labo1
{
    public partial class Form_Maison : Form
    {
        public Form_Maison()
        {
            InitializeComponent();
            InitializeLabelStates();
        }

        private void InitializeLabelStates()
        {
            foreach (var labelName in new[] { "F1", "F2", "F3", "F4", "P1", "P2", "P3", "P4","P5" })
            {
                var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.BackColor = Color.Red; 
                    label.Click += Label_Click; 
                }
            }
        }

        private void configurePortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPortConfiguration frm = new FormPortConfiguration();
            frm.ShowDialog();
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Byte[] MessageToSend = new byte[3];

            Label cible = (Label)sender;
            String cibleInfo = cible.Text;

            if (cibleInfo.Contains("F"))
            {
                MessageToSend[0] = 0; 
            }
            else if (cibleInfo.Contains("P"))
            {
                MessageToSend[0] = 1; 
            }

            Char id = cibleInfo[cibleInfo.Length - 1];
            int idi = int.Parse(id.ToString()) - 1; 
            MessageToSend[1] = Convert.ToByte(idi);

            if (cible.BackColor == Color.Green)
            {
                MessageToSend[2] = 0; 
                cible.BackColor = Color.Red;
            }
            else
            {
                MessageToSend[2] = 1; 
                cible.BackColor = Color.Green;
            }

            SerialPortManager.SendMessage(MessageToSend);
        }

        private void closePortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialPortManager.ClosePort();
        }
    }
}




