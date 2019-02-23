using System;
using FarAwayOverTheHills.Commands;

namespace FarAwayOverTheHills.Tubbies
{
    class Lala : ITelephoneObserver
    {
        public void Update(ICommands commands)
        {
            Console.WriteLine("Lala says:");
            commands.Command();
        }
    }
}
