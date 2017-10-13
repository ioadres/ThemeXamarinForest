using System;
using Android.Graphics;
using Android.Util;
using Theme.Droid.Renders;
using Xamarin.Forms;
using Theme.Controls;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;


[assembly: ExportRenderer(typeof(CircleControl), typeof(CircleRenderer))]
namespace Theme.Droid.Renders
{
	public class CircleRenderer : BoxRenderer
	{
		public CircleRenderer()
		{
			this.SetWillNotDraw(false);
		}

		protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
		{
			base.OnElementChanged(e);

			SetWillNotDraw(false);

			Invalidate();
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == CircleControl.CornerRadiusProperty.PropertyName)
			{
				Invalidate();
			}
		}

		public override void Draw(Canvas canvas)
		{
			var box = Element as CircleControl;
			var rect = new Rect();	

			var paintFill = new Paint()
			{
				Color = box.BackgroundColor.ToAndroid(),
				AntiAlias = true,
			};

			GetDrawingRect(rect);
			var radius = (float)(rect.Width() / box.Width * box.CornerRadius);
			canvas.DrawRoundRect(new RectF(rect), radius, radius, paintFill);

            if(box.WithBorder) {
                // Draw outline
                var paintOutline = new Paint()
                {
                    Color = box.BorderColor.ToAndroid(),
                    AntiAlias = true,
                    StrokeWidth = box.BorderWidth
                };
                paintOutline.SetStyle(Paint.Style.Stroke);
                canvas.DrawRoundRect(new RectF(rect), radius, radius, paintOutline);
            }
		}
	}
}