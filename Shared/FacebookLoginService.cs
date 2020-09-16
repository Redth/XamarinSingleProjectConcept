#if ANDROID
using Xamarin.Facebook.Login;
#elif IOS
using Facebook.LoginKit;
#endif

namespace MyApp
{
	public partial class FacebookLoginService
	{
		public Task Login()
		{
#if ANDROID
			var loginManager = DeviceLoginManager.Instance;

			// ...
#elif IOS
			var loginManager = new LoginManager();

			// ...
#endif
		}
	}
}