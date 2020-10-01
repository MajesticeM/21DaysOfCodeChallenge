using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CInterest
    {
        private double principalamount;
        private double numberofyears;
        private double interestrate;
        public CInterest()
        {
          
        }
        public double CompoundInterestFormula()
        {
           double pa = principalamount;
            double noy = numberofyears;
            double ir = interestrate;
            double result = pa * (1 + ir*noy)*(1 + ir*noy);
            return result;
        }
        public double SimpleInterestFormula(double pa, double noy, double ir)
        {
            //pa = principalamount;
            //noy = numberofyears;
            //ir = interestrate;
            double result = pa*(1 + ir /100* noy);
            return result;
        }
    }
}
