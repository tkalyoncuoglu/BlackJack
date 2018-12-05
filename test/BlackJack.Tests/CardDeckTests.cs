using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Console;

namespace BlackJack.Tests
{
    public class Polina
    {
        public void Dance()
        {
            WriteLine("Hey! I am dancing...");
        }

        // BlackJack.Tests.GetAge(polina)

        public int GetAge()
        {
            return (DateTime.UtcNow.Year - 1999);
        }

        public void WriteLine(string input)
        {
            System.Console.WriteLine(input);
        }
    }

    public class Alexey
    {
        public static string GetGreeting()
        {
            return "Howdy!";
        }
    }

    [TestClass]
    public class CardDeckTests
    {
        public IEnumerable<Card> GetCards(List<int> lst) =>
            lst.Select(i => new Card
            {
                Number = i,
                Color = CardColor.Spades
            });

        public int GetHandScore(IEnumerable<Card> cards)
        {
            return cards.Sum(c => c.GetValue());
        }

        [TestMethod]
        public void TestMethod1()
        {
            var polina = new Polina();
            polina.Dance();

            var lst = new List<int>() { 6, 7, 8 };
            var cards = GetCards(lst).ToList();

            foreach (var card in cards)
            {
                WriteLine($"Card: {card.GetCaption()}");
            }

            WriteLine($"Hand score: {GetHandScore(cards)}");

            WriteLine($"Int max: {long.MaxValue}");
        }


    }
}
