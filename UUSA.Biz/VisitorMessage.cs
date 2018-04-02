using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUSA.Biz
{
    public class VisitorMessage
    {
        #region Fields

        private StringBuilder message;

        #endregion

        #region Contructors

        public VisitorMessage()
        {
            message = new StringBuilder("The following ");
        }

        #endregion

    }
}
