using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApplication
{
    /// <summary>
    /// Represents a combination of the region and customer number for a customer, 
    /// to enable customers to be sorted on these values.
    /// </summary>
    public class CustomerKey 
    {
        // The region and customer number for a customer.
        private string _region;
        private int _customerNumber;

        /// <summary>
        /// Initializes the CustomerKey object.
        /// </summary>
        /// <param name="region">The region where the customer is located.</param>
        /// <param name="customerNumber">The customer number of the customer.</param>
        public CustomerKey(string region, int customerNumber)
        {
            _region = region;
            _customerNumber = customerNumber;
        }

        // TODO [Ex1]: Implement the CompareTo method.

    
    
    }
}
