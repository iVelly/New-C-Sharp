using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___C__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strFirst, hours, wage, taxes;
            //Int32 intHours = 0, intWage = 0, intGross = 0, intNet = 0;
            float floatTaxes = 0, floatHours = 0, floatWage = 0, floatGross = 0, floatNet = 0;

            Console.WriteLine("Hello There!");
            Console.Write("Please enter the first name: ");
            strFirst = Console.ReadLine();

            Console.WriteLine("Hello " + strFirst + "! Let's calculate your payroll!");

            Console.Write("Please enter the amount of hours worked: ");
            hours = Console.ReadLine();
            floatHours = float.Parse(hours);

            Console.Write("Please enter the wage: ");
            wage = Console.ReadLine();
            floatWage = float.Parse(wage);

            Console.WriteLine("\n\nPress any Key to continue");
            Console.ReadKey();

            floatGross = floatHours * floatWage;

            if(floatGross >= 1000)
            {
                floatTaxes = 50;
            }

            else if (floatGross >= 500)
            {
                floatTaxes = 30;
            }

            else if (floatGross >= 100)
            {
                floatTaxes = 20;
            }
            

            taxes = Console.ReadLine();

            //floatTaxes = float.Parse(taxes);
            
            floatNet = floatGross - (floatTaxes/100) * floatGross;

            Console.WriteLine($"Your amt of taxes is " + floatTaxes + " %");
            Console.WriteLine($"Your Gross Pay is " + floatGross );
            Console.WriteLine($"Your net Pay is " + floatNet);

            Console.WriteLine("\n\nPress any Key to continue");
            Console.ReadKey();

        }   
    }
}
