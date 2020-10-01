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

    public partial class Form1 : Form 
    { 
        //Global variable
        static bool CanCallCalculator;
      

        public Form1()
        {
            InitializeComponent();
            //Setting the CanCallCalculator variable to true at first.The variable is initially true
            CanCallCalculator = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //Calling the Timer class with all its properties and its methods
            //The first line of code will instantiate the Timer class
                Timer timer1 = new Timer();
                timer1.Interval = (1 * 3 * 1000);//This is a basic calculation of the timer which will have a duration of 5 seconds
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();//The timer will start to make its calculation

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
           
            //the if statement will then call the CanCallCalculator to true so that it can be incorrect at the end of the code to cancel the reiteration of 
            //the pop up calculator
            if (CanCallCalculator == true)
            {
                //Calling the calculator class so that it can be displayed as the second screen
                Calculator cal = new Calculator();
                //The .Show() method will display the calculator screen
                
                cal.Show();
                this.Hide();
                //this will prove the if statement wrong and it will cancel reiteration
                CanCallCalculator = false;
               
            }
           
        }
    }
}
