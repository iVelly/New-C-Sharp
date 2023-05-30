using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lab_5
{
    class PersonsDos : Persons
    {
        private string cellphone;
        private string instagramUrl;

        public string CellPhone
        {
            get
            {
                return cellphone;
            }
            set
            {
                cellphone = value;
            }
        }

        public string InstagramUrl
        {
            get
            {
                return instagramUrl;
            }
            set
            {
                instagramUrl = value;
            }
        }
    }
}
