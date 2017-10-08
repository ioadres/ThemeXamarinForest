using System;
using Xamarin.Forms;

namespace Theme.Controls
{
	public class CircleControl : BoxView
	{		
		public static readonly BindableProperty ActiveProperty =
			  BindableProperty.Create(nameof(Active), typeof(bool), typeof(CircleControl), false);

		public bool Active
		{
			get { return (bool)GetValue(ActiveProperty); }
			set { SetValue(ActiveProperty, value); }
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