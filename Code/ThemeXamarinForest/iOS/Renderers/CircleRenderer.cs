using System;
using System.ComponentModel;
using Theme.iOS.Renderers;
using Theme.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;

[assembly: ExportRenderer(typeof(CircleControl), typeof(CircleRenderer))]
namespace Theme.iOS.Renderers
{
    public class CircleRenderer : BoxRenderer
    {
		/// <summary>
		/// Gets the underlying element typed as an <see cref="CircleControl"/>.
		/// </summary>
		private CircleControl CircleControl
		{
			get { return (CircleControl)Element; }
		}

        
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
		{
			base.OnElementChanged(e);
			/* (Control == null)
			{
				var circleView = new BoxView();
				SetNativeControl(circleView);
			}*/
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
            DrawCircle(rect);
		}

        private void DrawCircle(CGRect rect)
		{
            this.Layer.CornerRadius = Convert.ToSingle(CircleControl.CornerRadius);       
            this.Layer.BackgroundColor = Element.BackgroundColor.ToCGColor();
		}
	}
}