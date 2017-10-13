using System;
using Xamarin.Forms;

namespace Theme.Controls
{
	public class CircleControl : BoxView
	{		
		public static readonly BindableProperty ActiveProperty =
			  BindableProperty.Create(nameof(Active), typeof(bool), typeof(CircleControl), false);		
		
		public static readonly BindableProperty CornerRadiusProperty =
			BindableProperty.Create(nameof(CornerRadius), typeof(double), typeof(CircleControl), 0.0);
		
		public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create(nameof(BorderWidth), typeof(float), typeof(CircleControl), Convert.ToSingle(0));

		public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CircleControl), Color.Black);

        public static readonly BindableProperty WithBorderProperty =
            BindableProperty.Create(nameof(WithBorder), typeof(bool), typeof(CircleControl), false);      
        

		public bool Active
		{
			get { return (bool)GetValue(ActiveProperty); }
			set { SetValue(ActiveProperty, value); }
		}

        public bool WithBorder
        {
            get { return (bool)GetValue(WithBorderProperty); }
            set { SetValue(WithBorderProperty, value); }
        }


		public double CornerRadius
		{
			get { return (double)GetValue(CornerRadiusProperty); }
			set
			{
				SetValue(CornerRadiusProperty, value);
			}
		}
		
		public float BorderWidth
		{
			get { return (float)GetValue(BorderWidthProperty); }
			set
			{
				SetValue(BorderWidthProperty, value);
			}
		}

		public Color BorderColor
		{
            get { return (Color)GetValue(BorderColorProperty); }
			set
			{
				SetValue(BorderColorProperty, value);
			}
		}

		
	}
}