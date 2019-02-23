using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using FarAwayOverTheHills;
using FarAwayOverTheHills.Commands;
using FarAwayOverTheHills.Telephone;

namespace FarAwayOverTheHills.Tubbies
{
    class Dipsy : ITeleTubbies
    {
        private readonly string _name;

        public Dipsy(string name)
        {

        }

        public void Update(ICommands commands)
        {
            Console.WriteLine("Dipsy says:");
            commands.Command();
        }
    }
}
