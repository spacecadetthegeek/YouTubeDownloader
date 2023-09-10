using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload
{
    public interface ICommand
    {
        void Excecute();
        void Undo();
    }
}
