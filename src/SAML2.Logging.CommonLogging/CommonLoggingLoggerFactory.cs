using Common.Logging;

namespace SAML2.Logging.CommonLogging
{
    /// <summary>
    /// SAML2 logger factory based on Common.Logging.
    /// </summary>
    public class CommonLoggingLoggerFactory : ILoggerFactory
    {
        /// <summary>
        /// Gets a logger for the specified name.
        /// </summary>
        /// <param name="keyName">Name of the key.</param>
        /// <returns>An <see cref="IInternalLogger"/> implementation.</returns>
        public IInternalLogger LoggerFor(string keyName)
        {
            return new CommonLoggingInternalLogger(LogManager.GetLogger(keyName));
        }

        /// <summary>
        /// Gets a logger for specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>An <see cref="IInternalLogger"/> implementation.</returns>
        public IInternalLogger LoggerFor(System.Type type)
        {
            return new CommonLoggingInternalLogger(LogManager.GetLogger(type));
        }
    }
}
