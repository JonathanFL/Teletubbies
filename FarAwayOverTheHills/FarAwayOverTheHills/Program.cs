using System;
using FarAwayOverTheHills.Commands;
using FarAwayOverTheHills.Tubbies;
using FarAwayOverTheHills.Telephone;

namespace FarAwayOverTheHills
{
    class Program
    {
        static void Main()
        {
            TelephoneSubject tlfSub = new TelephoneSubject();

            TeleTubbie teleTubbie = new TeleTubbie(new Dipsy("Jonathan Dipsy"), tlfSub);
            TeleTubbie teleTubbie2 = new TeleTubbie(new Dipsy("test"), tlfSub);

            tlfSub.Notify(new SayHello());
            tlfSub.Notify(new SayGoodBye());

            teleTubbie.TeleTubbieDetach(tlfSub);

            tlfSub.Notify(new SayHello());


            Console.ReadLine();
        }
    }
}
