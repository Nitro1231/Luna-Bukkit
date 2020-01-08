using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LunaBukkit.Controls {
    public partial class CircleProgressBar : UserControl {
        public int value = 0;
        public int colorThickness = 5;
        public int insideThickness = 5;

        public CircleProgressBar() {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void CircleProgressBar_Paint(object sender, PaintEventArgs e) {
            draw(e.Graphics, value);
        }

        private void draw(Graphics g, float percent) {
            Color c;
            if (percent <= 50)
                c = Color.FromArgb(46, 204, 113);
            else if (percent <= 85)
                c = Color.FromArgb(241, 196, 15);
            else
                c = Color.FromArgb(231, 76, 60);

            float calculatedAngle = 360 / 100 * percent;
            float remainderAngle = 360 - calculatedAngle;

            Pen calculatedPen = new Pen(c, colorThickness);
            Pen remainderPen = new Pen(Class.Setting.darkBackColor, insideThickness);
            Rectangle rect = new Rectangle(5, 5, Width - 5, Height - 5);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawArc(calculatedPen, rect, -90, calculatedAngle);
            g.DrawArc(remainderPen, rect, calculatedAngle - 90, remainderAngle);

            Font ft = new Font(Font.FontFamily, 14);
            string text = percent.ToString() + "%";
            SizeF textSize = g.MeasureString(text, ft);
            Point textLocation = new Point((int)Math.Round(rect.Left + rect.Width / 2 - textSize.Width / 2), (int)Math.Round(rect.Top + rect.Height / 2 - textSize.Height / 2));
            Brush brush = new SolidBrush(Class.Setting.fontColor);
            g.DrawString(text, ft, brush, textLocation);
        }
    }
}
