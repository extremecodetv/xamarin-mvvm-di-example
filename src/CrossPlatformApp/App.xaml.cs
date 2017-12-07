using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using CrossPlatformApp.IoC;
using CrossPlatformApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CrossPlatformApp
{
	public partial class App : Application
	{
		public App (Module platformModule)
		{
            InitializeDependencies(platformModule);
            InitializeComponent();

			MainPage = new MainPage();
		}

        protected void InitializeDependencies(Module platformModule)
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new CrossplatformModule());
            builder.RegisterModule(platformModule);

            var locator = new AutofacServiceLocator(builder.Build());
            ServiceLocator.SetLocatorProvider(() => locator);
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
