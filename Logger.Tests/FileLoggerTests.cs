using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        BaseLogger fileLogger;
        [TestInitialize]
        public void TestInitialize()
        {
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger("C:\\Logs");
            fileLogger = logFactory.CreateLogger(nameof(FileLoggerTests));
        }

        [TestMethod]
        public void FileLoggerTestError() 
        {
            fileLogger.Error("error message");
        }

        [TestMethod]
        public void FileLoggerTestWarning()
        { 
            fileLogger.Warning("warning message");
        }

        [TestMethod]
        public void FileLoggerTestInformation()
        {
            fileLogger.Information("Information message");
        }

        [TestMethod]
        public void FileLoggerTestDebug()
        {
            fileLogger.Debug("Debug message");
        }

    }
}
