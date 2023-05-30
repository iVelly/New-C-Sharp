using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lab_5
{
    class Customer : PersonsDos
    {
        private Double totalPurchase;
        private Boolean discountMember;
        private int rewardsEarned;
        private DateTime customerSince;

        public Double TotalPurchase
        {
            get
            {
                return totalPurchase;
            }
            set
            {
                totalPurchase = value;
            }
        }

        public Boolean DiscountMember
        {
            get
            {
                return discountMember;
            }
            set
            {
                discountMember = value;
            }
        }

        public int Rewards
        {
            get
            {
                return rewardsEarned;
            }
            set
            {
                rewardsEarned = value;
            }
        }

        public DateTime CustomerSince
        {
            get
            {
                return customerSince;
            }
            set
            {
                if (!ValidOrBuggin.IsAFutureDate(value) == false)
                {
                    customerSince = value;
                }
                else
                {
                    Feedback += "Error: Invalid date, cannot enter a future date";
                }
            }

        }
    }
    
}
