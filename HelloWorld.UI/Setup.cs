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

namespace HelloWorld.UI
{
    using HelloWord.Core;
    using HelloWord.Core.Services.DataScanning;
    using HelloWord.Core.Services.Output;
    using MvvmCross.Core.ViewModels;
    using MvvmCross.Droid.Platform;
    using MvvmCross.Platform;
    using Service;

    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext)
        : base(applicationContext)
        {
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
            Mvx.RegisterType<IDataScanner, SimpleDataScannerService>();
            Mvx.RegisterType<IDataPresenter, SimpleDataPresenterService>();
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}