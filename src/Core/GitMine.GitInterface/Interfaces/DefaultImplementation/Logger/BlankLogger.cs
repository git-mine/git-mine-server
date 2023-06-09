using GitMine.GitInterface.Interfaces.Types;

namespace GitMine.GitInterface.Interfaces.DefaultImplementation.Logger
{
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
