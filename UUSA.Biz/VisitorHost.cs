using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUSA.Biz
{
    /// <summary>
    /// This Visitor Host will inherit from Person.
    /// </summary>
    public class VisitorHost : Person
    {
        #region Fields

        private string phoneNumber;

        #endregion

        #region Properties
        public string PhoneNumber
        {
            get { return phoneNumber; }

            // Check to see if value is of length 10 characters and that those
            // characters are numeric.
            set
            {
                var val = value.Trim();

                if (val.Length != 10)
                {
                    throw new ArgumentException(message: "Phone number is not a valid length",
                        paramName: nameof(phoneNumber));
                }
                else if (!int.TryParse(val, out int number))
                {
                    throw new ArgumentException(message: "Phone number is not of numeric lemgth",
                        paramName: nameof(phoneNumber));
                }

                phoneNumber = val;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Will return the phone number in (xxx) xxx-xxxx format
        /// </summary>
        /// <returns></returns>
        public string DisplayPhoneNumber() =>
            $"({PhoneNumber.Substring(0, 3)}) {PhoneNumber.Substring(3, 3)}-{PhoneNumber.Substring(6, 4)}";

        #endregion
    }
}
