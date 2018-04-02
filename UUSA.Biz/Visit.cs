using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUSA.Biz
{
    /// <summary>
    /// This class will define a visit.
    /// </summary>
    public class Visit
    {
        #region Properties

        public VisitorHost Host { get; set; }
        public List<Visitor> Visitors { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }

        #endregion
    }
}
