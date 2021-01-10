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
        public CardColors.Color Color { get; private set; }

        public Card(int value, Suits.SuitType suit)
        {
            Suit = suit;
            Value = value;

            //Set card color based on its suit
            if (Suit == Suits.SuitType.Spades || Suit == Suits.SuitType.Clubs)
            {
                this.Color = CardColors.Color.Black;
            }
            else
            {
                this.Color = CardColors.Color.Red;
            }
        }
    }
}
