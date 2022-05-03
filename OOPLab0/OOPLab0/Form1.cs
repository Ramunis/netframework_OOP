using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PercentLibrary.Calc;

namespace OOPLab0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PercentLibrary.Calc s1 = new PercentLibrary.Calc(0,Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            label1.Text = Convert.ToString(s1.sum());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PercentLibrary.Calc test = new PercentLibrary.Calc(0, Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            test.test(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), test.sum());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PercentLibrary.Calc v1 = new PercentLibrary.Calc(Convert.ToDouble(textBox3.Text), 0, Convert.ToDouble(textBox4.Text));
            label4.Text = Convert.ToString(v1.val());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PercentLibrary.Calc2 p1 = new PercentLibrary.Calc2(Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text),0);
            label7.Text = Convert.ToString(p1.per());

        }

        private void Override_Click(object sender, EventArgs e)
        {
            PercentLibrary.Calc2 test1 = new PercentLibrary.Calc2(0,0,0);
            test1.test();

        }
    }
}
