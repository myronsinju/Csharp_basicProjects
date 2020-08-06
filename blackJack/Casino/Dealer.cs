using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(deck.Cards.First());
            string card = string.Format(deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\18015\Documents\yeah.txt", true))
            {
                file.WriteLine(DateTime.Now); 
                file.WriteLine(card);
            }
            deck.Cards.RemoveAt(0);
        }
    }
}
