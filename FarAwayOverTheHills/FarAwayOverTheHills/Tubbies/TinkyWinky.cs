using System;
using FarAwayOverTheHills.Commands;

namespace FarAwayOverTheHills.Tubbies
{
    class TinkyWinky : ITelephoneObserver
    {
        public void Update(ICommands commands)
        {
            Console.WriteLine("TinkyWinky says:");
            commands.Command();
        }
    }
}
