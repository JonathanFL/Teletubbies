using System;
using System.Collections.Generic;
using System.Text;
using FarAwayOverTheHills.Commands;

namespace FarAwayOverTheHills.Tubbies
{
    class Poo : ITeleTubbies
    {
        private readonly string _name;

        public Poo(string name)
        {

        }
        public void Update(ICommands commands)
        {
            Console.WriteLine("Poo says:");
            commands.Command();
        }
    }
}
