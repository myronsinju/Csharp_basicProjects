using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(deck.Cards.First());
            Console.WriteLine(deck.Cards.First().ToString() + "\n");
            deck.Cards.RemoveAt(0);

        }
    }
}
