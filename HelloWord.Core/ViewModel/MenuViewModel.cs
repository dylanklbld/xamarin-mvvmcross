namespace HelloWord.Core.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using MvvmCross.Core.ViewModels;
    using Services.DataScanning;
    using Services.Output;

    public class MenuViewModel : MvxViewModel
    {
        private IDataScanner _dataScanner { get; set; }

        //demo
        public class YesNoQuestion
        {
            public string Question { get; set; }
        }

        private MvxInteraction<YesNoQuestion> _interaction = new MvxInteraction<YesNoQuestion>();
        // need to expose it as a public property for binding (only IMvxInteraction is needed in the view)
        public IMvxInteraction<YesNoQuestion> Interaction
        {
            get
            {
                return _interaction;
            }
        }


        private void DoFinishProfileCommand()
        {
            // 1. do cool stuff with profile data
            // ...

            // 2. request interaction from view
            // 3. execution continues in callbacks
            var request = new YesNoQuestion
            {
                Question = "Do you want to save your profile?"
            };

            _interaction.Raise(request);
        }
        // demo

        public class DataEventArgs : EventArgs
        {
            public List<string> DataList;
        }

        public delegate void ScanDoneEvent(object sender, DataEventArgs args);
        public event ScanDoneEvent ScanDone;

        protected virtual void OnScanDone(List<string> dataList)
        {
            ScanDone?.Invoke(this, new DataEventArgs { DataList = dataList });
        }

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

        private async void RunScan()
        {
            var files = await _dataScanner.GetDataListAsync().ConfigureAwait(false);
            FilesCollection = new ObservableCollection<string>(files);
            DoFinishProfileCommand();
        }

    }
}