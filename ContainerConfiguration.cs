using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    class ContainerConfiguration
    {
        public static IContainer Container { get; set; }

        public static void Config()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<TextLogger>().As<ILogger>();
            builder.RegisterType<MyApplication>().As<IApplication>();
            Container = builder.Build();
        }
    }
}
