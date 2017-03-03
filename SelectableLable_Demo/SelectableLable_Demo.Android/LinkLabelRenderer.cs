using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Text.Method;
using SelectableLable_Demo.Droid;
using SelectableLable_Demo;

[assembly: ExportRenderer(typeof(Label), typeof(LinkLabelRenderer))]
namespace SelectableLable_Demo.Droid
{
    public class LinkLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                if (Control != null)
                {
                    Control.AutoLinkMask = Android.Text.Util.MatchOptions.All;
                    Control.SetTextIsSelectable(true);
                    Control.Focusable = true;
                    Control.FocusableInTouchMode = true;

                    //line below was required to make autodetected links clickable when used inside a ListView. Worked fine outside ListView without this line.
                    Control.MovementMethod = LinkMovementMethod.Instance;

                }
            }
        }

    }
}