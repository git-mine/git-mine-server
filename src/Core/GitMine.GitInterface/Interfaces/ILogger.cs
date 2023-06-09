using GitMine.GitInterface.Interfaces.Types;

namespace GitMine.GitInterface.Interfaces
{
    /// <summary>
    /// Interface for outputting log messages.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Writes <c cref="LogLevel.Information">Information</c>-level messages to output log.
        /// </summary>
        /// <param name="messages">Log messages.</param>
        void Info(params string[] messages);

        /// <summary>
        /// Writes <c cref="LogLevel.Warning">Warning</c>-level messages to output log.
        /// </summary>
        /// <param name="messages">Log messages.</param>
        void Warning(params string[] messages);

        /// <summary>
        /// Writes <c cref="LogLevel.Error">Error</c>-level messages to output log.
        /// </summary>
        /// <param name="messages">Log messages.</param>
        void Error(params string[] messages);

        /// <summary>
        /// Writes specified <c cref="LogLevel">LogLevel</c> messages to output log.
        /// </summary>
        /// <param name="logLevel">Level of messages.</param>
        /// <param name="messages">Log messages.</param>
        void Log(LogLevel logLevel, params string[] messages);
    }
}
