using GitMine.GitInterface.Interfaces.Types;

namespace GitMine.GitInterface.Interfaces.DefaultImplementation.ILogger
{
    /// <summary>
    /// Class <c>SplitLogger</c> implements <c>ILogger</c> interface, and
    /// provides mechanism of splitting log messages into multiple implementations
    /// of <c>ILogger</c> interface.
    /// </summary>
    public class SplitLogger : Interfaces.ILogger
    {
        private readonly Interfaces.ILogger firstLogger;
        private readonly Interfaces.ILogger secondLogger;
        private readonly Interfaces.ILogger[]? moreLoggers;

        /// <summary>
        /// Initializes class <c>SplitLogger</c> for splitting log messages
        /// into at least two <c>ILogger</c> interface implementations.
        /// </summary>
        /// <param name="firstLogger">Required first <c>ILogger</c> interface implementation.</param>
        /// <param name="secondLogger">Required second <c>ILogger</c> interface implementation.</param>
        /// <param name="moreLoggers"><c>ILogger</c> interface implementations.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SplitLogger(
            Interfaces.ILogger firstLogger,
            Interfaces.ILogger secondLogger,
            params Interfaces.ILogger[] moreLoggers)
        {
            this.firstLogger = firstLogger ?? throw new ArgumentNullException(nameof(firstLogger));
            this.secondLogger = secondLogger ?? throw new ArgumentNullException(nameof(secondLogger));
            this.moreLoggers = moreLoggers;
        }

        public void Info(params string[] messages)
        {
            firstLogger?.Info(messages);
            secondLogger?.Info(messages);

            if (moreLoggers != null && moreLoggers.Length > 0)
            {
                foreach (var logger in moreLoggers)
                {
                    logger?.Info(messages);
                }
            }
        }

        public void Warning(params string[] messages)
        {
            firstLogger?.Warning(messages);
            secondLogger?.Warning(messages);

            if (moreLoggers != null && moreLoggers.Length > 0)
            {
                foreach (var logger in moreLoggers)
                {
                    logger?.Warning(messages);
                }
            }
        }

        public void Error(params string[] messages)
        {
            firstLogger.Error(messages);
            secondLogger.Error(messages);

            if (moreLoggers != null && moreLoggers.Length > 0)
            {
                foreach (var logger in moreLoggers)
                {
                    logger?.Error(messages);
                }
            }
        }

        public void Log(LogLevel logLevel, params string[] messages)
        {
            firstLogger.Log(logLevel, messages);
            secondLogger.Log(logLevel, messages);

            if (moreLoggers != null && moreLoggers.Length > 0)
            {
                foreach (var logger in moreLoggers)
                {
                    logger?.Log(logLevel, messages);
                }
            }
        }

        public void Dispose()
        {
            firstLogger.Dispose();
            secondLogger.Dispose();

            if (moreLoggers != null && moreLoggers.Length > 0)
            {
                foreach (var logger in moreLoggers)
                {
                    if (logger != null)
                    {
                        logger.Dispose();
                    }
                }
            }
        }
    }
}
