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

        #region Methods

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Host: {Host.FullName}");
            stringBuilder.AppendLine($"Arrival: {Arrival.ToString()}");
            stringBuilder.AppendLine($"Departure: {Departure.ToString()}");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("Visitors:\r\n");

            foreach (var v in Visitors)
            {
                stringBuilder.AppendLine($"{v.FullName}");
            }

            return stringBuilder.ToString();
        }

        #endregion
    }
}
