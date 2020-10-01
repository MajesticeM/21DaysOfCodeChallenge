using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class BubbleSortArray
    {
        //Defining the data fields for the array 
       // public static int num1;
       //public static int num2;
       //public static int num3;
       //public static int num4;
       //public static int num5;
       //public static int num6;
       // public static int num7;
       // public static int num8;
       // public static int num9;
       // public static int num10;
       //public static int num11;
       //public static int num12;
       // public static int num13;
       //public static int num14;
       // public static int num15;
       //public static int num16;
       //public static int num17;
       //public static int num18;
       //public static int num19;
       //public static int num20;
        //Defining an array
        public void Bsort(int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8, int num9, int num10, int num11, int num12, int num13, int num14, int num15, int num16, int num17, int num18, int num19, int num20)
        {
            int[] bubblesort = { num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, num15, num16, num17, num18, num19, num20 };
            int jerr;
            for (int i = 0; i <=bubblesort.Length-2; i++)
            {
                for (int j = 0; j <=bubblesort.Length-2; j++)
                {
                    if (bubblesort[i]>bubblesort[i+1])
                    {
                        jerr = bubblesort[i + 1];
                        bubblesort[i + 1] = bubblesort[i];
                        bubblesort[i] = jerr;
                    }
                }
            }
            
          
            //foreach (int ff in bubblesort)
            //{
                
            //}
      
        }
      
    }
}
