
using Android.App;
using Android.Content.PM;
using Android.OS;
using Xfx;

namespace MeuPredio.Droid
{
    [Activity(
        Label = "MeuPredio", 
        Icon = "@mipmap/icon", 
        Theme = "@style/MainTheme", 
        ScreenOrientation = ScreenOrientation.Portrait)] // Sem rotação de tela
        //ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            XfxControls.Init();

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
    }
}