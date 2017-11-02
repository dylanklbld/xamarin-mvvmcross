namespace HelloWord.Core.Services.Output
{
    using System.Collections.Generic;

    public interface IDataPresenter
    {
        void OutputData(List<string> data);
    }
}