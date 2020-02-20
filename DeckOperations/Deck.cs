using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOperations
{
    public class Deck
    {
        public Deck()
        {
            var cardTypes = new List<Suit>() {
             new Suit() {
             Color = SuitColors.Red,
             Name= SuistEnum.Diamond,
             Icon='♦'
             },
              new Suit() {
             Color= SuitColors.Black,
             Name= SuistEnum.Club,
             Icon='♣'
             },
               new Suit() {
            Color= SuitColors.Red,
             Name= SuistEnum.Heart,
             Icon='♥'
             },
                new Suit() {
            Color= SuitColors.Black,
             Name=SuistEnum.Spade,
             Icon='♠'
             },
            };

            Cards = PopulateDeck(cardTypes, 13);
            AddJokers();
        }
        public List<AbstractCard> Cards { get; set; }

        public List<AbstractCard> PopulateDeck(IEnumerable<Suit> suits, int typeQty)
        {
            var cards = new List<AbstractCard>();

            foreach (var suit in suits)
            {
                for (int i = 1; i <= typeQty; i++)
                {
                    cards.Add(new Card()
                    {
                        Suit = suit,
                        Value = i,
                    });
                }
            }
            return cards;
        }

        public void AddJokers()
        {
            for (int i = 0; i < 2; i++)
            {
                Cards.Add(new Joker());
            }
        }

        public void DisplayDeck()
        {
            foreach (var card in Cards)
            {
                card.DisplayCard(card);
            }
        }

        public void ShuffleDeck()
        {
            Cards.Shuffle<AbstractCard>();
            
        }
    }
}
