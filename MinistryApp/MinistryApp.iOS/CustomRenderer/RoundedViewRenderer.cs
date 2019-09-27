using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms.Platform.iOS;
using MinistryApp.CustomControl;
using MinistryApp.iOS.CustomRenderer;
using UIKit;
using Xamarin.Forms;
using CoreGraphics;

[assembly: ExportRenderer(typeof(RoundedView), typeof(RoundedViewRenderers))]
namespace MinistryApp.iOS.CustomRenderer
{
    public class RoundedViewRenderers : ViewRenderer<RoundedView, UIView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<RoundedView> e)
        {
            base.OnElementChanged(e);

            if (Element is RoundedView roundedView)
            {
                NativeView.Layer.CornerRadius = roundedView.BorderRadius;
                NativeView.Layer.BorderWidth = roundedView.BorderThickness;
                NativeView.Layer.BorderColor = roundedView.BorderColor.ToCGColor();
                NativeView.Layer.BackgroundColor = roundedView.BackgroundColor.ToCGColor();

                //shadow
                NativeView.Layer.MasksToBounds = false;
                NativeView.Layer.ShadowOffset = new CGSize(-2, 2);
                NativeView.Layer.ShadowRadius = 5;
                NativeView.Layer.ShadowOpacity = 0.4f;
            }
        }
    }
}