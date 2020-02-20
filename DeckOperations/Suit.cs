using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOperations
{
    public enum SuitColors { Red, Black }
    public enum SuistEnum { Diamond, Club, Heart, Spade }
    public class Suit
    {
        public SuistEnum Name { get; set; }
        public SuitColors Color { get; set; }
        public char Icon { get; set; }
    }
}
