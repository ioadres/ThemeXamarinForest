using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Theme.Views.Templates.Models;

namespace Theme.Views.Templates
{
    public partial class CircleIconDashboardView : ContentView
    {     
        public CircleViewModel Circle
        {
            get;
            set;
        }       

        public CircleIconDashboardView()
        {
            Circle = new CircleViewModel("");           
            InitializeComponent();
        }
    }
}
