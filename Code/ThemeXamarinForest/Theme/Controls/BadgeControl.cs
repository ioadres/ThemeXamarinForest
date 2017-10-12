using System;
using Xamarin.Forms;

namespace Theme.Controls
{
    public class CircleControl : Frame
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
		public static readonly BindableProperty RadiusProperty =
			BindableProperty.Create("Radius", typeof(double), typeof(CircleControl), 0.0);

		/// <summary>
		/// Gets or sets the corner radius.
		/// </summary>
		public double Radius
		{
			get { return (double)GetValue(RadiusProperty); }
			set
			{

				SetValue(RadiusProperty, value);
			}
		}

		
	}
}