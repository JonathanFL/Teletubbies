using System;
using System.Collections.Generic;
using System.Text;
using FarAwayOverTheHills.Telephone;
using FarAwayOverTheHills.Commands;

namespace FarAwayOverTheHills.Tubbies
{
    interface ITelephoneObserver
    {
        void Update(ICommands commands);
    }
}
