using System;
using Xamarin.Forms;

namespace Theme.Controls
{
	public class CircleControl : BoxView
	{
		public static readonly BindableProperty StrokeColorProperty =
			   BindableProperty.Create(nameof(StrokeColor), typeof(Color), typeof(CircleControl), Color.Black);

		public Color StrokeColor
		{
			get { return (Color)GetValue(StrokeColorProperty); }
			set { SetValue(StrokeColorProperty, value); }
		}

		public static readonly BindableProperty ActiveProperty =
			  BindableProperty.Create(nameof(Active), typeof(bool), typeof(CircleControl), false);

		public bool Active
		{
			get { return (bool)GetValue(ActiveProperty); }
			set { SetValue(ActiveProperty, value); }
		}

		/// <summary>
		/// The border width property.
		/// </summary>
		public static readonly BindableProperty BorderWidthProperty =
			BindableProperty.Create("CornerRadius", typeof(double), typeof(CircleControl), 0.0);

		/// <summary>
		/// Gets or sets the border width.
		/// </summary>
		public double BorderWidth
		{
			get { return (double)GetValue(BorderWidthProperty); }
			set
			{

				SetValue(BorderWidthProperty, value);
			}
		}

		/// <summary>
		/// The corner radius property.
		/// </summary>
		public static readonly BindableProperty CornerRadiusProperty =
			BindableProperty.Create("CornerRadius", typeof(double), typeof(CircleControl), 0.0);

		/// <summary>
		/// Gets or sets the corner radius.
		/// </summary>
		public double CornerRadius
		{
			get { return (double)GetValue(CornerRadiusProperty); }
			set
			{

				SetValue(CornerRadiusProperty, value);
			}
		}

		
	}
}