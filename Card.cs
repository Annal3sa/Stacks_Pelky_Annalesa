using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Pelky_Annalesa
{
    internal class Card
    {
        // Create two properties with an automatic getter. Both of the string data type. One named Number.The other named Suit.
        public string Number { get; }

        public string Suit { get; }

        //Create a constructor that has two parameters, number and suit.
        public Card(char numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;

        }

    }
}
