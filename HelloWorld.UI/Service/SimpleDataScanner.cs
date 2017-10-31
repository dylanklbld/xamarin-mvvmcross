namespace HelloWorld.UI.Service
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using HelloWord.Core.Services.DataScanning;
    using Environment = Android.OS.Environment;

    public class SimpleDataScanner : IDataScanner
    {
        private List<string> _scanResult { get; set; }

        public SimpleDataScanner()
        {
            _scanResult = new List<string>();
        }

        public List<string> GetDataList(string root = null)
        {
            var path = (root != null) ? root : Environment.RootDirectory.AbsolutePath;
            try
            {
                TreeScan(path);
            }
            catch (Exception)
            {
                
                throw;
            }

            return _scanResult;
        }

        public Task<List<string>> GetDataListAsync(string root = null)
        {
            throw new NotImplementedException();
        }

        private void TreeScan(string path)
        {
            foreach (var file in Directory.GetFiles(path))
            {

                _scanResult.Add(file);
            }
            foreach (string dir in Directory.GetDirectories(path))
            {
                TreeScan(dir);
            }
        }
    }
}
