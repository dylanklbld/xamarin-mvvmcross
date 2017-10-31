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

namespace HelloWorld.UI.Views
{
    using MvvmCross.Droid.Views;

    [Activity(Label = "MenuView")]
    public class MenuView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.menu_view);
        }
    }
}