using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SIClass
    {
        private double principalAmount;
        private double interest;
        private double numberOfYears;


        public double SimpleInterest()
        {
            double AccumulatedAmount = principalAmount * (1 + interest * numberOfYears);
            return AccumulatedAmount;
        }
        public double PrincipalAmount { get; set; }
        public double Interest { get; set; }
        public double NumberOfYears { get; set; }

        public SIClass()
        {

        }
       
    }
}
