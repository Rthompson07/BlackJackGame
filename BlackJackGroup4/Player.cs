using System;

namespace BlackJackGroup4
{
    /// <summary>
    /// Player.cs represents a player of the game, with 4 properties, Name, Hand, Wallet, and Current Bet.
    /// 
    /// Player has 10 public methods:
    /// 
    /// -AddCardToHand(): Accepts a card and adds it to the player's hand.
    /// 
    /// -GetHandValue(): A wrapper method for Hand.CalculateValue().
    /// 
    /// -ClearHand(): Empties the player's hand.
    /// 
    /// -HasBlackJack(): A wrapper method for Hand.HasBlackJack().
    /// 
    /// -HasBusted(): A wrapper method for Hand.HasBusted().
    /// 
    /// -PlaceBet(): Accepts an int amount from the game form, and moves the move from wallet into player bet.
    /// 
    /// -AddToWallet(): Accepts an int amount and adds it to the wallet.
    /// 
    /// -ResetBet(): Returns the player's bet to the wallet.
    /// 
    /// -CanSplit(): A wrapper method for Hand.CanSplit().
    /// 
    /// </summary>
    public class Player: User
    {
        public string Name { get; set; }
        public Hand Hand { get; }
        public int Wallet { get; set; }
        public int CurrentBet { get; private set; }

        public PlayerStats Stats { get; set; }

        public Player(string name, int initialWallet):base()
        {
            Name = name;
            Hand = new Hand();
            Wallet = initialWallet;
            CurrentBet = 0;
        }
        public Player(string name) : base(name)
        {
            
            Name = name;
            Hand = new Hand();
            Wallet = 2000;
            CurrentBet = 0;
        }
        public Player() : base()
        {
            Name = "";
            Hand = new Hand();
            Wallet = 2000;
            CurrentBet = 0;
        }

        public void AddCardToHand(Card card)
        {
            Hand.AddCard(card);
        }

        public void ClearHand()
        {
            Hand.Clear();
        }

        public int GetHandValue()
        {
            return Hand.CalculateValue();
        }

        public bool HasBlackjack()
        {
            return Hand.HasBlackjack();
        }

        public bool HasBusted()
        {
            return Hand.HasBusted();
        }

        public void PlaceBet(int amount)
        {
            if (amount > Wallet)
            {
                throw new InvalidOperationException("Insufficient funds in wallet.");
            }

            CurrentBet += amount;
            Wallet -= amount;
        }

        public void AddToWallet(int amount)
        {
            Wallet += amount;
        }


        public void ClearBet(int amount)
        {
            CurrentBet = 0;
        }

        public void ResetBet()
        {
            Wallet += CurrentBet;
            CurrentBet = 0;
        }

        public Card Split()
        {
            // Remove one card from the player's hand and return it
            Card splitCard = Hand.RemoveCard(0);
            return splitCard;
        }

        public bool CanSplit()
        {
            // Check if the player's hand has two cards with the same rank
            return Hand.CheckSplit();
        }
    }
}
