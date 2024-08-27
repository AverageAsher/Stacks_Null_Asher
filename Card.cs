using System;
using System.Collections.Generic;

namespace CardGame
{
    // Define the Card class
    public class Card
    {
        // Automatic property for the card number (e.g., "A", "8", "10")
        public string Number { get; private set; }

        // Automatic property for the card suit (e.g., "Hearts", "Spades")
        public string Suit { get; private set; }

        // Constructor to initialize a card with a number and suit
        public Card(string number, string suit)
        {
            // Assign the passed number to the Number property
            Number = number;

            // Assign the passed suit to the Suit property
            Suit = suit;
        }
    }
}