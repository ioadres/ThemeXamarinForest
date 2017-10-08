using System;
using System.Collections.Generic;
using Theme.Views.Templates.Models;
using Xamarin.Forms;

namespace Theme.Views.Templates
{
    public partial class CircleNotificationView : ContentView
    {
		public CircleViewModel Circle
		{
			get;
			set;
		}

		public CircleNotificationView()
		{
			Circle = new CircleViewModel("");
			InitializeComponent();
		}
    }
}
