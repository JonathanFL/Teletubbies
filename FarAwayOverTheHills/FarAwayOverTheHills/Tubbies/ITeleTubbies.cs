using System;
using System.Collections.Generic;
using System.Text;
using FarAwayOverTheHills.Telephone;
using FarAwayOverTheHills.Commands;

namespace FarAwayOverTheHills.Tubbies
{
    interface ITeleTubbies
    {
        /*void SayHello();
        void Play();
        void TimeForCustard();
        void SayByeBye();*/

        void Update(ICommands commands);
    }
}
