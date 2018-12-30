using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Demo.Service
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserService>();
        }
    }
}
