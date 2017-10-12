
using System;
using Xamarin.Forms;

namespace Theme.Controls
{
    public class BadgeControl : AbsoluteLayout
	{
		/// <summary>
		/// The text property.
		/// </summary>
		public static readonly BindableProperty TextProperty =
			BindableProperty.Create("Text", typeof(String), typeof(BadgeControl), "");
    
		
        /// <summary>
		/// The box color property.
		/// </summary>
		public static readonly BindableProperty BoxColorProperty =
			BindableProperty.Create("BoxColor", typeof(Color), typeof(BadgeControl), Color.Default);

		/// <summary>
		/// The text.
		/// </summary>
		public string Text
		{
			get { return (string)GetValue(TextProperty); }
			set { SetValue(TextProperty, value); }
		}	


		/// <summary>
		/// Gets or sets the color of the box.
		/// </summary>
		public Color BoxColor
		{
			get { return (Color)GetValue(BoxColorProperty); }
			set { SetValue(BoxColorProperty, value); }
		}

				

		/// <summary>
		/// The box.
		/// </summary>
		protected CircleControl Box;

		/// <summary>
		/// The label.
		/// </summary>
		protected AwesomeLabelControl LabelAwesomeLabelControl;

		public BadgeControl(double size, double fontSize)
		{
            HeightRequest = size;
            WidthRequest = HeightRequest;
			// Box
			Box = new CircleControl
			{
                CornerRadius = HeightRequest / 2,
                BackgroundColor = BoxColor,


			};
            Box.SetBinding(BackgroundColorProperty, new Binding("BoxColor", source: this));

			Children.Add(Box,new Rectangle(0, 0, 1.0, 1.0), AbsoluteLayoutFlags.All);


            LabelAwesomeLabelControl = new AwesomeLabelControl
			{
				TextColor = Color.White,
				FontSize = fontSize,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
			};
			LabelAwesomeLabelControl.SetBinding(AwesomeLabelControl.TextProperty, new Binding("Text",
				BindingMode.OneWay, source: this));
            

			Children.Add(LabelAwesomeLabelControl, new Rectangle(0, 0, 1.0, 1.0), AbsoluteLayoutFlags.All);

		}

		
	}
}