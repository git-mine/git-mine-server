namespace GitMine.GitInterface.Interfaces.Types
{
    /// <summary>
    /// Represents the level of any log message.
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Normal or status level information.
        /// </summary>
        Information,

        /// <summary>
        /// Higher priority information.
        /// </summary>
        Warning,

        /// <summary>
        /// Critical information.
        /// </summary>
        Error
    }
}
