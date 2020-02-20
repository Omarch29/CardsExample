using System;

namespace DeckOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Card Deck Code Interview");
            var deck = new Deck();
            Console.WriteLine("Step 1");
            deck.DisplayDeck();

            JumpStep();
            Console.WriteLine("Step 2");
            deck.ShuffleDeck();
            deck.DisplayDeck();

            JumpStep();

            Console.WriteLine("Step 3");
            Console.WriteLine("insert the number of players");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            Console.WriteLine("insert the number of cards");
            int numberOfCards = int.Parse(Console.ReadLine());
            var croupier = new Croupier(deck);

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.WriteLine($"insert the name of the player { i }");
                croupier.CreatePlayer(Console.ReadLine());
            }

            deck = croupier.DealCards(numberOfCards);
            foreach (var player in croupier.Players)
            {
                Console.WriteLine(player.Name);
                player.DisplayHand();
                Console.WriteLine();
            }


            Console.ReadKey();
        }

        public static void JumpStep()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
