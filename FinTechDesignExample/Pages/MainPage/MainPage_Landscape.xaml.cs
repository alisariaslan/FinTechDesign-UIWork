using FinTechDesignExample.Pages.MainPage;
using Microsoft.Maui.Controls;

namespace FinTechDesignExample;

public partial class MainPage_Landscape : ContentView
{
	public MainPage_Landscape()
	{
		InitializeComponent();
	}

	private void frame_Loaded(object sender, EventArgs e)
	{
		AnimHelper.LoadFrames(new Frame[] { frame1, frame2, frame3, frame4 }, 0, 1, 250);
	}

	private void frame2_Clicked(object sender, EventArgs e)
	{
		AnimHelper.FrameClicked(frame2, 1, (1.05f), 100);
	}
	private void frame3_Clicked(object sender, EventArgs e)
	{
		AnimHelper.FrameClicked(frame3, 1, (1.05f), 100);
	}
	private void fourframe1_Clicked(object sender, EventArgs e)
	{
		AnimHelper.FrameClicked(fourframe1, 1, (1.05f), 100);
	}

	private void fourframe2_Clicked(object sender, EventArgs e)
	{
		AnimHelper.FrameClicked(fourframe2, 1, (1.05f), 100);
	}

	private void fourframe3_Clicked(object sender, EventArgs e)
	{
		AnimHelper.FrameClicked(fourframe3, 1, (1.05f), 100);
	}

	private void fourframe4_Clicked(object sender, EventArgs e)
	{
		AnimHelper.FrameClicked(fourframe4, 1, (1.05f), 100);
	}
}