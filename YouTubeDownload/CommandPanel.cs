using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload
{
    class CommandPanel
    {
        ICommand _command;

        public void SetCommandPanel(ICommand setCommand)
        {
            _command = setCommand;
        }

        public void StartCommand()
        {
            _command.Excecute();
        }

        public void UndoCommand()
        {
            throw new NotImplementedException();
        }
    }
}
