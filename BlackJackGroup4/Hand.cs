using System;
using System.Collections.Generic;

namespace BlackJackGroup4
{
    public class Hand
    {
        /// <summary>
        /// Hand.cs represents the cards being held by either player or dealer, containing one property, a List of Card objects.
        /// 
        /// Hand has 12 public methods, of which 10 are of interest:
        /// 
        /// -AddCard(): Accepts a card and adds it to the hand.
        /// 
        /// -CalculateValue(): Returns the int value of the hand.
        /// 
        /// -HasBlackJack(): Returns a bool, true if the player's hand equals exactly 21.
        /// 
        /// -HasBusted(): Returns a bool, true if the player's hand is over 21.
        /// 
        /// -Clear(): Empties the player's hand.
        /// 
        /// -GetNumberofCards(): Returns an int equal to the number of cards in the hand.
        /// 
        /// -GetCard(): Accepts an int indicating the index of the card in the hand, returns that as a card object and removes it from the hand.
        /// 
        /// -AceHole(): Returns a bool, true if the first card is an ace. This is used on the dealer's hand to determine if the game has entered a condition 
        /// where insurance is possible
        /// 
        /// -SplitCheck(): Returns a bool, true if the hand has two cards of the same rank, indicating a split hand is possible.
        /// 
        /// </summary>
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public int CalculateValue()
        {
            int sum = 0;
            int numOfAces = 0;
            int numofJokers = 0;

            foreach (Card card in cards)
            {
                sum += (int)card.Rank;
                if (card.Rank == Rank.Ace)
                {
                    numOfAces++;
                }
                if (card.Rank == Rank.Joker)
                {
                    numofJokers++;
                }
            }
            while (numofJokers > 0)
            {
                if (sum > 21)
                {
                    sum -= 10;
                    numofJokers--;
                }
                else
                {
                    break;
                }
            }

            // Aces are 11 unless that causes the hand to bust, if so they are 1.
            while (numOfAces > 0)
            {
                if (sum > 21)
                {
                    sum -= 10;
                    numOfAces--;
                }
                else
                {
                    break;
                }
            }
            return sum;
        }
        public int FirstCardValue()
        {
            return (int)cards[0].Rank;
        }

        public bool HasBlackjack()
        {
            if (cards.Count == 2)
            {
                bool hasAce = false;
                bool hasTenValueCard = false;

                foreach (var card in cards)
                {
                    if (card.Rank == Rank.Ace)
                    {
                        hasAce = true;
                    }
                    else if (card.Rank == Rank.Ten || card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King)
                    {
                        hasTenValueCard = true;
                    }
                }

                return hasAce && hasTenValueCard;
            }

            return false;
        }

        public bool HasBusted()
        {
            return CalculateValue() > 21;
        }

        public void Clear()
        {
            cards.Clear();
        }

        public int GetNumberOfCards()
        {
            return cards.Count;
        }

        public Card GetCard(int index)
        {
            if (index >= 0 && index < cards.Count)
            {
                return cards[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
        }

        public void Display()
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }
        }

        public string ReturnHand()
        {
            string hand = "";
            foreach (Card card in cards)
            {
                hand += card.ToString() + "\n\r";
            }

            return hand;
        }

        public bool AceHole()
        {
            if (cards.Count > 0 && cards[0].Rank == Rank.Ace)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckSplit()
        {
            if (cards.Count >= 2 && cards[0].Rank == cards[1].Rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Card RemoveCard(int index)
        {
            if (index >= 0 && index < cards.Count)
            {
                Card removedCard = cards[index];
                cards.RemoveAt(index);
                return removedCard;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
        }
        public IEnumerator<Card> GetEnumerator()
        {
            return cards.GetEnumerator();
        }
    }
}
