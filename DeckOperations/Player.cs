using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOperations
{
    public class Player
    {
        public Player()
        {
            Hand = new List<AbstractCard>();
        }

        public string Name { get; set; }

        private List<AbstractCard> Hand { get; set; }

        public void AddCard(AbstractCard newCard) {
            Hand.Add(newCard);
        }

        public void DisplayHand() {
            foreach (var card in Hand)
            {
                card.DisplayCard(card);
            }            
        }
    }
}
