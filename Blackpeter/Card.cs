using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackpeter
{
    public class Card
    {
        public int Value { get; private set; }
        public Suits.SuitType Suit { get; private set; }

        public Card(int value, Suits.SuitType suit)
        {
            Suit = suit;
            Value = value;
        }
    }
}
