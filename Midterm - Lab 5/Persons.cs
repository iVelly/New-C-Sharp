using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lab_5
{
    class Persons
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
        private string feedback;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (ValidOrBuggin.FilledIn(value))
                {
                    firstName = value;
                }
                else
                {
                    feedback += "\nError: Enter Valid Name";
                }
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
                if (ValidOrBuggin.FilledIn(value))
                {
                    lastName = value;
                }
                else
                {
                    feedback += "\nError: Enter Valid Middle Name";
                }
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
                if (ValidOrBuggin.FilledIn(value))
                {
                    street1 = value;
                }
                else
                {
                    feedback += "\nError: Enter Valid Street";
                }
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
                if (ValidOrBuggin.FilledIn(value))
                {
                    city = value;
                }
                else
                {
                    feedback += "\nError: Enter Valid City";
                }
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
                if (ValidOrBuggin.FilledIn(value))
                {
                    state = value;
                }
                else
                {
                    feedback += "\nError: Enter Valid City";
                }
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
                if (ValidOrBuggin.FilledIn(value))
                {
                    zip = value;
                }
                else
                {
                    feedback += "\nError: Enter Valid City";
                }
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
                if (ValidOrBuggin.FilledIn(value))
                {
                    phone = value;
                }
                else
                {
                    feedback += "\nError: Enter Valid City";
                }
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
                if (ValidOrBuggin.ValidEmail(value))
                {
                    email = value;
                }
                else
                {
                    feedback += "\nError: Invalid Email";
                }
            }
        }

        public string Feedback
        {
            get
            {
                return feedback;
            }
            set
            {
                feedback = value;
            }
        }


    }
}
