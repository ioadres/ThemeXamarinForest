using System;
using Xamarin.Forms;

namespace Theme.Views.Templates.Models
{
    public class CircleViewModel : View
    {
        private readonly BindableProperty BackgroundProperty;

		public string Background
		{
			get
			{
				return (string)GetValue(BackgroundProperty);
			}
			set
			{
				SetValue(BackgroundProperty, value);
			}
		}

        private readonly BindableProperty TextColorProperty;

		public string TextColor
		{
			get
			{
				return (string)GetValue(TextColorProperty);
			}
			set
			{
				SetValue(TextColorProperty, value);
			}
		}

		private readonly BindableProperty TextProperty;

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


		public CircleViewModel(string Id)
        {
           BackgroundProperty = BindableProperty.Create(nameof(Background) + Id, typeof(string), typeof(CircleViewModel));
           TextColorProperty = BindableProperty.Create(nameof(TextColor) + Id, typeof(string), typeof(CircleViewModel));
            TextProperty = BindableProperty.Create(nameof(Text) + Id, typeof(string), typeof(CircleViewModel));
            
        }
    }
}
