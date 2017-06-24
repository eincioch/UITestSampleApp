﻿using System;

using Xamarin.Forms;

namespace UITestSampleApp
{
	public enum Borders
	{
		None,
		Thin
	}

	public class StyledButton : Button
	{
		public StyledButton(Borders border, double opacity = 0)
		{
			BackgroundColor = Color.Transparent;
			TextColor = Color.White;
			FontSize = 18;
			Opacity = opacity;
			FontFamily = StyleHelpers.GetFontFamily();

			switch (border)
			{
				case Borders.None:
					break;
				case Borders.Thin:
					BorderRadius = 3;
					BorderColor = Color.White;
					BorderWidth = 1;
					break;
			}
		}
	}
}