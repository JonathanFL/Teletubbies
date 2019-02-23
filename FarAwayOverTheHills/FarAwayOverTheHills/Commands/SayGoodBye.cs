using System;
using System.Collections.Generic;
using System.Text;

namespace FarAwayOverTheHills.Commands
{
    class SayGoodBye : ICommands
    {
        public void Command()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
