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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dice form = new Dice();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer form = new Timer();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Countdown form = new Countdown();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Studentpick form = new Studentpick();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Interval form = new Interval();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Draw form = new Draw();
            form.Show();
        }
    }
}
