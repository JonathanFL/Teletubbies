using System;

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
