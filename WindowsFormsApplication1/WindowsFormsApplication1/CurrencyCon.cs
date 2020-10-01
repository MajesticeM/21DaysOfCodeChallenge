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
    public partial class CurrencyCon : Form
    {
        
        public CurrencyCon()
        {
            InitializeComponent();
        }

        private void CurrencyCon_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string text = textBox1_eurzar.Text;
            //text = Convert.ToString(double.Parse(textBox1_eurzar.Text));
            //CExchange Eurzar = new CExchange();
            //Eurzar.Conversion2();
            //textBox5_zareur.Text = textBox1_eurzar.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declare variable that converts the  textbox from string to double
            double num1text = double.Parse(textBox1_eurzar.Text);
            //Call the CExchange class to get all the methods,properties and constuctors of the class.
            CExchange ce = new CExchange();
            //creating a variable that will hold the method
         double result=ce.Conversion2(num1text);
            //Convering the result o string so that it can be visible on the textbox
            textBox5_zareur.Text = result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num2text = double.Parse(textBox2_poundzar.Text);
            CExchange cp = new CExchange();
            double result = cp.Conversion3(num2text);
            textBox4_zarpound.Text = result.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double num3text = double.Parse(textBox3_usdzar.Text);
            CExchange cu = new CExchange();
            double result = cu.Conversion1(num3text);
            textBox6_zarusd.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num4text = double.Parse(textBox7_yenzar.Text);
            CExchange cy = new CExchange();
            double result = cy.Conversion4(num4text);
            textBox8_zaryen.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double num5text = double.Parse(textBox5_zareur.Text);
            CExchange ec = new CExchange();
            double result = ec.Inversion1zareur(num5text);
            textBox1_eurzar.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double num6text = double.Parse(textBox4_zarpound.Text);
            CExchange pc = new CExchange();
            double result = pc.Inversion3zarpound(num6text);
            textBox2_poundzar.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double num7text = double.Parse(textBox6_zarusd.Text);
            CExchange uc = new CExchange();
            double result = uc.Inversion2zarusd(num7text);
            textBox3_usdzar.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double num8text = double.Parse(textBox8_zaryen.Text);
            CExchange yc = new CExchange();
            double result = yc.Inversion4zaryen(num8text);
            textBox7_yenzar.Text = result.ToString();
        }
    }
}
