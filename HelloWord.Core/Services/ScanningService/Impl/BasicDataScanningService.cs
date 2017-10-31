namespace HelloWord.Core.Services.ScanningService.Impl
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    public class BasicDataScanningService: IDataScanningService
    {

        private string _basePath { get; set; }

        private string _music { get; set; }

        private List<string> _scanResult { get; set; }

        public BasicDataScanningService() 
        {
            _basePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            _music = Environment.DirectoryMusic;
            _scanResult = new List<string>();
        }


        public List<string> GetScanResultList(string root = null)
        {
            throw new System.NotImplementedException();
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