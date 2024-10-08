using BlackJack_Console;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace BlackJackGroup4
{
    /// <summary>
    /// Deck.cs contains the class Deck, which contains one property, a list of Card items.
    /// 
    /// Deck can be intialized in two ways, based on getting a boolean originating from the main menu form. 
    /// If false a standard deck of 52 cards is created, if true then two Joker cards are also added. 
    /// 
    /// Deck has 5 public methods:
    /// 
    /// -Shuffle(): randomly reorders the cards in the deck.
    /// 
    /// -Deal(): Returns the card on the 'top' of the deck, and removes it from the deck.
    /// 
    /// -Reset(): Initialized a new standard deck.
    /// 
    /// -isEmpty(): Returns a boolean, true if there are zero remaining cards in the deck, and false otherwise.
    /// 
    /// -DisplayRemainingCards(): for debugging help.
    /// 
    /// </summary>
    
    public class Deck
    {
        private List<Card> cards;
        

        // Create a standard deck of cards
        public Deck(bool JokerMode)
        {
            cards = new List<Card>();
            InitializeDeck(JokerMode);
        }

        // Initialize deck with 52 cards or 52 + 2 Jokers.
        private void InitializeDeck(bool JokerMode)
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                if (suit != Suit.NULL)
                {
                    foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                    {
                        if (rank != Rank.Joker)
                        {
                            // Load image from resources using suit and rank
                            string imageName = $"{suit.ToString().ToLower()}_{rank.ToString().ToLower()}";
                            Image image = Properties.Resources.ResourceManager.GetObject(imageName) as Image;
                            // Create a card with the suit, rank, and associated image
                            Card card = new Card(suit, rank, image);
                            cards.Add(card);
                        }
                    }
                }
            }
            if (JokerMode)
            {
                Image image = Properties.Resources.null_joker;
                // Create a card with the suit, rank, and associated image
                Card card = new Card(Suit.NULL, Rank.Joker, image);
                cards.Add(card);
                cards.Add(card);
            }

        }

        // Shuffle the deck
        public void Shuffle()
        {
            // Derived from: https://stackoverflow.com/questions/273313/randomize-a-listt
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        // Deal a card from the deck
        public Card Deal()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("The deck is empty.");
            }

            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        // Reset to full standard deck
        public void Reset(bool joker)
        {
            cards.Clear();
            InitializeDeck(joker);
        }

        // Display remaining cards in deck (for debugging)
        public void DisplayRemainingCards()
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }
        }
        public bool IsEmpty()
        {
            return cards.Count == 0;
        }
    }
}
