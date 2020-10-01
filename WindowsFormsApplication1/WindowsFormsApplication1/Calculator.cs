using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        //static bool ClearText;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        string result;
        char operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Number1_Click(object sender, EventArgs e)
        {
            //This is the Button variable 
            Button b = (Button)sender;
            //The b instance will then transfer it to text so that it can be displayed on the textbox 
            //The plus in front of the equal sign will make sure that you can create double digits etc
            textBox1.Text += b.Text;
        }

        private void button2_Number2_Click(object sender, EventArgs e)
        {
            //This is the Button variable 
            Button c = (Button)sender;
            //The b instance will then transfer it to text so that it can be displayed on the textbox 
            textBox1.Text += c.Text;
        }

        private void button3_Number3_Click(object sender, EventArgs e)
        {
            //This is the Button variable 
            Button d = (Button)sender;
            //The b instance will then transfer it to text so that it can be displayed on the textbox 
            textBox1.Text += d.Text;
        }

        private void button4_Number4_Click(object sender, EventArgs e)
        {
            //This is the Button variable 
            Button d= (Button)sender;
            //The b instance will then transfer it to text so that it can be displayed on the textbox 
            textBox1.Text += d.Text;
        }

        private void button5_Number5_Click(object sender, EventArgs e)
        {
            //This is the Button variable 
            Button b = (Button)sender;
            //The b instance will then transfer it to text so that it can be displayed on the textbox 
            textBox1.Text += b.Text;
        }

        private void button6_Number6_Click(object sender, EventArgs e)
        {
            //This is the Button variable 
            Button b = (Button)sender;
            //The b instance will then transfer it to text so that it can be displayed on the textbox 
            textBox1.Text += b.Text;
        }

        private void button7_Number7_Click(object sender, EventArgs e)
        {
            //This is the Button variable 
            Button b = (Button)sender;
            //The b instance will then transfer it to text so that it can be displayed on the textbox 
            textBox1.Text += b.Text;
        }

        private void button8_Number8_Click(object sender, EventArgs e)
        {
            //This is the Button variable 
            Button b = (Button)sender;
            //The b instance will then transfer it to text so that it can be displayed on the textbox 
            textBox1.Text += b.Text;
        }

        private void button9_Number9_Click(object sender, EventArgs e)
        {
            //This is the Button variable 
            Button b = (Button)sender;
            //The b instance will then transfer it to text so that it can be displayed on the textbox 
            textBox1.Text += b.Text;

        }

        private void button15_Number0_Click(object sender, EventArgs e)
        {
            //This is the Button variable 
            Button b = (Button)sender;
            //The b instance will then transfer it to text so that it can be displayed on the textbox 
            textBox1.Text += b.Text;
        }

        private void button10_Clear_Click(object sender, EventArgs e)
        {
            Button clear = (Button)sender;
            //This will return an empty string that will be displayd on the textbox
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button11_Plus_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '+';
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //operand two will display the end result of any case statement in the textbox
            operand2 = textBox1.Text;
            //declaring variables op1 and op2 so that we can use them in the  switch statement
            //string dot = ",";
            double op1;
            double op2;
            //Converting the above-mentioned variables to the global variables we created
            double.TryParse(operand1, out op1);
            double.TryParse(operand2, out op2);

            switch (operation)
            {
                case '+':
                    result = (op1 + op2).ToString();
                    //result = (op1 + "." + op2).ToString();
                    //result = (op1 + op2 + ".").ToString();
                    break;
                case '-':
                    result = (op1 - op2).ToString();
                    break;
                case '*':
                    result = (op1 * op2).ToString();
                    break;
                
                case '/':
                    if (op2!=0)
                    {
                        result = (op1 / op2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Can't divide by zero");
                    }
                    //The code below casts the object
                    
                  
                    break;
              
                default:
                    break;
            }
            textBox1.Text = result.ToString();
        }

        private void button12_Minus_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '-';
            textBox1.Text = string.Empty;
            //The code below casts the object
            Button btn = sender as Button;
            if (btn.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
                else
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }
        }

        private void button13_Multiply_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '*';
            textBox1.Text =string.Empty;
        }

        private void button14_Division_Click(object sender, EventArgs e)
        {
            operand1 = textBox1.Text;
            operation = '/';
            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            textBox1.Text += a.Text;
        }

        private void button1_InterestCalculator_Click(object sender, EventArgs e)
        {
            SimpleInterestCalculator simple = new SimpleInterestCalculator();
            simple.Show();
        }

        private void button2_ExchangeRateCalculator_Click(object sender, EventArgs e)
        {
            CurrencyCon curreny = new CurrencyCon();
            curreny.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutCalculator about = new AboutCalculator();
            about.Show();
        }
    }
}
