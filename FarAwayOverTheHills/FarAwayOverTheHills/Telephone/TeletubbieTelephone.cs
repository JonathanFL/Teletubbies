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
