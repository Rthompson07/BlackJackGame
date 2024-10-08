using System;
using System.Drawing;

namespace BlackJackGroup4
{
    /// <summary>
    /// Card.cs contains the Card class.
    /// 
    /// Card has three properties: Suit, Rank, and Image.
    /// Suit and Rank are Enums which frame the possible values the cards can have, while Image is used to 
    /// represent the image of the card which will be used in the game GUI.
    /// 
    /// Card has 1 method, an override of ToString() which allows for a nicely formated printing, mostly for debugging.
    /// 
    /// </summary>

    public class Card
    {
        public Suit Suit { get; }
        public Rank Rank { get; }
        public Image Image { get; }

        public Card(Suit suit, Rank rank, Image image)
        {
            Suit = suit;
            Rank = rank;
            Image = image;
        }

        public override string ToString()
        {
            if (Suit.Equals(Suit.NULL))
            {
                return $"{Rank}";
            }
            else
            {
                return $"{Rank} of {Suit}";

            }
        }
    }
    // Enum to represent card suits
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades,
        NULL
    }

    // Enum to represent card ranks
    public enum Rank
    {
        Ace = 11,
        Two = 2,
        Three = 3,
        Four = 4,
        Five =5,
        Six = 6,
        Seven =7,
        Eight =8,
        Nine = 9,
        Ten = 10,
        Jack = 10,
        Queen = 10,
        King = 10,
        Joker = 15
    }
}
