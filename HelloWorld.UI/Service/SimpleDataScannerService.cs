namespace HelloWorld.UI.Service
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using HelloWord.Core.Services.DataScanning;
    using Environment = Android.OS.Environment;

    public class SimpleDataScannerService : IDataScanner
    {
        private List<string> _scanResult { get; set; }

        public SimpleDataScannerService()
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

        public async Task<List<string>> GetDataListAsync(string root = null)
        {
            var path = (root != null) ? root : Environment.RootDirectory.AbsolutePath;
            try
            {
                await Task.Run(()=>TreeScan(path));
            }
            catch (Exception e)
            {

                throw e;
            }

            return _scanResult;
        }

        private void TreeScan(string path)
        {
            foreach (var file in Directory.GetFiles(path))
            {
                _scanResult.Add(file);
            }
            //foreach (string dir in Directory.GetDirectories(path))
            //{
            //    TreeScan(dir);
            //}
        }


    }
}
