namespace HelloWord.Core.ViewModel
{
    using System.Collections.ObjectModel;
    using MvvmCross.Core.ViewModels;
    using Services.DataScanning;

    public class MenuViewModel : MvxViewModel
    {
        private IDataScanner _dataScanner { get; set; }

        public MenuViewModel(IDataScanner dataScanner)
        {
            _dataScanner = dataScanner;
            RunScan();
        }

        private ObservableCollection<string> _filesCollection;
        public ObservableCollection<string> FilesCollection
        {
            get { return _filesCollection; }
            set
            {
                _filesCollection = value;
                RaisePropertyChanged(() => FilesCollection);
            }
        }

        private void RunScan()
        {
            var files = _dataScanner.GetDataList();
            FilesCollection = new ObservableCollection<string>(files);
        }


    }
}