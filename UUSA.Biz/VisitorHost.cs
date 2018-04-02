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
        #region Properties

        public string PhoneNumber { get; set; }

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
