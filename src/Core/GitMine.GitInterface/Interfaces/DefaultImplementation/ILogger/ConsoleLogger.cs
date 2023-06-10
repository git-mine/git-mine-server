using GitMine.GitInterface.Interfaces.Types;
using GitMine.GitInterface.Internal.Extensions;

namespace GitMine.GitInterface.Interfaces.DefaultImplementation.ILogger
{
    /// <summary>
    /// Class <c>ConsoleLogger</c> implements <c>ILogger</c> interface to write
    /// log messages on standard console.
    /// </summary>
    public class ConsoleLogger : Interfaces.ILogger
    {
        private readonly LogLevel logLevel;

        private readonly ConsoleColor informationTextColor;
        private readonly ConsoleColor informationBackgroundColor;
        private readonly ConsoleColor warningTextColor;
        private readonly ConsoleColor warningBackgroundColor;
        private readonly ConsoleColor errorTextColor;
        private readonly ConsoleColor errorBackgroundColor;

        /// <summary>
        /// Initializes class <c>ConsoleLogger</c> to write log messages on standard console.
        /// </summary>
        /// <param name="logLevel">Minimum log level.</param>
        /// <param name="informationTextColor">Text color for information-level messages.</param>
        /// <param name="informationBackgroundColor">Background color for information-level messages.</param>
        /// <param name="warningTextColor">Text color for warning-level messages.</param>
        /// <param name="warningBackgroundColor">Background color for warning-level messages.</param>
        /// <param name="errorTextColor">Text color for error-level messages.</param>
        /// <param name="errorBackgroundColor">Background color for error-level messages.</param>
        public ConsoleLogger(
            LogLevel logLevel = LogLevel.Information,

            ConsoleColor informationTextColor = ConsoleColor.DarkGray,
            ConsoleColor informationBackgroundColor = ConsoleColor.Black,
            ConsoleColor warningTextColor = ConsoleColor.Yellow,
            ConsoleColor warningBackgroundColor = ConsoleColor.Black,
            ConsoleColor errorTextColor = ConsoleColor.Magenta,
            ConsoleColor errorBackgroundColor = ConsoleColor.Black)
        {
            this.logLevel = logLevel;

            this.informationTextColor = informationTextColor;
            this.informationBackgroundColor = informationBackgroundColor;
            this.warningTextColor = warningTextColor;
            this.warningBackgroundColor = warningBackgroundColor;
            this.errorTextColor = errorTextColor;
            this.errorBackgroundColor = errorBackgroundColor;
        }
        
        public void Info(params string[] messages)
        {
            if (messages.Length > 0 && logLevel == LogLevel.Information)
            {
                lock (this)
                {
                    if (messages.Length == 1)
                    {
                        $"- {messages[0]}".WriteLine(informationTextColor, informationBackgroundColor);
                    }
                    else
                    {
                        $"-".WriteLine(informationTextColor, informationBackgroundColor);

                        foreach (string message in messages)
                        {
                            $"    {message}".WriteLine(informationTextColor, informationBackgroundColor);
                        }
                    }
                }
            }
        }

        public void Warning(params string[] messages)
        {
            if (messages.Length > 0 && logLevel != LogLevel.Error)
            {
                lock (this)
                {
                    if (messages.Length == 1)
                    {
                        $"- Warning: {messages[0]}".WriteLine(warningTextColor, warningBackgroundColor);
                    }
                    else
                    {
                        $"- Warning:".WriteLine(warningTextColor, warningBackgroundColor);

                        foreach (string message in messages)
                        {
                            $"    {message}".WriteLine(warningTextColor, warningBackgroundColor);
                        }
                    }
                }
            }
        }

        public void Error(params string[] messages)
        {
            if (messages.Length > 0)
            {
                lock (this)
                {
                    if (messages.Length == 1)
                    {
                        $"- Error: {messages[0]}".WriteLine(errorTextColor, errorBackgroundColor);
                    }
                    else
                    {
                        $"- Error:".WriteLine(errorTextColor, errorBackgroundColor);

                        foreach (string message in messages)
                        {
                            $"    {message}".WriteLine(errorTextColor, errorBackgroundColor);
                        }
                    }
                }
            }
        }

        public void Log(LogLevel logLevel, params string[] messages)
        {
            switch (logLevel)
            {
                case LogLevel.Information:
                    Info(messages);
                    break;

                case LogLevel.Warning:
                    Warning(messages);
                    break;

                case LogLevel.Error:
                    Error(messages);
                    break;
            }
        }

        public void Dispose()
        {
        }
    }
}
