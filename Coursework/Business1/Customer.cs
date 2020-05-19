// Author: Christopher Johnson [40275286]
// Class Purpose: Customer class to store customer information
// Date Last Modified: 10/12/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class Customer
    {
        // Declare the attributes for the customer class
        private string _customerName;
        private string _customerAddress;
        private int _customerRefNumber;

        public string customerName
        {
            get
            {
                return _customerName;
            }
            set
            {
                // Validate
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must not be blank!");
                }
                _customerName = value;
            }
        }

        public string customerAddress
        {
            get
            {
                return _customerAddress;
            }
            set
            {
                // Validate
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Address must not be blank!");
                }
                _customerAddress = value;
            }
        }

        public int customerRefNumber
        {
            get
            {
                return _customerRefNumber;
            }
            set
            {
                // Does not need to be validated because it's auto generated
                _customerRefNumber = value;
            }
        }
    }
}
