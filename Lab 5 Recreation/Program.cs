using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using EmptySpaceTool;

namespace Lab_5_Recreation
{

    class People
    {

        struct Person
        {
            

            private string firstName;
            private string middleName;
            private string lastName;
            private string street1;
            private string expression;
            private string street2;
            private string city;
            private string state;
            private string zip;
            private string phone;
            private string email;

            public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                }
            }

            public string MiddleName
            {
                get
                {
                    return middleName;
                }
                set
                {
                    middleName = value;
                }
            }

            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }

            public string Street1
            {
                get
                {
                    return street1;
                }
                set
                {
                    street1 = value;
                }
            }

            public string Street2
            {
                get
                {
                    return street2;
                }
                set
                {
                    street2 = value;
                }
            }

            public string Expression
            {
                get
                {
                    return expression;
                }
                set
                {
                    expression = value;
                }
            }

            public string City
            {
                get
                {
                    return city;
                }
                set
                {
                    city = value;
                }
            }

            public string State
            {
                get
                {
                    return state;
                }
                set
                {
                    state = value;
                }
            }

            public string Zip
            {
                get
                {
                    return zip;
                }
                set
                {
                    zip = value;
                }
            }

            public string Phone
            {
                get
                {
                    return phone;
                }
                set
                {
                    phone = value;
                }
            }

            
            public string Email
            {
                get
                {
                    return email;
                }
                set
                {
                    email = value;
                }
            }

        }

        static Person GetPersonInformation()
        {
            Prompter prompter = new Prompter();

            Person temp = new Person();
            PeopleV2 temp = new PeopleV2();





            temp.FirstName = prompter.PromptForNonEmptyValue("Enter your First name: ");

            Console.Write("Please enter your middle name: ");
            temp.MiddleName = Console.ReadLine();

            temp.LastName = prompter.PromptForNonEmptyValue("Enter your Last name: ");

            temp.Street1 = prompter.PromptForNonEmptyValue("Enter Primary Address: ");

            Console.Write("Do you have a secondary address? [y/n]: ");
            string expression = Console.ReadLine();

            if (expression == "y")
            {
                temp.Street2 = prompter.PromptForNonEmptyValue("Enter Secondary Address: ");
            }

            temp.State = prompter.PromptForNonEmptyValue("Enter State: ");

            temp.City = prompter.PromptForNonEmptyValue("Enter City: ");


            temp.Email = prompter.PromptForNonEmptyValue("Enter Email: ");

            temp.Zip = prompter.PromptForNonEmptyValue("Enter Zip: ");

            temp.Phone = prompter.PromptForNonEmptyValue("Enter Primary Address: ");

            temp.instagramURL = prompter.PromptForNonEmptyValue("Enter Primary Address: ");

            return temp;
        }

        static void PrintPersonInformation(Person temp)
        {
            Console.Write("User Information");
            Console.Write($"\nName: {temp.FirstName}");
            Console.Write($"\nMiddle Name: {temp.MiddleName}");
            Console.Write($"\nLast Name: {temp.LastName}");
            Console.Write($"\nStreet1: {temp.Street1}");
            Console.Write($"\nStreet2: {temp.Street2}");
            Console.Write($"\nState: {temp.State}");
            Console.Write($"\nCity: {temp.City}");
            Console.Write($"\nEmail: {temp.Email}");
            Console.Write($"\nZip Code: {temp.Zip}");
            Console.Write($"\nPhone Number: {temp.Phone}");


            Console.Write("");
            Console.ReadLine();

        }



        static void Main(string[] args)
        {
            Person temp = GetPersonInformation();
            PrintPersonInformation(temp);

            Console.ReadLine();

        }

    }
}

