using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudyClass
{
    public class UnitConverter
    {
        // Field 
        int ratio;
        // Constructor 
        public UnitConverter(int unitRatio)
        {
            ratio = unitRatio;
        }
        // Method
        public int Convert(int unit)
        {
            return unit * ratio;
        }
        public static int FeetToInches(int feet)
        {
            int inches = feet * 120;
            return inches;
        }
    }
}
