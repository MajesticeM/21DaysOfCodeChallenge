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
    public partial class SimpleInterestCalculator : Form
    {
        public SimpleInterestCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double principalamount = double.Parse(textBox1_PrincipalAmount.Text);
                double interestrate = double.Parse(textbox_InterestRate.Text);
                double numberofyears = double.Parse(Years.Text);
                CInterest si = new CInterest();
                double result = si.SimpleInterestFormula(principalamount, numberofyears, interestrate);
                textBox3_Answer.Text = result.ToString();
            }
            catch (Exception)
            {
                if (textBox3_Answer.Text=="")
                {
                    MessageBox.Show("Please enter digits in the boxes above!!");
                }
               
            }
           
        }

        private void Years_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void InterestRate_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void SimpleInterestCalculator_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double principalamount = double.Parse(textBox4_pa.Text);
                double numberofyears = double.Parse(textBox5_noy.Text);
                double interestrate = double.Parse(textBox6_ir.Text);
                CInterest ci = new CInterest();
                double result = ci.CompoundInterestFormula();
                textBox2_an.Text = result.ToString();
            }
            catch (Exception)
            {
                if (textBox2_an.Text=="")
                {
                    MessageBox.Show("Please enter digits in the boxes above!!");
                }
              
              
            }
           
        }
    }
}
