using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string caltotal;
        int num1;
        int num2;
        string option;
        int result;
        private void button1_Click(object sender, EventArgs e)
        {
            txTotal.Text = txTotal.Text + button1.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txTotal.Text = txTotal.Text + button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txTotal.Text = txTotal.Text + button2.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txTotal.Text = txTotal.Text + button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txTotal.Text = txTotal.Text + button4.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txTotal.Text = txTotal.Text + button10.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txTotal.Text = txTotal.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txTotal.Text = txTotal.Text + button9.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txTotal.Text = txTotal.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txTotal.Text = txTotal.Text + button7.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            option = "+";
            num1=int.Parse(txTotal.Text);
            txTotal.Clear();    
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txTotal.Text);
            txTotal.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txTotal.Text);
            txTotal.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txTotal.Text);
            txTotal.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2= int.Parse(txTotal.Text);
            if (option.Equals("+")) result = num1 + num2;
            if (option.Equals("-")) result = num1 - num2;
            if (option.Equals("*")) result = num1 * num2;
            if (option.Equals("/")) result = num1 / num2;
            txTotal.Text = result + "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);   
        }
    }
}
