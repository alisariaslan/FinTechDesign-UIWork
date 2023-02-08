using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinTechDesignExample
{
	public class AnimHelper
	{
		public static async void LoadFrame(Frame frame, float defaultOpacity, float targetOpacity, uint duration)
		{
			await frame.FadeTo(defaultOpacity, 0);
			await frame.FadeTo(targetOpacity, duration);
		}

		public static async void LoadFrames(Frame[] frames, float defaultOpacity, float targetOpacity, uint duration)
		{
			foreach (var frame in frames)
			{
				frame.Opacity = 0;
			}
			foreach (var frame in frames)
			{
				await frame.FadeTo(targetOpacity, duration);
			}
		}

		public static async void FrameClicked( Frame frame, float defaultScale, float targetScale, uint duration)
		{
			await frame.ScaleTo(targetScale, duration);
			await frame.ScaleTo(defaultScale, duration);
		}

		public static async void NavigateButtonClicked(Border border, float defaultOpacity, float targetOpacity, uint f_duration,ImageButton imageButton, float defaultScale, float targetScale, uint ib_duration)
		{
			await border.FadeTo(targetOpacity, f_duration);
			await imageButton.ScaleTo(targetScale, ib_duration);
			await imageButton.ScaleTo(defaultScale, ib_duration);
			await border.FadeTo(defaultOpacity, f_duration*100);
		}

	}
}
