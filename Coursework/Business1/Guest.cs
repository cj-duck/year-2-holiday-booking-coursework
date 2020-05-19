// Author: Christopher Johnson [40275286]
// Class Purpose: Guest class to store guest information
// Date Last Modified: 03/12/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Guest
    {
        // Declare attributes for the guest class
        private string _guestName;
        private long _passNumber;
        private int _guestAge;

        public string guestName
        {
            get
            {
                return _guestName;
            }
            set
            {
                // Validate
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Guest name cannot be blank!");
                }
                _guestName = value;
            }
        }

        public long passNumber
        {
            get
            {
                return _passNumber;
            }
            set
            {
                // Validate
                if(value.ToString().Length != 10)
                {
                    throw new ArgumentException("Invalid Passport Number!");
                }
                _passNumber = value;
            }
        }

        public int guestAge
        {
            get
            {
                return _guestAge;
            }
            set
            {
                // Validate
                if (value < 0 || value > 110)
                {
                    throw new ArgumentException("Age must be between 0 and 101 years!");
                }
                _guestAge = value;
            }
        }
    }
}
