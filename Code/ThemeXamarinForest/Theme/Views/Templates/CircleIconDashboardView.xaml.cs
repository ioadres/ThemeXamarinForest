using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Theme.Views.Templates
{
    public partial class CircleIconDashboardView : ContentView
    {
        public static readonly BindableProperty BackgroundProperty = BindableProperty.Create(nameof(Background), typeof(Color), typeof(CircleIconDashboardView), Color.White);

        public Color Background
		{
			get
			{
				return (Color)GetValue(BackgroundProperty);
			}
			set
			{
				SetValue(BackgroundProperty, value);
			}
		}

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(CircleIconDashboardView),Color.Black);

		public Color TextColor
		{
			get
			{
				return (Color)GetValue(TextColorProperty);
			}
			set
			{
				SetValue(TextColorProperty, value);
			}
		}

        private readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(CircleIconDashboardView));

		public string Text
		{
			get
			{
				return (string)GetValue(TextProperty);
			}
			set
			{
				SetValue(TextProperty, value);
			}
		}

		private readonly BindableProperty WithNotificationProperty = BindableProperty.Create(nameof(WithNotification), typeof(bool), typeof(CircleIconDashboardView), false);

        public bool WithNotification
		{
			get
			{
				return (bool)GetValue(WithNotificationProperty);
			}
			set
			{
				SetValue(WithNotificationProperty, value);
			}
		}


		public CircleIconDashboardView()
        {
            InitializeComponent();
            this.Content.BindingContext = this;
        }
    }
}