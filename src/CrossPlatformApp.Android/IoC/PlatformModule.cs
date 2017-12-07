using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Autofac;
using CrossPlatformApp.Models;
using CrossPlatformApp.Droid.Models;

namespace CrossPlatformApp.Droid.IoC
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