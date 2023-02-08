using FinTechDesignExample.Pages;

namespace FinTechDesignExample;

public partial class MainPage : ContentPage
{
	private MainPage_ContentView maincontent;
	private NewContent1 newcontent;

	public MainPage()
	{
		InitializeComponent();
		maincontent = new MainPage_ContentView();
		newcontent = new NewContent1();
	}


	private void home_clicked(object sender, EventArgs e)
	{
		AnimHelper.NavigateButtonClicked(border, .5f, .65f, 10,(ImageButton)sender, 1, 1.20f, 100);
		myContent.Content = maincontent;
	}

	private void info_clicked(object sender, EventArgs e)
	{
		AnimHelper.NavigateButtonClicked(border, .5f, .65f, 10, (ImageButton)sender, 1, 1.20f, 100);
		myContent.Content = newcontent;
	}

	

}

