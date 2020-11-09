using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox {
    public partial class ComboBoxForm : Form {
        public ComboBoxForm()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics graphics = base.CreateGraphics();
            Pen pen = new Pen(Color.DarkRed);
            SolidBrush solidBrush = new SolidBrush(Color.DarkRed);
            graphics.Clear(Color.White);

            switch (ImageComboBox.SelectedIndex)
            {
                case 0:
                    graphics.DrawEllipse(pen, 50, 50, 150, 150);
                    break;

                case 1:
                    graphics.DrawRectangle(pen, 50, 50, 150, 150);
                    break;

                case 2:
                    graphics.DrawEllipse(pen, 50, 85, 150, 115);
                    break;

                case 3:
                    graphics.DrawPie(pen, 50, 50, 150, 150, 0, 45);
                    break;

                case 4:
                    graphics.FillEllipse(solidBrush, 50, 50, 150, 150);
                    break;

                case 5:
                    graphics.FillRectangle(solidBrush, 50, 50, 150, 150);
                    break;

                case 6:
                    graphics.FillEllipse(solidBrush, 50, 85, 150, 115);
                    break;

                case 7:
                    graphics.FillPie(solidBrush, 50, 50, 150, 150, 0, 45);
                    break;
            }
        }
    }
}
