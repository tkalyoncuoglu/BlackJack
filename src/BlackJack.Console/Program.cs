namespace BlackJack.Console
{ 
    class Program
    {
        static void PrintCard(Card card)
        {
            System.Console.WriteLine("Your Card: " + card.GetCaption() + " and it's value: " + card.GetValue());
        }

        static void Main(string[] args)  
        {
            var deck = new CardDeck();

            var card = new Card();
            card.Number = Card.GetPictureNumber(CardPicture.K);
            // card.Number = 10;
            card.Color = CardColor.Spades;

            PrintCard(card);

            for (int i = 0; i < 3; i++)
            {
                deck.Shuffle(11 + i);

                System.Console.WriteLine("Play deck of " + deck.CardCount() + " cards:");

                while (deck.HasCards())
                {
                    card = deck.PickCard();
                    PrintCard(card);
                }

                System.Console.WriteLine("--- // ---");
                System.Console.WriteLine("Well done!");
            }
            System.Console.ReadKey();
        } 
    }
}
