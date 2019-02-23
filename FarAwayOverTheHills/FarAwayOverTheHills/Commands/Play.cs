using System;

namespace FarAwayOverTheHills.Commands
{
    class Play : ICommands
    {
        public void Command()
        {
            Console.WriteLine("Playing, yay");
        }
    }
}
