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
    public partial class Timer : Form
    {
        float timer = 0;
        public Timer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //STOP
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //RESET
            timer = 0;
            textBox1.Text = timer1.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //COUNT UP TIMER
            timer += timer1.Interval * 0.001f;
            textBox1.Text = "Time Elapsed: " + timer.ToString("0.0");
        }
    }
}
