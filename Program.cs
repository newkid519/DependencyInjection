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

			for (int i = 0; i < 3; i++)
			{
				using (var scope = ContainerConfiguration.Container.BeginLifetimeScope())
				{
					var app = scope.Resolve<IApplication>();
					app.DoSomeAction();
				}
			}
		}
    }
}
