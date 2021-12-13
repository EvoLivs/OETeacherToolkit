﻿using System;
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
    public partial class Interval : Form
    {
        float timer = 0;

        int timerPointer = 0;
        public Interval()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             float currentTime = float.Parse(listBox1.Items[timerPointer].ToString());
            currentTime -= timer1.Interval * 0.001f;
            listBox1.Items[timerPointer] = currentTime.ToString("0.0");

            if (currentTime < 0)
            {   
                listBox1.Items[timerPointer] = "0";
                if (timerPointer < listBox1.Items.Count-1) { timerPointer++;  }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Interval_Load(object sender, EventArgs e)
        {

        }
    }
}
