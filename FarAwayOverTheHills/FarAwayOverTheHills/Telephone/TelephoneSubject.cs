using System;
using System.Collections.Generic;
using System.Text;
using FarAwayOverTheHills.Commands;
using FarAwayOverTheHills.Tubbies;

namespace FarAwayOverTheHills.Telephone
{
    class TelephoneSubject
    {
        private List<ITeleTubbies> observers = new List<ITeleTubbies>();

        public void Attach(ITeleTubbies observer)
        {
            observers.Add(observer);
        }

        public void Detatch(ITeleTubbies observer)
        {
            observers.Remove(observer);
        }

        public void Notify(ICommands commands)
        {
            foreach (ITeleTubbies teleTubbies in observers)
            {
                teleTubbies.Update(commands);
            }
        }
    }
}
