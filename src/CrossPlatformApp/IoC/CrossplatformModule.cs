using Autofac;
using CrossPlatformApp.ViewModels;

namespace CrossPlatformApp.IoC
{
    class CrossplatformModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<MainPageViewModel>();
        }
    }
}
