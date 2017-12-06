using log4net;
using Sitecore.Diagnostics;
using System;

namespace LogPublishInfo.Extensions
{
    public static class Logger
    {
        private static readonly ILog LogMessage = Sitecore.Diagnostics.LoggerFactory.GetLogger("PublishInfoLogger");

        public static void Debug(string message)
        {
            Assert.ArgumentNotNull(message, "message");

            LogMessage.Debug(message);
        }

        public static void Debug(string message, Exception exception)
        {
            Assert.ArgumentNotNull(message, "message");
            Assert.ArgumentNotNull(exception, "exception");

            LogMessage.Debug(message, exception);
        }

        public static void Info(string message)
        {
            Assert.ArgumentNotNull(message, "message");

            LogMessage.Info(message);
        }

        public static void Info(string message, Exception exception)
        {
            Assert.ArgumentNotNull(message, "message");
            Assert.ArgumentNotNull(exception, "exception");

            LogMessage.Info(message, exception);
        }

        public static void Warn(string message)
        {
            Assert.ArgumentNotNull(message, "message");

            LogMessage.Warn(message);
        }

        public static void Warn(string message, Exception exception)
        {
            Assert.ArgumentNotNull(message, "message");
            Assert.ArgumentNotNull(exception, "exception");

            LogMessage.Warn(message, exception);
        }

        public static void Error(string message)
        {
            Assert.ArgumentNotNull(message, "message");

            LogMessage.Error(message);
        }

        public static void Error(string message, Exception exception)
        {
            Assert.ArgumentNotNull(message, "message");
            Assert.ArgumentNotNull(exception, "exception");

            LogMessage.Error(message, exception);
        }

        public static void Fatal(string message)
        {
            Assert.ArgumentNotNull(message, "message");

            LogMessage.Fatal(message);
        }

        public static void Fatal(string message, Exception exception)
        {
            Assert.ArgumentNotNull(message, "message");
            Assert.ArgumentNotNull(exception, "exception");

            LogMessage.Fatal(message, exception);
        }
    }
}