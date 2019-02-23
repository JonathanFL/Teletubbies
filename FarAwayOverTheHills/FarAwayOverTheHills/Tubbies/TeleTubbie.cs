using System;
using System.Collections.Generic;
using System.Text;
using FarAwayOverTheHills.Commands;
using FarAwayOverTheHills.Telephone;

namespace FarAwayOverTheHills.Tubbies
{
    class TeleTubbie : TelephoneSubject
    {
        private ITeleTubbies _teleTubbies;

        public TeleTubbie(ITeleTubbies teleTubbies, TelephoneSubject telephone)
        {
            _teleTubbies = teleTubbies;
            telephone.Attach(_teleTubbies);
        }


        public void Notify(ICommands commands)
        {
            _teleTubbies.Update(commands);
        }

        public void TeleTubbieDetach(TelephoneSubject testSubject)
        {
            testSubject.Detatch(_teleTubbies);
        }
    }
}
