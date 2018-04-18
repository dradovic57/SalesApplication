using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApplication
{
    // TODO [Ex2]: Define a CustomerPurchaseEventHandler delegate type.


    /// <summary>
    /// Base class for all types of customer.
    /// </summary>
    public abstract class Customer
    {
        // Fields for every customer.
        private string _name;
        private string _address;
        private string _region;
        private decimal _totalSpend = 0.0m;
        private int _customerNumber;

        // Class-wide customer count field, enables the Customer class 
        // to assign a different customer number to every new customer.
        private static int _customerCount = 0;

        // TODO [Ex2]: Define a HighPurchase event.


        /// <summary>
        /// Initializes the Customer instance.
        /// </summary>
        /// <param name="name">Customer name.</param>
        /// <param name="address">Customer address.</param>
        /// <param name="region">Customer region.</param>
        public Customer(string name, string address, string region)
        {
            _name = name;
            _address = address;
            _region = region;

            _customerCount++;
            _customerNumber = _customerCount;
        }

        /// <summary>
        /// Gets the name of the customer.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Gets the region of the customer.
        /// </summary>
        public string Region
        {
            get { return _region; }
        }

        /// <summary>
        /// Gets the customer number of the customer.
        /// </summary>
        public int CustomerNumber
        {
            get { return _customerNumber; }
        }

        // TODO [Ex1]: Complete the implementation of the Customer class.

        protected  decimal TotalSpend                                                                       //byDR
        {
            get { return _totalSpend; }
        }
        //public override string ToString()                                                                   //byDR
        //{
        //    return string.Format("ToString overridden byDR: {0}, {1}, {2}", _name, _address, _region);
        //}
        public virtual void MakePurchase(decimal amount)                                                    //byDR
        {
            _totalSpend += amount;
        }
        public abstract string Details                                                                      //byDR
        {
            get;
        }
    }
}