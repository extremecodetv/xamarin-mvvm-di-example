using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Autofac;
using CrossPlatformApp.Models;
using CrossPlatformApp.iOS.Models;

namespace CrossPlatformApp.iOS.IoC
{
    class PlatformModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<ClickModel>().As<IClickModel>();
        }
    }
}