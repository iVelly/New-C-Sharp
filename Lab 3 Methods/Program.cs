using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Methods
{
    internal class Program
    {
        // Declare variables as class-level variables
        static List<string> listNames = new List<string>();
        static List<float> listHours = new List<float>();
        static List<float> listWage = new List<float>();
        static List<float> listNetPay = new List<float>();
        static float averageNetpay = 0;

        static void InfoGrab()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Hello There!");
            Console.Write("Please enter the first name: ");
            string strFirst = Console.ReadLine();
            listNames.Add(strFirst);

            Console.WriteLine("Hello " + strFirst + "! Let's calculate your payroll!");

            Console.Write("Please enter the amount of hours worked: ");
            string hours = Console.ReadLine();
            float floatHours = float.Parse(hours);
            listHours.Add(floatHours);

            Console.Write("Please enter the wage: ");
            string wage = Console.ReadLine();
            float floatWage = float.Parse(wage);
            listWage.Add(floatWage);
        }

        static void Main(string[] args)
        {
            string again = "Y";
            int intCntr = 0;
            float floatTaxes = 0;

            do
            {
                InfoGrab();

                float floatGross = listHours[intCntr] * listWage[intCntr];
               

                if (floatGross >= 1000)
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

                float floatNet = floatGross - (floatTaxes / 100) * floatGross;
                listNetPay.Add(floatNet);
                averageNetpay += floatNet;

                Console.WriteLine($"Your amount of taxes is " + floatTaxes + " %");
                Console.WriteLine($"Your Gross Pay is $" + floatGross);
                Console.WriteLine($"Your Net Pay is $" + floatNet);

                Console.WriteLine("\n\nPress 'Y' to continue & 'ENTER' to Display Payroll Report");
                again = Console.ReadLine().ToUpper();

                intCntr++;
            } while (again == "Y");

            Console.WriteLine("\n\nPayroll Report");
            Console.WriteLine("===============");

            for (int i = 0; i < listNames.Count; i++)
            {
                Console.WriteLine("Name: " + listNames[i]);
                Console.WriteLine("Hours worked: " + listHours[i]);
                Console.WriteLine("Wage: $" + listWage[i]);
                Console.WriteLine("Gross pay: $" + (listHours[i] * listWage[i]));
                Console.WriteLine("Taxes: " + ("-" + "$"+ (listHours[i] * listWage[i]) * floatTaxes / 100) );
                Console.WriteLine("Net pay: $" + listNetPay[i]);
                Console.WriteLine("===============");
            }

            if (intCntr > 0)
            {
                Console.WriteLine("\nTotal number of employees: " + intCntr);
                float averageNetpayResult = averageNetpay / intCntr;
                Console.WriteLine("Average Net Pay: $" + averageNetpayResult.ToString());
            }
        }
    }
}