using System;
using System.Collections.Generic;
using CardsLib;

namespace CardsConsole
{
    class Program
    {
        static void Main()
        {
            List<Cards> hand = new List<Cards>(){
                Cards.Five,
                Cards.Three,
                Cards.Two,
                Cards.Ace,
                Cards.Queen,
                Cards.King,
                Cards.Seven,
                Cards.Eight,
                Cards.Nine,
                Cards.Ten
            };
            int val = CardFunctions.longestRun(hand);
            //Console.WriteLine(val);
            Console.WriteLine(CardFunctions.StringToCard("KD"));
        }
    }
}
