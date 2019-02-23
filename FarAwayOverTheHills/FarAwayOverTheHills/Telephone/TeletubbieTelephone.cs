using System;
using System.Collections.Generic;
using System.Text;
using FarAwayOverTheHills.Commands;

namespace FarAwayOverTheHills.Telephone
{
    class TeletubbieTelephone : TelephoneSubject
    {
        public void Call(ICommands commands)
        {
            Notify(commands);
        }
    }
}
