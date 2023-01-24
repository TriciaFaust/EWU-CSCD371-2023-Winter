using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests
    {
        [TestMethod]
        public void LogFactoryTest()
        {
            LogFactory logFactory = new LogFactory();
            logFactory.ConfigureFileLogger("C:\\Logs");
            var fileLogger = logFactory.CreateLogger(nameof(LogFactoryTests));
            Assert.IsNotNull(fileLogger);
            Assert.AreEqual(nameof(LogFactoryTests), fileLogger.Name);
            Assert.AreEqual("C:\\Logs\\LogFactoryTests.log", fileLogger.PathName);
        }

    }
}
