using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApplication
{
    class IndividualCustomer:Customer
    {
        private int _numberOfPurchases = 0;
        public IndividualCustomer(string name, string address, string region) : base(name, address, region)
        {
        }
        public override void MakePurchase(decimal amount)
        {
            base.MakePurchase(amount);
            _numberOfPurchases += 1;
        }
        public override string Details
        {
            get { return String.Format("[Individual Customer] total spend {0:c2}, number of purchase: {1}", TotalSpend, _numberOfPurchases); }
        }
    }
}
