using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload
{
    class DescriptionCommand : ICommand
    {
        Description _description;
        string _videoURL;

        public DescriptionCommand(Description setDescription, string setVideoURL)
        {
            _description = setDescription;
            _videoURL = setVideoURL;
        }

        public void Excecute()
        {
            _description.ShowDescription(_videoURL);
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
