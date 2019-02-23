using System;

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
