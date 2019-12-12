using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
			MyApplication app = new MyApplication(new Logger());
			app.DoSomeAction();
        }
    }
	
	class MyApplication
	{
		ILogger _logger;
		
		public MyApplication(ILogger logger)
		{
			_logger = logger;
		}
		
		public void DoSomeAction()
		{
			_logger.WriteLog("do some action in MyApplication");
		}
	}
}
