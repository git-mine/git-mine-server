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
        /// Writes <c cref="LogLevel.Information">Information</c>-level message group to output log.
        /// </summary>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        void Info(string message1, string message2);
        /// <summary>
        /// Writes <c cref="LogLevel.Information">Information</c>-level message group to output log.
        /// </summary>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        /// <param name="message3">Message #3 in the group.</param>
        void Info(string message1, string message2, string message3);
        /// <summary>
        /// Writes <c cref="LogLevel.Information">Information</c>-level message group to output log.
        /// </summary>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        /// <param name="message3">Message #3 in the group.</param>
        /// <param name="message4">Message #4 in the group.</param>
        void Info(string message1, string message2, string message3, string message4);
        /// <summary>
        /// Writes <c cref="LogLevel.Information">Information</c>-level message group to output log.
        /// </summary>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        /// <param name="message3">Message #3 in the group.</param>
        /// <param name="message4">Message #4 in the group.</param>
        /// <param name="message5">Message #5 in the group.</param>
        void Info(string message1, string message2, string message3, string message4, string message5);

        /// <summary>
        /// Writes <c cref="LogLevel.Warning">Warning</c>-level message to output log.
        /// </summary>
        /// <param name="message">The message.</param>
        void Warning(string message);
        /// <summary>
        /// Writes <c cref="LogLevel.Warning">Warning</c>-level message group to output log.
        /// </summary>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        void Warning(string message1, string message2);
        /// <summary>
        /// Writes <c cref="LogLevel.Warning">Warning</c>-level message group to output log.
        /// </summary>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        /// <param name="message3">Message #3 in the group.</param>
        void Warning(string message1, string message2, string message3);
        /// <summary>
        /// Writes <c cref="LogLevel.Warning">Warning</c>-level message group to output log.
        /// </summary>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        /// <param name="message3">Message #3 in the group.</param>
        /// <param name="message4">Message #4 in the group.</param>
        void Warning(string message1, string message2, string message3, string message4);
        /// <summary>
        /// Writes <c cref="LogLevel.Warning">Warning</c>-level message group to output log.
        /// </summary>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        /// <param name="message3">Message #3 in the group.</param>
        /// <param name="message4">Message #4 in the group.</param>
        /// <param name="message5">Message #5 in the group.</param>
        void Warning(string message1, string message2, string message3, string message4, string message5);

        /// <summary>
        /// Writes <c cref="LogLevel.Error">Error</c>-level message to output log.
        /// </summary>
        /// <param name="message">The message.</param>
        void Error(string message);
        /// <summary>
        /// Writes <c cref="LogLevel.Error">Error</c>-level message group to output log.
        /// </summary>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        void Error(string message1, string message2);
        /// <summary>
        /// Writes <c cref="LogLevel.Error">Error</c>-level message group to output log.
        /// </summary>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        /// <param name="message3">Message #3 in the group.</param>
        void Error(string message1, string message2, string message3);
        /// <summary>
        /// Writes <c cref="LogLevel.Error">Error</c>-level message group to output log.
        /// </summary>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        /// <param name="message3">Message #3 in the group.</param>
        /// <param name="message4">Message #4 in the group.</param>
        void Error(string message1, string message2, string message3, string message4);
        /// <summary>
        /// Writes <c cref="LogLevel.Error">Error</c>-level message group to output log.
        /// </summary>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        /// <param name="message3">Message #3 in the group.</param>
        /// <param name="message4">Message #4 in the group.</param>
        /// <param name="message5">Message #5 in the group.</param>
        void Error(string message1, string message2, string message3, string message4, string message5);

        /// <summary>
        /// Writes specified <c cref="LogLevel">LogLevel</c> message to output log.
        /// </summary>
        /// <param name="logLevel">Level of message.</param>
        /// <param name="message">The message.</param>
        void Log(LogLevel logLevel, string message);
        /// <summary>
        /// Writes specified <c cref="LogLevel">LogLevel</c> message group to output log.
        /// </summary>
        /// <param name="logLevel">Level of message group.</param>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        void Log(LogLevel logLevel, string message1, string message2);
        /// <summary>
        /// Writes specified <c cref="LogLevel">LogLevel</c> message group to output log.
        /// </summary>
        /// <param name="logLevel">Level of message group.</param>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        /// <param name="message3">Message #3 in the group.</param>
        void Log(LogLevel logLevel, string message1, string message2, string message3);
        /// <summary>
        /// Writes specified <c cref="LogLevel">LogLevel</c> message group to output log.
        /// </summary>
        /// <param name="logLevel">Level of message group.</param>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        /// <param name="message3">Message #3 in the group.</param>
        /// <param name="message4">Message #4 in the group.</param>
        void Log(LogLevel logLevel, string message1, string message2, string message3, string message4);
        /// <summary>
        /// Writes specified <c cref="LogLevel">LogLevel</c> message group to output log.
        /// </summary>
        /// <param name="logLevel">Level of message group.</param>
        /// <param name="message1">Message #1 in the group.</param>
        /// <param name="message2">Message #2 in the group.</param>
        /// <param name="message3">Message #3 in the group.</param>
        /// <param name="message4">Message #4 in the group.</param>
        /// <param name="message5">Message #5 in the group.</param>
        void Log(LogLevel logLevel, string message1, string message2, string message3, string message4, string message5);
    }
}
