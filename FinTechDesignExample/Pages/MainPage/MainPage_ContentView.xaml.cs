namespace FinTechDesignExample;

public partial class MainPage_ContentView : ContentView
{
	public ContentView portraitContentView;
	public ContentView landscapeContentView;

	public MainPage_ContentView()
	{
		portraitContentView = new MainPage_Portrait();
		landscapeContentView = new MainPage_Landscape();

		DeviceDisplay.Current.MainDisplayInfoChanged += Current_MainDisplayInfoChanged;
		this.Content = DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Portrait ? portraitContentView : landscapeContentView;
	}
	private void Current_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
	{
		if (e.DisplayInfo.Orientation == DisplayOrientation.Landscape)
		{
			this.Content = landscapeContentView;
		}
		else if (e.DisplayInfo.Orientation == DisplayOrientation.Portrait)
		{
			this.Content = portraitContentView;
		}
		else
		{
			this.Content = portraitContentView;
		}
	}
}