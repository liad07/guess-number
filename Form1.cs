using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gusssthenum
{
    public partial class Form1 : Form
    {
       static Random rnd = new Random();
        static int num = rnd.Next(1, 100);

        public Form1()
        {
            InitializeComponent();
          

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox2.Text = num.ToString();
            if (num.ToString() == textBox1.Text)
            {
                label1.Text = "corecect";
                label1.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}
