using System;
using System.Collections.Generic;
using System.Text;
using FarAwayOverTheHills.Commands;

namespace FarAwayOverTheHills.Tubbies
{
    class TinkyWinky : ITeleTubbies
    {
        private readonly string _name;

        public TinkyWinky(string name)
        {

        }
        public void Update(ICommands commands)
        {
            Console.WriteLine("TinkyWinky says:");
            commands.Command();
        }
    }
}
