using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms
{
	public class ShadowView : BindableObject
	{
		public static readonly BindableProperty RadiusProperty = BindableProperty.Create(
		nameof(Radius), typeof(double), typeof(ShadowView), 9.0d);

		public double Radius
		{
			get => (double)GetValue(RadiusProperty);
			set => SetValue(RadiusProperty, value);
		}

		public static readonly BindableProperty ColorProperty = BindableProperty.Create(
			nameof(Color), typeof(Color), typeof(ShadowView), Color.Black);

		public Color Color
		{
			get => (Color)GetValue(ColorProperty);
			set => SetValue(ColorProperty, value);
		}

		public static readonly BindableProperty OffsetProperty = BindableProperty.Create(
			nameof(Offset), typeof(Point), typeof(ShadowView), new Point(1, 1));

		public Point Offset
		{
			get => (Point)GetValue(OffsetProperty);
			set => SetValue(OffsetProperty, value);
		}

		public static readonly BindableProperty OpacityProperty = BindableProperty.Create(
		nameof(Opacity), typeof(double), typeof(ShadowView), 9.0d);

		public double Opacity
		{
			get => (double)GetValue(OpacityProperty);
			set => SetValue(OpacityProperty, value);
		}
	}
}
