using System;
using System.Collections.Generic;

namespace CowboyCafe
{
    class CowboyCafe
    {
        static void Main(string[] args)
        {
            PecosPulledPork ppp = new PecosPulledPork();
            ppp.Bread = false ;
            ppp.Pickles = false;
            foreach (string s in ppp.SpecialInstructions)
            {
                Console.WriteLine(s);
            }
        }
    }

    

    
}
