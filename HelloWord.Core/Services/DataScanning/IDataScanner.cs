namespace HelloWord.Core.Services.DataScanning
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDataScanner
    {
        List<string> GetDataList(string root = null);
        Task<List<string>> GetDataListAsync(string root = null);
    }
}