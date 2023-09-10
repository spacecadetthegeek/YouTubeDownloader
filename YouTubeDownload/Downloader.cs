using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YouTubeDownload
{
    public class Downloader
    {
        public async void DownloadAsync(string videoUrl)
        {
            var youtube = new YoutubeClient();

            Console.WriteLine("Начало загрузки видео");

            var video = await youtube.Videos.GetAsync(videoUrl);

            await youtube.Videos.DownloadAsync(videoUrl, $@"Downloads/{video.Title}.mp4", v => v
            .SetContainer("mpeg")
            .SetPreset(ConversionPreset.UltraFast)
            .SetFFmpegPath(@"bin/Debug/net7.0/ffmpeg"));
        }

        public void StopDownload()
        {
            throw new NotImplementedException();
        }
    }
}
