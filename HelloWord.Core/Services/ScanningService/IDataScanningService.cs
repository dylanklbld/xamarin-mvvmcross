namespace HelloWord.Core.Services.ScanningService
{
    using System.Collections.Generic;

    public interface IDataScanningService
    {
        List<string> GetScanResultList(string root = null);
    }
}