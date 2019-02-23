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
            TeletubbieTelephone tlfSub = new TeletubbieTelephone();

            TeleTubbie dipsy = new TeleTubbie(new Dipsy("Jonathan Dipsy"), tlfSub);
            TeleTubbie Lala = new TeleTubbie(new Lala("test"), tlfSub);
            TeleTubbie tinkyWinky = new TeleTubbie(new TinkyWinky("test"), tlfSub);


            tlfSub.Call(new SayHello());
            Console.WriteLine("");
            tlfSub.Call(new Play());
            Console.WriteLine("");

            tinkyWinky.TeleTubbieDetach(tlfSub);//tinkyWinky "unsubscribes"

            tlfSub.Call(new HaveDinner());
            Console.WriteLine("");

            tlfSub.Call(new SayGoodBye());
            Console.WriteLine("");

            dipsy.TeleTubbieDetach(tlfSub); // dipsy "unsubscribes"

            tlfSub.Call(new SayHello());  // only lala says Hello


            Console.ReadLine();
        }
    }
}
