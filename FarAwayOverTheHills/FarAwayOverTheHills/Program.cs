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

            TeleTubbie dipsy = new TeleTubbie(new Dipsy("Jonathan Dipsy"), tlfSub);
            TeleTubbie Lala = new TeleTubbie(new Lala("test"), tlfSub);
            TeleTubbie tinkyWinky = new TeleTubbie(new TinkyWinky("test"), tlfSub);


            tlfSub.Notify(new SayHello());
            tlfSub.Notify(new Play());
            tinkyWinky.TeleTubbieDetach(tlfSub);
            tlfSub.Notify(new HaveDinner());

            tlfSub.Notify(new SayGoodBye());

            dipsy.TeleTubbieDetach(tlfSub);

            tlfSub.Notify(new SayHello());


            Console.ReadLine();
        }
    }
}
