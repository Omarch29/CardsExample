using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckOperations
{
    public class Croupier
    {

        public Croupier(Deck deck)
        {
            Deck = deck;
            Players = new List<Player>();
        }

        public List<Player> Players { get; set; }
        public Deck Deck { get; set; }

        public void CreatePlayer(string playerName)
        {
            Players.Add(new Player()
            {
                Name = playerName
            });
        }

        public Deck DealCards(int numberOfCards)
        {
            for (int i = 0; i < numberOfCards; i++)
            {
                foreach (var player in Players)
                {
                    var card = Deck.Cards.First();
                    Deck.Cards.RemoveAt(0);
                    player.AddCard(card);
                }
            }
            
            return Deck;
        }
    }
}
