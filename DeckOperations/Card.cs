using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOperations
{

    public abstract class AbstractCard
    {
        public void DisplayCard(AbstractCard abstractCard)
        {
            string displayOutput = "";
            if (abstractCard.GetType() == typeof(Card))
            {
                var card = (abstractCard as Card);
                var displayedValue = "";
                switch (card.Value)
                {
                    case 13:
                        displayedValue = "K";
                        break;
                    case 12:
                        displayedValue = "Q";
                        break;
                    case 11:
                        displayedValue = "J";
                        break;
                    case 1:
                        displayedValue = "A";
                        break;
                    default:
                        displayedValue = card.Value.ToString();
                        break;
                }
                if (card.Suit.Color == SuitColors.Red)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                displayOutput = $"{card.Suit.Icon} {displayedValue}";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                displayOutput= "Joker";
            }

            Console.Write($"{displayOutput }    ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    public class Card: AbstractCard
    {
        public Suit Suit { get; set; }
        public int Value { get; set; }
    }

    public class Joker : AbstractCard
    { 

    }
}
