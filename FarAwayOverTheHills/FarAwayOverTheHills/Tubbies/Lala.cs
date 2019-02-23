using System;
using System.Collections.Generic;
using System.Text;
using FarAwayOverTheHills.Commands;

namespace FarAwayOverTheHills.Tubbies
{
    class Lala : ITelephoneObserver
    {
        private readonly string _name;

        public Lala(string name)
        {

        }
        public void Update(ICommands commands)
        {
            Console.WriteLine("Lala says:");
            commands.Command();
        }
    }
}
