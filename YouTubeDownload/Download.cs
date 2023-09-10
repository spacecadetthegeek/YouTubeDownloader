using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload
{
    public class Download : ICommand
    {
        Downloader _downloader;
        string _videoUrl;

        public Download(Downloader setDownloader, string setVideoUrl)
        {
            _downloader = setDownloader;
            _videoUrl = setVideoUrl;    
        }

        public async void Excecute()
        {
            _downloader.DownloadAsync(_videoUrl);
        }

        public async void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
