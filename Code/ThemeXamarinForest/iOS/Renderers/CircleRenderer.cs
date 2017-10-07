using System;
using System.ComponentModel;
using Theme.iOS.Renderers;
using Theme.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;

[assembly: ExportRenderer(typeof(CircleControl), typeof(CircleRenderer))]
namespace Theme.iOS.Renderers
{
    public class CircleRenderer : ViewRenderer<CircleControl, UIView>
    {
        
        protected override void OnElementChanged(ElementChangedEventArgs<CircleControl> e)
		{
			base.OnElementChanged(e);
			if (Control == null)
			{
				var circleDotView = new UIView();
				SetNativeControl(circleDotView);
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			if (e.PropertyName == CircleControl.ActiveProperty.PropertyName)
			{
				this.SetNeedsDisplay();
			}
		}

		public override void Draw(CGRect rect)
		{
			DrawCircleDot(rect, Element.FillColor.ToUIColor(), Element.StrokeColor.ToUIColor(), Element.Active);
		}

		private void DrawCircleDot(CGRect frame, UIColor colorFill, UIColor colorStroke, bool circleDotActive)
		{

			if (circleDotActive)
			{
				//// circleDotFill Drawing
				var circleDotFillPath = UIBezierPath.FromOval(new CGRect(frame.GetMinX() + 1.0f, frame.GetMinY() + 1.0f, frame.Width - 2.0f, frame.Height - 2.0f));
				colorFill.SetFill();
				circleDotFillPath.Fill();
			}


			//// circleDotStroke Drawing
			var circleDotStrokePath = UIBezierPath.FromOval(new CGRect(frame.GetMinX() + 1.0f, frame.GetMinY() + 1.0f, frame.Width - 2.0f, frame.Height - 2.0f));
			colorStroke.SetStroke();
			circleDotStrokePath.LineWidth = 1.5f;
			circleDotStrokePath.Stroke();
		}
	}
}