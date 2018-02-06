using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastLogging
{
    /// <summary>
    /// Can log informations in base or flat file
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Logger. Need to used with a section log4net in .config
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger("TopContract");

        /// <summary>
        /// Object for thread-safe. 
        /// </summary>
        private static Object sync = new Object();

        /// <summary>
        /// Static constructor for initializing properties
        /// </summary>
        static Log()
        {
            // Initializing log4net based on the .config file.
            log4net.Config.XmlConfigurator.Configure();
        }

        #region - Level Info -

        /// <summary>
        /// Log an information.
        /// </summary>
        /// <param name="message">Message of the information.</param>
        /// <param name="user">User linked to the information.</param>
        public static void Info(string message, string user = null)
        {
            lock (sync)
            {
                Logger.Info(message);
            }
        }

        #endregion

        #region - Level Error -

        /// <summary>
        /// Log an error.
        /// </summary>
        /// <param name="message">Message of the error l'erreur.</param>
        /// <param name="exception">Exception linked to the error.</param>
        /// <param name="user">User linked to the error.</param>
        public static void Error(string message, Exception exception, string user = null)
        {
            lock (sync)
            {
                Logger.Error(message, exception);
            }
        }

        /// <summary>
        /// Log an error.
        /// </summary>
        /// <param name="message">essage of the error l'erreur.</param>
        /// <param name="user">User linked to the error.</param>
        public static void Error(string message, string user = null)
        {
            Error(message, null, user);
        }

        /// <summary>
        /// Log an error.
        /// </summary>
        /// <param name="format">Format string of the error.</param>
        /// <param name="args">Arguments to apply to the format string.</param>
        public static void ErrorFormat(string format, params object[] args)
        {
            lock (sync)
            {
                Logger.ErrorFormat(format, args);
            }
        }

        #endregion

        #region - Level Debug -

        /// <summary>
        /// Log an information for debug.
        /// </summary>
        /// <param name="format">Format string of the error.</param>
        /// <param name="args">Arguments to apply to the format string.</param>
        public static void DebugFormat(string format, params object[] args)
        {
            lock (sync)
            {
                Logger.DebugFormat(format, args);
            }
        }

        #endregion
    }
}
