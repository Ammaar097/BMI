using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height;

            //Input
            Console.WriteLine("teaching by Kongruksiam");
            Console.WriteLine("thank for coding by Kongruksiam");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("this version is develop by Ammarr097");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("----------------");
            Console.WriteLine("Please Always Press Enter for go to Next Process or While You Input Data Complete.");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Input Weight (kg): ");
            double.TryParse(Console.ReadLine(), out weight);
            Console.Write("Input Height (cm): ");
            double.TryParse(Console.ReadLine(), out height);
            Console.WriteLine("");

            //Process
            //weight can be 0 because numerator can be 0
            //height can't be 0 because Denominator can't 0 follow by law of divided
            if (weight == 0)
            {
                weight = 0;
            }
            if (height == 0)
            {
                height = double.NaN;
            }
            //bmi = weight/height^2
            height /= 100;
            double bmi = weight / Math.Pow(height, 2);

            //Output
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");
            if (bmi > 0) {
                Console.WriteLine("This is Your BMI = {0:F2}  <---------- THIS IS ANSWER", bmi);
            }
            else if(bmi <= 0)
            {
                Console.WriteLine("This is not possible with a negative BMI or less than standard BMI.");
            }
            else
            {
                Console.WriteLine("This is not possible BMI or you're data incomplete.");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Press Enter to Exit Program.");
            Console.WriteLine("------------------------------");
            Console.ReadLine();
        }
    }
}
