using System;
using System.Collections.Generic;
using System.Text;

namespace CardsLib
{
    class CardClass
    {
        Cards _value;
        Suits _suit;
        public CardClass(Cards Value, Suits Suit)
        {
            _suit = Suit;
            _value = Value;
        }
    }
}
