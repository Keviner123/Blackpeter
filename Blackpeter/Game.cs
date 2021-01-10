using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackpeter
{
    public class Game
    {
        public List<Card> Cards { get; set; }
        public List<Player> Players { get; set; }

        public void ShuffleCards()
        {
            this.Cards = this.Cards.OrderBy(a => Guid.NewGuid()).ToList();
        }
        
        public void RemoveCardWithSuiteAndValue(int Value, Suits.SuitType Suit)
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                if(Cards[i].Value == Value && Cards[i].Suit == Suit)
                {
                    //Remove the card if a match is found
                    Cards.RemoveAt(i);
                }
            }
        }

        public void CheckForPair(Player player)
        {
            for (int i = 0; i < player.Hand.Count; i++)
            {
                for (int j = 0; j < player.Hand.Count; j++)
                {
                    if(player.Hand[i] != player.Hand[j])
                    {
                        if ((player.Hand[i].Color == player.Hand[j].Color) && (player.Hand[i].Value == player.Hand[j].Value))
                        {
                            List<Card> itemsToRemove = new List<Card>();
                            itemsToRemove.Add(player.Hand[j]);
                            itemsToRemove.Add(player.Hand[i]);


                            foreach (Card value in itemsToRemove)
                            {
                                player.Hand = player.Hand.Where(x => x != value).ToList();
                            }
                        }
                    }

                }
            }
        }

        public Game()
        {
            this.Cards = new List<Card>();
            this.Players = new List<Player>();
        }
    }
}
