namespace MyApp
{
	public partial class EntryRenderer {
		public static PropertyMapper<IView> ViewMapper = new PropertyMapper<IView> {
			
			// Add your own method to map to any property         
			[nameof(IView.BackgroundColor)] = MapBackgroundColor

		};
	}
}