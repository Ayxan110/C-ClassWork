using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        decimal firstNum = 0;
        decimal secondNum = 0;
        decimal result;
        char symbol;
        bool isTrue;

        public Form1()
        {
            InitializeComponent();
        }

        private void calconsole_Click(object sender, EventArgs e)
        {
            calconsole.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isTrue){
                calconsole.Clear();
                calconsole.Text += button1.Text;
                isTrue = false;
            }
            else{
                calconsole.Text += button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(isTrue){
                calconsole.Clear();
                calconsole.Text += button2.Text;
                isTrue = false;
            }
            else{
                calconsole.Text += button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(isTrue){
                calconsole.Clear();
                calconsole.Text += button3.Text;
                isTrue = false;
            }
            else{
                calconsole.Text += button3.Text;
            }
        }
         
        private void button4_Click(object sender, EventArgs e)
        {
            if(isTrue){
                calconsole.Clear();
                calconsole.Text += button4.Text;
                isTrue = false;
            }
            else{
                calconsole.Text += button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(isTrue){
                calconsole.Clear();
                calconsole.Text += button5.Text;
                isTrue = false;
            }
            else{
                calconsole.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(isTrue){
                calconsole.Clear();
                calconsole.Text += button6.Text;
                isTrue = false;
            }
            else{
                calconsole.Text += button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(isTrue){
                calconsole.Clear();
                calconsole.Text += button7.Text;
                isTrue = false;
            }
            else{
                calconsole.Text += button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(isTrue){
                calconsole.Clear();
                calconsole.Text += button8.Text;
                isTrue = false;
            }
            else{
                calconsole.Text += button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(isTrue){
                calconsole.Clear();
                calconsole.Text += button9.Text;
                isTrue = false;
            }
            else{
                calconsole.Text += button9.Text;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(isTrue){
                calconsole.Clear();
                calconsole.Text += button0.Text;
                isTrue = false;
            }
            else{
                calconsole.Text += button0.Text;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            firstNum += decimal.Parse(calconsole.Text);
            symbol = '+';
            isTrue = true;
        }
        private void sub_Click(object sender, EventArgs e)
        {
            firstNum = decimal.Parse(calconsole.Text);
            symbol = '-'; 
            isTrue = true;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            firstNum = decimal.Parse(calconsole.Text);
            symbol = '*';
            isTrue = true;
        }

        private void div_Click(object sender, EventArgs e)
        {
            firstNum = decimal.Parse(calconsole.Text);
            symbol = '/';
            isTrue = true;
        }
        
        private void calculate_Click(object sender, EventArgs e)
        {
            secondNum = decimal.Parse(calconsole.Text);
            switch (symbol)
            {
                case '+': result = firstNum + secondNum; break;
                case '-': result = firstNum - secondNum; break;
                case '*': result = firstNum * secondNum; break;
                case '/': result = firstNum / secondNum; break;
            }
            calconsole.Text = result.ToString();
        }

        private void c_Click(object sender, EventArgs e)
        {
            secondNum = 0;
            firstNum = 0;
            symbol = ' ';
            calconsole.Clear();
            result = 0;
        }
    }
}
