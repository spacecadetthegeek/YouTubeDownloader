using System;
using YouTubeDownload;

namespace YoutubeDownload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вставьте ссылку на You-Tube-видео: ");

            Console.WriteLine();

            var videoUrl = Console.ReadLine();

            Client.ClientRun(videoUrl);
        }
    }
}