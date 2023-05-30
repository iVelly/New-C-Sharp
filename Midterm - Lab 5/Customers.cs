using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lab_5
{
    class Customer : PersonsDos
    {
        private Double totalPurch;
        private Boolean discMem;
        private int rewards;
        private DateTime customersince;

        public Double TotalPurch
        {
            get
            {
                return totalPurch;
            }
            set
            {
                totalPurch = value;
            }
        }

        public Boolean DiscMem
        {
            get
            {
                return discMem;
            }
            set
            {
                discMem = value;
            }
        }

        public int Rewards
        {
            get
            {
                return rewards;
            }
            set
            {
                rewards = value;
            }
        }

        public DateTime CustomerSince
        {
            get
            {
                return customersince;
            }
            set
            {
                if (!ValidOrBuggin.IsAFutureDate(value) == false)
                {
                    customersince = value;
                }
                else
                {
                    Feedback += "Error: Invalid date, cannot enter a future date";
                }
            }

        }
    }
    
}
