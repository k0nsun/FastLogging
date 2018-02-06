using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastLogging
{

    [Serializable]
    public class ExceptionLog : System.Exception
    {
        /// <summary>
        /// Exception avec un message.
        /// </summary>
        /// <param name="message">Message de l'exception.</param>
        public ExceptionLog(string message)
            : this(message, null)
        {
            Log.Error(message);
        }

        /// <summary>
        /// Exception avec un message et une exception interne.
        /// </summary>
        /// <param name="message">Message de l'exception.</param>
        /// <param name="innerException">Exception interne.</param>
        public  ExceptionLog(string message, System.Exception innerException)
            : base(message, innerException)
        {
            Log.Error(message, innerException);
        }
    }
}
