using System;

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
