namespace DependencyInjection
{
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
