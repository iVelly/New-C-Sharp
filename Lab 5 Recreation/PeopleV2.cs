using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Recreation
{
    class PeopleV2 : People
    {
        public string CellPhone ;
        public string InstagramURL;

        public string Cellphone
        {
            get
            {
                return CellPhone;
            }
            set
            {
                CellPhone = value;
            }
        }

        public string instagramURL
        {
            get
            {
                return InstagramURL;
            }
            set
            {
                InstagramURL = value;
            }
        }
    }
}
