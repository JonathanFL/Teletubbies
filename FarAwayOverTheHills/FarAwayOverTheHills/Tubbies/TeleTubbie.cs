using System;
using System.Collections.Generic;
using System.Text;
using FarAwayOverTheHills.Commands;
using FarAwayOverTheHills.Telephone;

namespace FarAwayOverTheHills.Tubbies
{
    class TeleTubbie : TelephoneSubject
    {
        private ITelephoneObserver _teleTubbies;

        public TeleTubbie(ITelephoneObserver teleTubbies, TelephoneSubject telephone)
        {
            _teleTubbies = teleTubbies;
            telephone.Attach(_teleTubbies);
        }

        public void TeleTubbieDetach(TelephoneSubject testSubject)
        {
            testSubject.Detatch(_teleTubbies);
        }
    }
}
