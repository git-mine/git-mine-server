using GitMine.GitInterface.Interfaces.Types;
using GitMine.GitInterface.Internal.Extensions;
using GitMine.GitInterface.Internal.Settings;

namespace GitMine.GitInterface.Interfaces.DefaultImplementation.ILogger
{
    /// <summary>
    /// Class <c>FileLogger</c> implements <c>ILogger</c> interface, and dumps
    /// log messages into specified file.
    /// </summary>
    public class FileLogger : Interfaces.ILogger
    {
        private readonly LogLevel _minLogLevel;
        private readonly bool _enableTimestamp;
        private StreamWriter? _writer;

        /// <summary>
        /// Initializes class <c>FileLogger</c> to dump log messages into specified file.
        /// </summary>
        /// <param name="filename">Log file name.</param>
        /// <param name="minLogLevel">Minimum log level.</param>
        /// <param name="enableTimestamp">Whether timestamp should be printed to log messages or not.</param>
        /// <exception cref="Exception"></exception>
        public FileLogger(
            string filename,
            LogLevel minLogLevel = LogLevel.Information,
            bool enableTimestamp = false)
        {
            try
            {
                filename.CreateFoldersForRelativeFilename();

                _writer = File.AppendText(filename);

                _writer.WriteLine($"  {Constants.ApplicationName} v{Constants.Version}");
                _writer.WriteLine($"  Starting log at {DateTime.Now:yyyy/MMM/dd - hh:mm:ss tt}");

                _writer.Flush();
                _writer.AutoFlush = true;
            }
            catch (Exception ex)
            {
                _writer = null;
                throw new Exception($"Cannot write log to file \"{filename}\" - {ex.Message}");
            }

            _minLogLevel = minLogLevel;
            _enableTimestamp = enableTimestamp;
        }

        private string GetTimeStamp()
        {
            if (_enableTimestamp)
            {
                return $"{DateTime.Now:hh:mm:ss tt}";
            }

            return "";
        }

        public void Info(params string[] messages)
        {
            if (messages.Length > 0 && _writer != null && _minLogLevel == LogLevel.Information)
            {
                lock (this)
                {
                    if (messages.Length == 1)
                    {
                        _writer.WriteLine($"{GetTimeStamp()} - {messages[0]}");
                    }
                    else
                    {
                        _writer.WriteLine($"{GetTimeStamp()} -");

                        foreach (string message in messages)
                        {
                            _writer.WriteLine($"    {message}");
                        }
                    }
                }
            }
        }

        public void Warning(params string[] messages)
        {
            if (messages.Length > 0 && _writer != null && _minLogLevel != LogLevel.Error)
            {
                lock (this)
                {
                    if (messages.Length == 1)
                    {
                        _writer.WriteLine($"{GetTimeStamp()} - Warning: {messages[0]}");
                    }
                    else
                    {
                        _writer.WriteLine($"{GetTimeStamp()} - Warning:");

                        foreach (string message in messages)
                        {
                            _writer.WriteLine($"    {message}");
                        }
                    }
                }
            }
        }

        public void Error(params string[] messages)
        {
            if (messages.Length > 0 && _writer != null)
            {
                lock (this)
                {
                    if (messages.Length == 1)
                    {
                        _writer.WriteLine($"{GetTimeStamp()} - Error: {messages[0]}");
                    }
                    else
                    {
                        _writer.WriteLine($"{GetTimeStamp()} - Error:");

                        foreach (string message in messages)
                        {
                            _writer.WriteLine($"    {message}");
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
            if (_writer != null)
            {
                lock (this)
                {
                    _writer.WriteLine($"  Stopping log at {DateTime.Now:yyyy/MMM/dd - hh:mm:ss tt}");
                    _writer.WriteLine($"------------------------------------------------------------------");
                    _writer.WriteLine($"");

                    _writer.Flush();
                    _writer.Dispose();
                    _writer = null;
                }
            }
        }
    }
}
