using System;
using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;

namespace DependencyInjection
{
    class Program
    {
		private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
			var builder = new ContainerBuilder();
			builder.RegisterType<Logger>().As<ILogger>();
			Container = builder.Build();

			using (var scope = Container.BeginLifetimeScope())
			{
				var logger = scope.Resolve<ILogger>();

				MyApplication app = new MyApplication(logger);
				app.DoSomeAction();
			}

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
