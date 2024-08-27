using CardGame;

class Program
{
    static void Main(string[] args)
    {
        // Create an array of Card objects with appropriate values
        Card[] cards = new Card[]
        {
                new Card("A", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("3", "Clubs"),
                new Card("4", "Spades"),
                new Card("5", "Hearts"),
                new Card("6", "Diamonds"),
                new Card("7", "Clubs")
        };

        // Create a stack to represent the deck of cards
        Stack<Card> startingDeck = new Stack<Card>();

        // Push each card from the array to the stack
        foreach (var card in cards)
        {
            startingDeck.Push(card);
        }

        // Print the number of cards in the deck
        Console.WriteLine("Cards in the deck:");

        // Loop through the stack and print each card's details
        foreach (var card in startingDeck)
        {
            Console.WriteLine($"The {card.Number} of {card.Suit}!");
        }

        // Print the number of cards currently in the stack
        Console.WriteLine($"Number of cards in the deck: {startingDeck.Count}");

        // Create a list to represent the player's hand
        List<Card> myHand = new List<Card>();

        // Add three cards to the player's hand
        myHand.Add(new Card("8", "Spades"));
        myHand.Add(new Card("Q", "Hearts"));
        myHand.Add(new Card("K", "Diamonds"));

        // Print a message asking for a specific card
        Console.WriteLine("Got any 8's?");

        // Check if there are any cards left in the stack before popping
        if (startingDeck.Count > 0)
        {
            // Add a card from the deck to the player's hand by popping it from the stack
            myHand.Add(startingDeck.Pop());
        }

        // Print the number of cards currently in the stack
        Console.WriteLine($"Number of cards in the deck: {startingDeck.Count}");

        // Place one of the cards from the player's hand back into the deck
        Card cardToReturn = myHand[0];
        startingDeck.Push(cardToReturn);

        // Remove the card that was placed back in the deck from the player's hand
        myHand.RemoveAt(0);

        // Print the number of cards in the deck after adding the card back
        Console.WriteLine("Cards in the deck:");

        // Loop through the stack and print each card's details
        foreach (var card in startingDeck)
        {
            Console.WriteLine($"The {card.Number} of {card.Suit}!");
        }
    }
}