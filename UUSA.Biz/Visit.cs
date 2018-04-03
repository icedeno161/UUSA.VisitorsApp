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
        #region Fields

        private DateTime? arrival;
        private DateTime? departure;

        #endregion

        #region Properties

        public VisitorHost Host { get; set; }
        public List<Visitor> Visitors { get; set; }
        public DateTime Arrival
        {
            get { return arrival ?? DateTime.Now; }
            set { arrival = value; }
        }
        public DateTime Departure
        {
            get { return departure ?? DateTime.Now; }
            set { departure = value; }
        }

        #endregion
    }
}
