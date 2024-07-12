using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labo1
{
    public partial class Form_StateDisplay : Form
    {
        public Label lbl_Fenetre1;
        public Label lbl_Fenetre2;
        public Label lbl_Fenetre3;
        public Label lbl_Fenetre4;

        public Form_StateDisplay()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lbl_Fenetre1 = new Label();
            this.lbl_Fenetre2 = new Label();
            this.lbl_Fenetre3 = new Label();
            this.lbl_Fenetre4 = new Label();
            this.SuspendLayout();
            // 
            // lbl_Fenetre1
            // 
            this.lbl_Fenetre1.AutoSize = true;
            this.lbl_Fenetre1.Location = new System.Drawing.Point(13, 13);
            this.lbl_Fenetre1.Name = "lbl_Fenetre1";
            this.lbl_Fenetre1.Size = new System.Drawing.Size(100, 17);
            this.lbl_Fenetre1.TabIndex = 0;
            this.lbl_Fenetre1.Text = "Ventana 1: Cerrada";
            this.lbl_Fenetre1.BackColor = Color.Red;
            // 
            // lbl_Fenetre2
            // 
            this.lbl_Fenetre2.AutoSize = true;
            this.lbl_Fenetre2.Location = new System.Drawing.Point(13, 40);
            this.lbl_Fenetre2.Name = "lbl_Fenetre2";
            this.lbl_Fenetre2.Size = new System.Drawing.Size(100, 17);
            this.lbl_Fenetre2.TabIndex = 1;
            this.lbl_Fenetre2.Text = "Ventana 2: Cerrada";
            this.lbl_Fenetre2.BackColor = Color.Red;
            // 
            // lbl_Fenetre3
            // 
            this.lbl_Fenetre3.AutoSize = true;
            this.lbl_Fenetre3.Location = new System.Drawing.Point(13, 67);
            this.lbl_Fenetre3.Name = "lbl_Fenetre3";
            this.lbl_Fenetre3.Size = new System.Drawing.Size(100, 17);
            this.lbl_Fenetre3.TabIndex = 2;
            this.lbl_Fenetre3.Text = "Ventana 3: Cerrada";
            this.lbl_Fenetre3.BackColor = Color.Red;
            // 
            // lbl_Fenetre4
            // 
            this.lbl_Fenetre4.AutoSize = true;
            this.lbl_Fenetre4.Location = new System.Drawing.Point(13, 94);
            this.lbl_Fenetre4.Name = "lbl_Fenetre4";
            this.lbl_Fenetre4.Size = new System.Drawing.Size(100, 17);
            this.lbl_Fenetre4.TabIndex = 3;
            this.lbl_Fenetre4.Text = "Ventana 4: Cerrada";
            this.lbl_Fenetre4.BackColor = Color.Red;
            // 
            // Form_StateDisplay
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_Fenetre4);
            this.Controls.Add(this.lbl_Fenetre3);
            this.Controls.Add(this.lbl_Fenetre2);
            this.Controls.Add(this.lbl_Fenetre1);
            this.Name = "Form_StateDisplay";
            this.Text = "Estado de Ventanas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
