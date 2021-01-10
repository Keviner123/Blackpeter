using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blackpeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Game BlackPeterGame = new Game();
            Random rnd = new Random();

            //Add players
            for (int i = 0; i < 2; i++)
            {
                BlackPeterGame.Players.Add(new Player());
            }

            //Add all the cards in a standard deck of 52 card deck.
            foreach (Suits.SuitType suit in (Suits.SuitType[])Enum.GetValues(typeof(Suits.SuitType)))
            {
                for (int i = 1; i <= 13; i++)
                {
                    BlackPeterGame.Cards.Add(new Card(i, suit));
                }
            }

            //Shuffle the cards
            BlackPeterGame.ShuffleCards();

            //Remove Spade Knight so that Clubs Knight become black peter
            BlackPeterGame.RemoveCardWithSuiteAndValue(10, Suits.SuitType.Spades);

            //Alternerne giving out cards
            int LastPlayerThatDrew = 0;
            for (int i = 0; i < BlackPeterGame.Cards.Count; i++)
            {
                if(LastPlayerThatDrew == 0)
                {
                    BlackPeterGame.Players[0].Hand.Add(BlackPeterGame.Cards[i]);
                    LastPlayerThatDrew = 1;
                }
                else
                {
                    BlackPeterGame.Players[1].Hand.Add(BlackPeterGame.Cards[i]);
                    LastPlayerThatDrew = 0;
                }
            }

            //Remove inital pairs from both players
            for (int i = 0; i < BlackPeterGame.Players.Count; i++)
            {
                //BlackPeterGame.CheckForPair(BlackPeterGame.Players[i]);
            }

            
            while (true)
            {

                for (int i = 0; i < BlackPeterGame.Players.Count; i++)
                {

                    //Check if a winner has been found
                    if(BlackPeterGame.Players[i].Hand.Count == 1)
                    {
                        Console.WriteLine("Winner is player: "+i);
                        Console.ReadKey();
                    }

                    int PlayerToTheLeft;
                    if (i == BlackPeterGame.Players.Count - 1)
                    {
                        PlayerToTheLeft = 0;
                    }
                    else
                    {
                        PlayerToTheLeft = 1;
                    }


                    int OpponentCardIndex = rnd.Next(1, BlackPeterGame.Players[PlayerToTheLeft].Hand.Count);

                    Card TakenCard = BlackPeterGame.Players[PlayerToTheLeft].TakeCardAtIndex(OpponentCardIndex);
                    BlackPeterGame.Players[0].Hand.Add(TakenCard);
                    BlackPeterGame.CheckForPair(BlackPeterGame.Players[i]);
                }

                Console.WriteLine("P1:" + BlackPeterGame.Players[0].Hand.Count);
                Console.WriteLine("P2:" + BlackPeterGame.Players[1].Hand.Count);

                Thread.Sleep(3);
                Console.Clear();
            }
        }
    }
}
