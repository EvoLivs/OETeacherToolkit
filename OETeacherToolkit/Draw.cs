using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OETeacherToolkit
{
    public partial class Draw : Form
    {
        int x = 100;
        int y = 100;
        int xv = 10;
        int yv = 10;
        public Draw()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += xv;
            y += yv;
            if (x < 0 || x +50 > pictureBox1.Width) { xv *= -1; }
            if (y < 0 || y +50> pictureBox1.Height) { yv *= -1; }

            Refresh();

        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 1);

            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush greenBrush = new SolidBrush(Color.Green);

            e.Graphics.FillRectangle(whiteBrush, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));

            e.Graphics.DrawEllipse(blackPen, new Rectangle(x, y, 50, 50));
            e.Graphics.FillEllipse(greenBrush, new Rectangle(x, y, 50, 50));

        }

        private void Draw_Load(object sender, EventArgs e)
        {

        }
    }
}
