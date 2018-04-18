using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApplication
{
    class CorporateCustomer:Customer
    {
        private decimal _projectedSpend;
        public CorporateCustomer(string name, string address, string region, decimal projectedSpend):base(name, address, region)
        {
            _projectedSpend = projectedSpend;
        }
        public override string Details
        {
            get { return string.Format("[Corporate Customer] total spend: {0}, projected spend: {1}", TotalSpend, _projectedSpend); }
        }
    }
}
