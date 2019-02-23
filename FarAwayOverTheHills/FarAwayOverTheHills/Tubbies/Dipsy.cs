using System;
using FarAwayOverTheHills.Commands;

namespace FarAwayOverTheHills.Tubbies
{
    class Dipsy : ITelephoneObserver
    {
        public void Update(ICommands commands)
        {
            Console.WriteLine("Dipsy says:");
            commands.Command();
        }
    }
}
