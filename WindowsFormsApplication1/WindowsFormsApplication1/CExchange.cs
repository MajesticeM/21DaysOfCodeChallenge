using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CExchange
    {
        //Declaring global variables to be mentioned in the code that follows
        private double numtobecounted;
        private double usdzar;
        private double eurzar;
        private double poundzar;
        private double yenzar;
        private double zarusd;
        private double zarpound;
        private double zaryen;
        private double zareur;
        //Creaing a constructor
        public CExchange()
        {
            //defining the global variables in the constructor
            double nmbtc=numtobecounted;
            usdzar = 13.49;
            eurzar = 14.35;
            poundzar = 16.91;
            yenzar = 0.12;
            zarusd = 0.075;
            zarpound = 0.059;
            zaryen = 8.09;
            zareur = 0.071;
        }
        //creating a property to ensure so that the object instantated can can have validateed values 
        public double NumtoBecounted{ get; set; }

        //The next four methods are for the conversions created from foreign exchange to the rand
        public double Conversion1(double numtobecounted)
        {
           
            double convert = numtobecounted * usdzar;
            return convert;
        }
        public double Conversion2(double numtobecounted)
        {
       
            double convert2 = numtobecounted * eurzar;
            return convert2;
        }
        public double Conversion3(double numtobecounted)
        {
           
            double convert3 = numtobecounted * poundzar;
            return convert3;
        }
        public double Conversion4(double numtobecounted)
        {
            
            double convert4 = numtobecounted * yenzar;
            return convert4;
        }
        //The next four methods are for the conversion from rand to foreign currency
        public double Inversion1zareur(double numtobecounted)
        {
            double invert1 = zareur * numtobecounted;
            return invert1;
        }
        public double Inversion2zarusd(double numtobecounted)
        {
            double invert2 = zarusd * numtobecounted;
            return invert2;
        }
        public double Inversion3zarpound(double numtobecounted)
        {
            double invert3 = numtobecounted * zarpound;
            return invert3;
        }
        public double Inversion4zaryen(double numtobecounted)
        {
            double invert4 = numtobecounted * zaryen;
            return invert4;
        }
    }
}
