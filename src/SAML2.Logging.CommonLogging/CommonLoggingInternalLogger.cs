using System;
using Common.Logging;

namespace SAML2.Logging.CommonLogging
{
    /// <summary>
    /// SAML2 logger based on Common.Logging.
    /// </summary>
    public class CommonLoggingInternalLogger : IInternalLogger
    {
        /// <summary>
        /// The CommonLogging instance.
        /// </summary>
        private readonly ILog _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonLoggingInternalLogger"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public CommonLoggingInternalLogger(ILog logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets a value indicating whether this instance is error enabled.
        /// </summary>
        public bool IsErrorEnabled
        {
            get { return false; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is fatal enabled.
        /// </summary>
        public bool IsFatalEnabled
        {
            get { return _logger.IsFatalEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is debug enabled.
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return _logger.IsDebugEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is info enabled.
        /// </summary>
        public bool IsInfoEnabled
        {
            get { return _logger.IsInfoEnabled; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is warn enabled.
        /// </summary>
        public bool IsWarnEnabled
        {
            get { return _logger.IsWarnEnabled; }
        }

        /// <summary>
        /// Logs specified error message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Error(object message)
        {
            _logger.Error(message);
        }

        /// <summary>
        /// Logs specified error message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Error(object message, Exception exception)
        {
            _logger.Error(message, exception);
        }

        /// <summary>
        /// Logs specified error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void ErrorFormat(string format, params object[] args)
        {
            _logger.ErrorFormat(format, args);
        }

        /// <summary>
        /// Logs specified fatal error message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Fatal(object message)
        {
            _logger.Fatal(message);
        }

        /// <summary>
        /// Logs specified fatal error message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Fatal(object message, Exception exception)
        {
            _logger.Fatal(message, exception);
        }

        /// <summary>
        /// Logs specified debug message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Debug(object message)
        {
            _logger.Debug(message);
        }

        /// <summary>
        /// Logs specified debug message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Debug(object message, Exception exception)
        {
            _logger.Debug(message, exception);
        }

        /// <summary>
        /// Logs specified debug message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void DebugFormat(string format, params object[] args)
        {
            _logger.DebugFormat(format, args);
        }

        /// <summary>
        /// Logs specified info message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Info(object message)
        {
            _logger.Info(message);
        }

        /// <summary>
        /// Logs specified info message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Info(object message, Exception exception)
        {
            _logger.Info(message, exception);
        }

        /// <summary>
        /// Logs specified info message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void InfoFormat(string format, params object[] args)
        {
            _logger.InfoFormat(format, args);
        }

        /// <summary>
        /// Logs specified warn message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Warn(object message)
        {
            _logger.Warn(message);
        }

        /// <summary>
        /// Logs specified warn message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Warn(object message, Exception exception)
        {
            _logger.Warn(message, exception);
        }

        /// <summary>
        /// Logs specified warn message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void WarnFormat(string format, params object[] args)
        {
            _logger.WarnFormat(format, args);
        }
    }
}
