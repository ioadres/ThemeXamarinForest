using System;
using Theme.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using Android.Widget;
using Android.Graphics;
using Theme.Controls;
using System.ComponentModel;
using Android.Views;

[assembly: ExportRenderer(typeof(AwesomeLabelControl), typeof(AwesomeLabelRenderer))]
namespace Theme.Droid.Renderers
{

	public class AwesomeLabelRenderer : LabelRenderer
	{
        private static Typeface _Typeface;

		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);

			if (e.OldElement == null)
			{
				this.SetTypeface();
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			if (e.PropertyName == "Text")
			{
				this.SetTypeface();
			}
		}		
		

		protected override void OnDisplayHint(int hint)
		{
			base.OnDisplayHint(hint);
			if (hint == (int)Android.Views.SystemUiFlags.Visible)
			{
				this.SetTypeface();
			}
		}

		protected override void OnDraw(Canvas canvas)
		{
			this.SetTypeface();
			base.OnDraw(canvas);
		}
		
		protected override void OnAttachedToWindow()
		{
			this.SetTypeface();
			base.OnAttachedToWindow();
		}

		protected override void OnVisibilityChanged(Android.Views.View changedView, ViewStates visibility)
		{
			this.SetTypeface();
			base.OnVisibilityChanged(changedView, visibility);
		}

		private void SetTypeface()
		{
			if (_Typeface == null)
			{
				//The ttf in /Assets is CaseSensitive, so name it FontAwesome.ttf
				_Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, AwesomeLabelControl.Typeface + ".ttf");
			}

			this.Control.Typeface = _Typeface;
		}
	}
}