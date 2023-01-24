using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger
{
    internal class FileLogger : BaseLogger
    {
        public override void Log(LogLevel logLevel, string message)
        {
            //"10/7/2019 12:38:59 AM FileLoggerTests Warning: Test message"
            
            File.AppendAllText(PathName, $"{DateTime.Now} {Name} {logLevel}: {message} {Environment.NewLine}");
        }

        public FileLogger(string pathName) : base() 
        {
            PathName = pathName;       
        }

    }
}
