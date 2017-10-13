using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using UXDivers.Gorilla;
using Theme.Controls;
using Theme.Droid.Renders;
using Theme.ViewModels;
using Theme.Views;
using Prism;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Theme.Droid.Renderers;

namespace Theme.Droid
{
    [Activity(Label = "Theme.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            //LoadApplication(new App(new AndroidInitializer()));

           LoadApplication(UXDivers.Gorilla.Droid.Player.CreateApplication(this, new Config("Good Gorilla")
				 .RegisterAssembliesFromTypes<Prism.IActiveAware, Prism.PrismApplicationBase<App>, Prism.Unity.PrismApplication>()
						.RegisterAssemblyFromType<CircleControl>()
                        .RegisterAssemblyFromType<BadgeControl>()
						.RegisterAssemblyFromType<CircleRenderer>()
                        .RegisterAssemblyFromType<AwesomeLabelControl>()
                        .RegisterAssemblyFromType<AwesomeLabelRenderer>()
			));
            
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
        }


    }
    public class AndroidInitializer : IPlatformInitializer
    {

        public void RegisterTypes(IUnityContainer container)
        {

        }
    }

}
