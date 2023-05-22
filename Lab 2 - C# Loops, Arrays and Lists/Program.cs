using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_2___C__Loops__Arrays_and_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strFirst, hours, wage;
            int intCntr = 0;
            float floatTaxes = 0, floatHours = 0, floatWage = 0, floatGross = 0, floatNet = 0, averageNetpay = 0, averageNetpayResult = 0;

             string again = " ";

            List<string> listNames = new List<string>();
            List<float>  listHours = new List<float>();
            List<float>  listWage = new List<float>();
            List<float>  listTaxes = new List<float>();
            List<float>  listNetPay = new List<float>();
            List<float>  averageIncome = new List<float>();


            //while (again == "Y");
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Hello There!");
                Console.Write("Please enter the first name: ");
                strFirst = Console.ReadLine();
                listNames.Add(strFirst);

                Console.WriteLine("Hello " + strFirst + "! Let's calculate your payroll!");

                Console.Write("Please enter the amount of hours worked: ");
                hours = Console.ReadLine();
                floatHours = float.Parse(hours);
                listHours.Add(floatHours);


                Console.Write("Please enter the wage: ");
                wage = Console.ReadLine();
                floatWage = float.Parse(wage);
                listWage.Add(floatWage);

                floatGross = floatHours * floatWage;

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

                floatNet = floatGross - (floatTaxes / 100) * floatGross;
                listNetPay.Add(floatNet);
                averageNetpay += floatNet;

                Console.WriteLine($"Your amt of taxes is " + floatTaxes + " %");
                Console.WriteLine($"Your Gross Pay is $" + floatGross);
                Console.WriteLine($"Your net Pay is $" + floatNet);

                Console.WriteLine("\n\nPress 'Y' to continue & 'ENTER' to Display Payroll Report");
                again = Console.ReadLine().ToUpper();

                intCntr++;
            } while (again == "Y");


            Console.WriteLine("\n\nPayroll Report");
            Console.WriteLine("===============");


            for (int i = 0; i < listNames.Count; i++)
            {
                Console.WriteLine("Name" +":" + listNames[i]);
                Console.WriteLine("Hours worked: " + listHours[i]);
                Console.WriteLine("Wage: $" + listWage[i]);
                Console.WriteLine("Gross pay: $" + floatGross);
                Console.WriteLine("Taxes: " + floatTaxes +"%");
                Console.WriteLine("Net pay: $" + floatNet);
                Console.WriteLine("===============");
            }

            if (intCntr > 1)

            {
                Console.WriteLine("\nTotal number of employees: " + intCntr);
                averageNetpayResult = (averageNetpay / intCntr);
                Console.WriteLine("Average Net Pay: $" + averageNetpayResult.ToString());
            }

            
            
            //Console.WriteLine(intCntr);

            //Console.WriteLine("\n\nPress 'SPACEBAR' to exit");
            //Console.ReadLine();
        }
    }
}
