using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudyClass;

namespace ConsoleAppNetFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);
            Console.WriteLine(feetToInchesConverter.Convert(30));
            Console.WriteLine(feetToInchesConverter.Convert(100));
            Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));
            // call static public method
            Console.WriteLine(UnitConverter.FeetToInches(30));
            Console.WriteLine(UnitConverter.FeetToInches(100));
        }
    }

}
