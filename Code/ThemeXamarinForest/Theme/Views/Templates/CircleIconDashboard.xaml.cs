using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Theme.Views.Templates
{
    public partial class CircleIconDashboardView : ContentView
    {
        public static readonly BindableProperty BackgroundProperty = BindableProperty.Create(nameof(Background), typeof(Color), typeof(CircleIconDashboardView), Color.White);
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(CircleIconDashboardView), string.Empty);
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(CircleIconDashboardView),Color.Black);
        public static readonly BindableProperty WithNotificationProperty = BindableProperty.Create(nameof(WithNotification), typeof(bool), typeof(CircleIconDashboardView), false);
        public static readonly BindableProperty WithNotificationValueProperty = BindableProperty.Create(nameof(WithNotificationValue), typeof(int), typeof(CircleIconDashboardView), 0);

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
		
        public Boolean WithNotification
		{
			get
			{
				return (Boolean)GetValue(WithNotificationProperty);
			}
			set
			{
				SetValue(WithNotificationProperty, value);
			}
		}

        public int WithNotificationValue
		{
			get
			{
				return (int)GetValue(WithNotificationValueProperty);
			}
			set
			{
				SetValue(WithNotificationValueProperty, value);
			}
		}

		public CircleIconDashboardView()
        {
            InitializeComponent();
            this.Content.BindingContext = this;
        }
    }
}