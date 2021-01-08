using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackpeter
{
    public class CardDeck
    {
        private List<Card> cards;

        public List<Card> Cards
        {
            get { return cards; }
            set { cards = value; }
        }
        public CardDeck()
        {
            Cards = new List<Card>();
        }

        public void ShuffleCards()
        {
            Console.WriteLine("♠	♥	♦	♣");
            this.Cards = this.Cards.OrderBy(a => Guid.NewGuid()).ToList();
        }
    }

}
