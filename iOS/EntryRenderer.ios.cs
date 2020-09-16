using Xamarin.Forms;
using UIKit;

namespace MyApp
{
	// You don’t need to register a new renderer.
	public partial class EntryRenderer
	{
		// You know what method to call because you named it!
		public static void MapBackgroundColor (IViewRenderer renderer, IView view)
		{
			// You don’t need to call any base methods here or worry about order.
	
			// Every renderer is consistent; you know where the native view is.
			var nativeView = (NativeView)renderer.NativeView;
			var color = view.BackgroundColor;

			if (color != null) {

				// Phew! That was easy!
				nativeView.BackgroundColor = UIColor.FromRGB (204, 153, 255);
			}
		}
	}
}