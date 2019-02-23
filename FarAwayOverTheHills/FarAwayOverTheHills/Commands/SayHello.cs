using System;
using System.Collections.Generic;
using System.Text;

namespace FarAwayOverTheHills.Commands
{
    class SayHello : ICommands
    {
        public void Command()
        {
            Console.WriteLine("Hello");
        }
    }
}
