using System;
using FarAwayOverTheHills.Commands;

namespace FarAwayOverTheHills.Tubbies
{
    class Poo : ITelephoneObserver
    {
        public void Update(ICommands commands)
        {
            Console.WriteLine("Poo says:");
            commands.Command();
        }
    }
}
