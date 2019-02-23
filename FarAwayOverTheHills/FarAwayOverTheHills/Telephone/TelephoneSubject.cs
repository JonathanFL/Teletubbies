using System;
using System.Collections.Generic;
using System.Text;
using FarAwayOverTheHills.Commands;
using FarAwayOverTheHills.Tubbies;

namespace FarAwayOverTheHills.Telephone
{
    abstract class TelephoneSubject
    {
        private List<ITelephoneObserver> observers = new List<ITelephoneObserver>();

        public void Attach(ITelephoneObserver observer)
        {
            observers.Add(observer);
        }

        public void Detatch(ITelephoneObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(ICommands commands)
        {
            foreach (ITelephoneObserver teleTubbies in observers)
            {
                teleTubbies.Update(commands);
            }
        }
    }
}
