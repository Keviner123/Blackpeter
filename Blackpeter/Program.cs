using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackpeter
{
    class Program
    {
        static void Main(string[] args)
        {
            CardDeck MyCardDeck = new CardDeck();

            //Add all the cards in a standard deck of 52 card deck.
            foreach (Suits.SuitType suit in (Suits.SuitType[])Enum.GetValues(typeof(Suits.SuitType)))
            {
                for (int i = 1; i <= 1; i++)
                {
                    MyCardDeck.Cards.Add(new Card(i, suit));
                }
            }


            //Shuffle the cards
            MyCardDeck.ShuffleCards();




            string myText =
            @"┌─────┐
│V    │
│  S  │
│    V│
└─────┘";


            //            string myText1 =
            //            @"
            //┌─────────┐
            //│░░░░░░░░░│
            //│░░░░░░░░░│
            //│░░░░░░░░░│
            //│░░░░░░░░░│
            //│░░░░░░░░░│
            //│░░░░░░░░░│
            //│░░░░░░░░░│    
            //└─────────┘";

            var sb = new System.Text.StringBuilder();





            for (int i = 0; i < myText.Split('\n').Length; i++)
            {
                for (int u = 0; u < MyCardDeck.Cards.Count(); u++)
                {
                    sb.AppendLine(myText.Split('\n')[i].Replace("S", "♥").Replace("V", "5").Replace('\n',' '));
                }
                sb.AppendLine("B");
            }

            string fuckyou = (sb.ToString().Split('B')[0]);
            Console.WriteLine("---");
            Console.WriteLine(fuckyou);
            Console.WriteLine("---");


            Console.ReadKey();
        }
    }
}
