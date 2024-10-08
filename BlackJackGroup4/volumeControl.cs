using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGroup4
{
    public partial class VolumeControl: UserControl
    {
        public VolumeControl()
        {
            InitializeComponent();
            this.Size = new Size(350, 30);
            this.BackColor = Color.Black;
            DoubleBuffered = true;
        }
        int pb_value = 40, pb_Min = 0, pb_Max = 100;
        public int Max { get { return pb_Max; } set { pb_Max = value; Invalidate(); } }
        public int Min { get { return pb_Min; } set { pb_Min = value; Invalidate(); } }
        public int Value { get { return pb_value; } set { pb_value = value; Invalidate(); } }
        public int gap = 10;

        private void Volume_control_Paint(object sender, PaintEventArgs e)
        {
            int numberOfBars = (ClientSize.Width - 40) / gap;
            int startX = 40;
            SolidBrush sb = new SolidBrush(Color.DimGray);

            for (int i = 0; i < numberOfBars; i++)
            {
                e.Graphics.FillRectangle(sb, new Rectangle(startX, 0, gap - 5, ClientSize.Height));
                startX += gap;
            }
        }


    }
}
