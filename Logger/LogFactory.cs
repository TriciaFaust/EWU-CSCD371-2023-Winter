using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Logger
{
    public class LogFactory
    {
        private string ClassName;
        private string OutputPath;
        public BaseLogger CreateLogger(string className)
        {
            ClassName = className;
            if (OutputPath == null)
            {
                return null;
            }

            string outputPath = Path.Combine(OutputPath, ClassName + ".log");
            FileLogger fileLogger = new FileLogger(outputPath);
            fileLogger.Name = ClassName;
            return fileLogger;
        }

        public void ConfigureFileLogger(string pathName) 
        {
            OutputPath = pathName;
            //OutputPath = Path.Combine(pathName, ClassName + ".log");
        }
    }
}
