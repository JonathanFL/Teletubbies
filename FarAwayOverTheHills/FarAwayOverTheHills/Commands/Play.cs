using System;
using System.Collections.Generic;
using System.Text;

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
