// Author: Christopher Johnson [40275286]
// Class Purpose: Booking class to store booking information
// Date Last Modified: 10/12/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Booking
    {
        // Declaring attributes for the booking class
        private int _bookingID;
        private DateTime _arrivalDate;
        private DateTime _departureDate;
        private int _chaletID;
        private bool _eveningMeal;
        private bool _breakfast;
        private int _customerID;
        private List<long> _guests;
        private bool _carHire;
         

        public int bookingID
        {
            get
            {
                return _bookingID;
            }
            set
            {  
                _bookingID = value;
            }
        }

        public DateTime arrivalDate
        {
            get
            {
                return _arrivalDate;
            }
            set
            {
                // Validate
                if (value == null)
                {
                    throw new ArgumentException("Arrival Date cannot be blank");
                }
                _arrivalDate = value;
            }
        }

        public DateTime departureDate
        {
            get
            {
                return _departureDate;
            }
            set
            {
                // Validate
                if (value == null)
                {
                    throw new ArgumentException("Departure Date cannot be blank");
                }
                _departureDate = value;
            }
        }

        public int chaletID
        {
            get
            {
                return _chaletID;
            }
            set
            {
                // Validate
                if(value < 0 || value > 10)
                {
                    throw new ArgumentException("Chalet ID must be between 1 and 10");
                }
                _chaletID = value;
            }
        }

        public bool eveningMeal
        {
            get
            {
                return _eveningMeal;
            }
            set
            {
                // Does not need validating as value comes from checkbox
                _eveningMeal = value;
            }
        }
        
        public bool breakfast
        {
            get
            {
                return _breakfast;
            }
            set
            {
                // Does not need validating as value comes from checkbox
                _breakfast = value;
            }
        }

        public int custID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = value;
            }
        }

        public List<long> guestPassList
        {
            get
            {
                return _guests;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentException("Booking must contain at least 1 guest");
                }
                _guests = value;
            }
        }
 
        public bool carHire
        {
            get
            {
                return _carHire;
            }
            set
            {
                // Does not need validating as value comes from checkbox
                _carHire = value;
            }
        }
    }
}
