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
	public class CircleRenderer : ViewRenderer<CircleControl, Android.Views.View>
	{
		public CircleRenderer()
		{
			this.SetWillNotDraw(false);
		}

		protected override void OnElementChanged(ElementChangedEventArgs<CircleControl> e)
		{
			base.OnElementChanged(e);
			if (Control == null)
			{
				var circleDotView = new Android.Views.View(Forms.Context);
				SetNativeControl(circleDotView);
			}
		}

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			if (e.PropertyName == CircleControl.ActiveProperty.PropertyName)
			{
				Invalidate();
			}
		}

		protected override void OnDraw(Android.Graphics.Canvas canvas)
		{
			var rect = new Rect();
			this.GetDrawingRect(rect);
			Paint paint;

			// circleDotFill
			if (Element.Active)
			{
				RectF circleDotFillRect = new RectF(
					rect.Left + 1f,
					rect.Top + 1f,
					rect.Right - 1f,
					rect.Bottom - 1f);
				Path circleDotFillPath = new Path();
				circleDotFillPath.AddOval(circleDotFillRect, Path.Direction.Cw);

				paint = new Paint(PaintFlags.AntiAlias);
				paint.SetStyle(Paint.Style.Fill);
				paint.Color = Element.FillColor.ToAndroid();
				canvas.DrawPath(circleDotFillPath, paint);
			}

			// circleDotStroke
			RectF circleDotStrokeRect = new RectF(
				rect.Left + 1f,
				rect.Top + 1f,
				rect.Right - 1f,
				rect.Bottom - 1f);
			Path circleDotStrokePath = new Path();
			circleDotStrokePath.AddOval(circleDotStrokeRect, Path.Direction.Cw);

			paint = new Paint(PaintFlags.AntiAlias);
			paint.StrokeWidth = 2.5f;
			paint.StrokeMiter = 10f;
			canvas.Save();
			paint.SetStyle(Paint.Style.Stroke);
			paint.Color = Element.StrokeColor.ToAndroid();
			canvas.DrawPath(circleDotStrokePath, paint);
			canvas.Restore();
		}
	}
}