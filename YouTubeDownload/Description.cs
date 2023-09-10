using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTubeDownload
{
    class Description
    {
        public async void ShowDescription(string videoURL)
        {
            var youtube = new YoutubeClient();

            var description = await youtube.Videos.GetAsync(videoURL);

            Console.WriteLine();
            Console.WriteLine($"Название видео: {description.Title}");
            Console.WriteLine();
            Console.WriteLine($"Описание: {description.Description}");
        }
    }
}
