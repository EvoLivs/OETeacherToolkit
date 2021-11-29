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
    public partial class Studentpick : Form
    {
        public Studentpick()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (listBox1.Items.Count > 0)
            {
                int studentNum = rnd.Next(0, listBox1.Items.Count);
                textBox1.Text = listBox1.Items[studentNum].ToString();

                listBox1.Items.RemoveAt(studentNum);
            }
            else
            {
                MessageBox.Show("Please add students!!!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox3.AppendText(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
