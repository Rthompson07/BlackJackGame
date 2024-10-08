using System;
using System.Collections.Generic;

namespace BlackJackGroup4
{
    public class Dealer
    {
        public Hand Hand { get; }

        public Dealer()
        {
            Hand = new Hand();
        }

        // Add a card to the dealer's hand
        public void AddCardToHand(Card card)
        {
            Hand.AddCard(card);
        }

        // Clear the dealer's hand
        public void ClearHand()
        {
            Hand.Clear();
        }

        // Get the total value of the dealer's hand
        public int GetHandValue()
        {
            return Hand.CalculateValue();
        }

        // Check if the dealer has blackjack
        public bool HasBlackjack()
        {
            return Hand.HasBlackjack();
        }

        // Check if the dealer has busted
        public bool HasBusted()
        {
            return Hand.HasBusted();
        }

        // Dealer's turn: Hit until the hand value reaches 17 or higher
        public void PlayTurn(Deck deck)
        {
            while (GetHandValue() < 17)
            {
                AddCardToHand(deck.Deal());
            }
        }
    }
}
