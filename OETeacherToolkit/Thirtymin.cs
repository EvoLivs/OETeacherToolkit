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
    public partial class Thirtymin : Form
    {
        float timer = 0;
        float countDown = 50;
        public Thirtymin() 
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //STOP
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //RESET
            countDown = 1800;
            textBox1.BackColor = Color.Wheat;
            textBox1.Text = countDown.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //START
            countDown = float.Parse(textBox1.Text);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //COUNT UP TIMER
            countDown -= timer1.Interval * 0.001f;
            textBox1.Text = countDown.ToString("0.00");
            if (countDown < 5)
            {
                textBox1.BackColor = Color.OrangeRed;
            }
        }
    }
}
