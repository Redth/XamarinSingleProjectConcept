using Xamarin.Forms;
using Android.App;

namespace MyApp
{
	[Activity(MainLauncher = true,
		ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity<MyApp>
	{
	}
}