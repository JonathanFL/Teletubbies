using System;
using System.Collections.Generic;
using FarAwayOverTheHills.Commands;
using FarAwayOverTheHills.Tubbies;
using FarAwayOverTheHills.Telephone;

namespace FarAwayOverTheHills
{
    class Program
    {
        static void Main()
        {
            //Subject
            TeletubbieTelephone tlfSub = new TeletubbieTelephone();

            //Observers "subscribe" to subject
            TeleTubbie dipsy = new TeleTubbie(new Dipsy(), tlfSub);
            TeleTubbie lala = new TeleTubbie(new Lala(), tlfSub);
            TeleTubbie tinkyWinky = new TeleTubbie(new TinkyWinky(), tlfSub);

            //Subject gives global messages
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

            tlfSub.Call(new SayHello());  // only lala says Hello when being notified


            Console.ReadLine();
        }
    }
}
