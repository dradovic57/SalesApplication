using System;
using System.Collections.Generic;
using System.Text;

namespace SalesApplication
{
    /// <summary>
    /// Contains event data for a "customer purchase" event.
    /// This class is already complete.
    /// </summary>
    public class CustomerPurchaseEventArgs : EventArgs
    {
        // Event data.
        private decimal _valueOfPurchase;

        /// <summary>
        /// Initializes the event data.
        /// </summary>
        /// <param name="valueOfPurchase">The value of the purchase that caused the event to be raised.</param>
        public CustomerPurchaseEventArgs(decimal valueOfPurchase)
        {
            _valueOfPurchase = valueOfPurchase;
        }

        /// <summary>
        /// Gets the value of the purchase that causes the event to be raised.
        /// </summary>
        public decimal ValueOfPurchase
        {
            get { return _valueOfPurchase; }
        }
    }
}
