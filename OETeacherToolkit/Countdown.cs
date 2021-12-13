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
    public partial class Countdown : Form
    {

        public Countdown()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Fivemin form = new Fivemin();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tenmin form = new tenmin();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thirtymin form = new Thirtymin();
            form.Show();
        }

        private void Countdown_Load(object sender, EventArgs e)
        {

        }
    }
}
