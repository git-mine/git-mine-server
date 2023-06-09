using GitMine.GitInterface.Interfaces.Types;

namespace GitMine.GitInterface.Interfaces.DefaultImplementation.Logger
{
    /// <summary>
    /// Class <c>BlankLogger</c> implements <c>ILogger</c> interface, though does nothing
    /// with log messages. Use it to discard all the messages.
    /// </summary>
    public class BlankLogger : ILogger
    {
        public void Info(params string[] messages)
        {
        }

        public void Warning(params string[] messages)
        {
        }

        public void Error(params string[] messages)
        {
        }

        public void Log(LogLevel logLevel, params string[] messages)
        {
        }

    }
}
