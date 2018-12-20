namespace BlackJack.Console
{ 
    class Program
    {
       

        static void Main(string[] args)  
        {
            var deck = new CardDeck();

            var card = new Card(Card.CardPicture.K, Card.CardColor.Spades);

            card.Print();

            for (int i = 0; i < 3; i++)
            {
                deck.Shuffle(11 + i);

                System.Console.WriteLine("Play deck of " + deck.CardCount() + " cards:");

                while (deck.HasCards())
                {
                    card = deck.PickCard();
                    card.Print();
                }

                System.Console.WriteLine("--- // ---");
                System.Console.WriteLine("Well done!");
            }
            System.Console.ReadKey();
        } 
    }
}
