using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Core
{
    using MvvmCross.Core.ViewModels;
    using MvvmCross.Platform;
    using Services;
    using Services.Impl;

    public class App: MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ICalculationService, CalculationService>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<HomeViewModel>());
        }
    }
}
