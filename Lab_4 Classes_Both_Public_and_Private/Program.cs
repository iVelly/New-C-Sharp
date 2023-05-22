using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_4_Classes_Both_Public_and_Private
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
            Person temp = new Person();
            string poopy = "poopy--";




            Console.Write("What is your first name? ");
            temp.FirstName = Console.ReadLine();
            temp.FirstName = poopy + temp.FirstName;

            Console.Write("Enter your middle name? ");
            temp.MiddleName = Console.ReadLine();

            Console.Write("What is your last name? ");
            temp.LastName = Console.ReadLine();

            Console.Write("Please enter your primary street address: ");
            temp.Street1 = Console.ReadLine();

            Console.Write("Do you have a secondary address? [y/n]: ");
            string expression = Console.ReadLine();

            if (expression == "y")
            {
                Console.Write("Please enter your secondary street address: ");
                temp.Street2 = Console.ReadLine();
            }

            Console.Write("Please enter your state: ");
            temp.State = Console.ReadLine();

            Console.Write("Please enter your city: ");
            temp.City = Console.ReadLine();

            Console.Write("Enter your email: ");
            temp.Email = Console.ReadLine();

            Console.Write("Enter your zip code: ");
            temp.Zip = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            temp.Phone = Console.ReadLine();

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
