using System;
using System.Collections.Generic;
using System.Text;

namespace FarAwayOverTheHills.Commands
{
    class WatchTelevision : ICommands
    {
        public void Command()
        {
            Console.WriteLine("OK! I will watch television now");
        }
    }
}
