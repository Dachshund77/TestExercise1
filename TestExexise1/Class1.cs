using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExexise1
{
    public class Class1
    {
        public static void Main(string[] args)
        {
        }

        public static double CalcPrice(double km)
        {
            if (Double.IsNegative(km))
            {
                return 0;
            }
            double returnValue = 2500;
            double remainingKm = km;

            remainingKm = Math.Floor(remainingKm);

            if (remainingKm > 500 )
            {
                double tempkm = remainingKm - 500; // Everything above 500 
                remainingKm -= tempkm;  
                returnValue += tempkm * 6; 
            } 
            
            if (remainingKm >= 100)
            {
                double tempkm = remainingKm - 99; // Everything above 100
                remainingKm -= tempkm;
                returnValue += tempkm * 8;
            }

            // Remainder 
            returnValue += remainingKm * 10;

            return returnValue;
        }
    }
}
