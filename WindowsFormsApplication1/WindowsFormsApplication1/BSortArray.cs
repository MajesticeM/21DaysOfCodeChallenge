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
    public partial class BSortArray : Form
    {
       
       
        public BSortArray()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_SortNumbers_Click(object sender, EventArgs e)
        {
            int txt1 = int.Parse(textBox1.Text);
            int txt2 = int.Parse(textBox2.Text);
            int txt3 = int.Parse(textBox3.Text);
            int txt4 = int.Parse(textBox4.Text);
            int txt5 = int.Parse(textBox5.Text);
            int txt6 = int.Parse(textBox6.Text);
            int txt7 = int.Parse(textBox7.Text);
            int txt8 = int.Parse(textBox8.Text);
            int txt9 = int.Parse(textBox9.Text);
            int txt10 = int.Parse(textBox10.Text);
            int txt11 = int.Parse(textBox12.Text);
            int txt12 = int.Parse(textBox13.Text);
            int txt13 = int.Parse(textBox14.Text);
            int txt14 = int.Parse(textBox15.Text);
            int txt15 = int.Parse(textBox16.Text);
            int txt16 = int.Parse(textBox17.Text);
            int txt17 = int.Parse(textBox18.Text);
            int txt18 = int.Parse(textBox19.Text);
            int txt19 = int.Parse(textBox20.Text);
            int txt20 = int.Parse(textBox21.Text);
            BubbleSortArray bubble = new BubbleSortArray();
          
            //textBox11_Answer.Text = bubble.Bsort(txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10, txt11, txt12, txt13, txt14, txt15, txt16, txt17, txt18, txt19, txt20).ToString();
        }
    }
}
