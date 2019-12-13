namespace DependencyInjection
{
    class MyApplication : IApplication
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

	internal interface IApplication
	{
		void DoSomeAction();
	}
}
