using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUSA.Biz
{
    /// <summary>
    /// This class will inherit from the Person class.
    /// </summary>
    public class Visitor : Person
    {
        #region Properties

        public string CompanyName { get; set; }
        

        #endregion
    }
}
