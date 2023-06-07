using GitMine.GitInterface.Interfaces.Types;

namespace GitMine.GitInterface.Interfaces
{
    /// <summary>
    /// Interface for outputting log messages.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Writes <c cref="LogLevel.Information">Information</c>-level message to output log.
        /// </summary>
        /// <param name="message">The message.</param>
        void Info(string message);

        /// <summary>
        /// Writes <c cref="LogLevel.Warning">Warning</c>-level message to output log.
        /// </summary>
        /// <param name="message">The message.</param>
        void Warning(string message);

        /// <summary>
        /// Writes <c cref="LogLevel.Error">Error</c>-level message to output log.
        /// </summary>
        /// <param name="message">The message.</param>
        void Error(string message);

        /// <summary>
        /// Writes specified <c cref="LogLevel">LogLevel</c> message to output log.
        /// </summary>
        /// <param name="logLevel">Level of message</param>
        /// <param name="message">The message</param>
        void Log(LogLevel logLevel, string message);
    }
}
