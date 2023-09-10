using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload
{
    class Client
    {
        public static void ClientRun(string videoUrl)
        {
            var commandPanel = new CommandPanel();
            
            var downloader = new Downloader();

            var description = new Description();

            commandPanel.SetCommandPanel(new DescriptionCommand(description, videoUrl)); ;

            commandPanel.StartCommand();

            commandPanel.SetCommandPanel(new Download(downloader, videoUrl));

            commandPanel.StartCommand();

            Console.Read();
        }
    }
}
