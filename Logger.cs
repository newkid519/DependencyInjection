using System;
using System.IO;

namespace DependencyInjection
{
	interface ILogger
	{
		void WriteLog(string msg);
	}
	
    class Logger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"Simply {msg}");
        }
    }
	
	class AdvancedLogger : ILogger
	{
		public void WriteLog(string msg)
        {
            Console.WriteLine($"{msg} at {DateTime.Now}");
        }
	}
}