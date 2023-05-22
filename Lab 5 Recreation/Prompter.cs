using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptySpaceTool
{
    public class Prompter
    {
        public string PromptForNonEmptyValue(string prompt)
        {
            string value = string.Empty;

            do
            {
                Console.WriteLine(prompt);
                value = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("You must enter a value. Please try again.");
                }
            } while (string.IsNullOrWhiteSpace(value));

            return value;
        }
    }
}
