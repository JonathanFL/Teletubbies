using System.Collections.Generic;
using FarAwayOverTheHills.Commands;
using FarAwayOverTheHills.Tubbies;

namespace FarAwayOverTheHills.Telephone
{
    abstract class TelephoneSubject
    {
        private readonly List<ITelephoneObserver> _observers = new List<ITelephoneObserver>();

        public void Attach(ITelephoneObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detatch(ITelephoneObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(ICommands commands)
        {
            foreach (ITelephoneObserver teleTubbies in _observers)
            {
                teleTubbies.Update(commands);
            }
        }
    }
}
