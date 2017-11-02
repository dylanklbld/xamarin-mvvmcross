namespace HelloWorld.UI
{
    using System.Collections.Generic;
    using Android.Widget;
    using HelloWord.Core.Services.Output;
    internal class SimpleDataPresenterService : IDataPresenter
    {
        public void OutputData(List<string> data)
        {
     //       Toast.MakeText(string.Join("\n", data), ToastLength.Long);
        }
    }
}