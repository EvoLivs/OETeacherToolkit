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
    public partial class Dice : Form
    {
        public Dice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = rnd.Next(1, 7).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox2.Text = rnd.Next(1, 9).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
