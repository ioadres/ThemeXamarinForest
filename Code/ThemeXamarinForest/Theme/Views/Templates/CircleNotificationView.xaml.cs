using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Theme.Views.Templates
{
    public partial class CircleNotificationView : ContentView
    {
		public static readonly BindableProperty BgColorProperty = BindableProperty.Create(nameof(BgColor), typeof(string), typeof(CircleNotificationView));

		public string BgColor
        {
            get
            {
                return (string)GetValue(BgColorProperty);
            }
            set
            {
                SetValue(BgColorProperty, value);
            }
        }

        public CircleNotificationView()
        {
            InitializeComponent();
        }
    }
}
