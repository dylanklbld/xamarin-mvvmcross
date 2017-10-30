namespace HelloWord.Core
{
    using MvvmCross.Core.Navigation;
    using MvvmCross.Core.ViewModels;
    using Services;
    using ViewModel;

    public class HomeViewModel : MvxViewModel
    {
        ICalculationService _calculationService { get; set; }
        IMvxNavigationService _mvxNavigationService;

        // MVVMCross will pass CalculationService here in the constructor
        public HomeViewModel(ICalculationService calculationService, IMvxNavigationService mvxNavigationService)
        {
            _calculationService = calculationService;
            _mvxNavigationService = mvxNavigationService;
        }

        public HomeViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        private double AnyFunction()
        {
            // We are now free to refer _calculationService anywhere inside the viewmodel
            return _calculationService.TipAmount(10, 2);
        }

        public IMvxAsyncCommand ClickHereButton_Click
        {
            get
            {
                IMvxAsyncCommand navigationCommand = new MvxAsyncCommand(() => _mvxNavigationService.Navigate<TipCalcViewModel>());
                return navigationCommand;
            }
        }
    }
}