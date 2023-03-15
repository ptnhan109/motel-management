using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Motel.App
{
    [Activity(Label = "iMoma", Icon = "@mipmap/momalogo", Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}