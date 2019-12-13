using System;
using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;

namespace DependencyInjection
{
	class Program
    {
        static void Main(string[] args)
        {
			ContainerConfiguration.Config();

			using (var scope = ContainerConfiguration.Container.BeginLifetimeScope())
			{
				var logger = scope.Resolve<ILogger>();

				MyApplication app = new MyApplication(logger);
				app.DoSomeAction();
			}

			using (var scope = ContainerConfiguration.Container.BeginLifetimeScope())
			{
				var logger = scope.Resolve<ILogger>();

				MyApplication app = new MyApplication(logger);
				app.DoSomeAction();
			}
		}
    }
}
