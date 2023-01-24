﻿namespace Logger
{
    public abstract class BaseLogger
    {
        public abstract void Log(LogLevel logLevel, string message);

        public string Name { get; set; }
        public string PathName { get; set; }
    }
}
