using System;
using System.Collections.Generic;

namespace BlackJackGroup4
{
    public enum GameState
    {
        Betting,
        Playing,
        DealerTurn,
        GameOver
    }
    public enum Result
    {
        Win,
        Loss,
        Tie,
        StillPlaying,
    }

    public class Game
    {
        public Player player;
        public Dealer dealer;
        private Deck deck;
        private bool joker;

        public int Pot { get; private set; }

        public GameState CurrentState { get; set; }
        public Result result { get; set; }


        public Game(Player player, Dealer dealer, Deck deck, int initialPot)
        {
            this.player = player;
            this.dealer = dealer;
            this.deck = deck;

            Pot = initialPot;
            CurrentState = GameState.Betting;
            result = Result.StillPlaying;

        }
        public Game(Player player, Dealer dealer, Deck deck, bool joker)
        {
            this.joker = joker;
            this.player = player;
            Console.WriteLine(player.ToString());
            this.dealer = dealer;
            this.deck = deck;

            Pot = 0;
            CurrentState = GameState.Betting;
            result = Result.StillPlaying;
        }
        /** NOTE*/
        public void NewGame()
        {
            deck.Reset(joker);
            Pot = 0;
            CurrentState = GameState.Betting;
            result = Result.StillPlaying;
            player.ClearHand();
            dealer.ClearHand();
            player.ClearBet(Pot);
        }

        public void DoubleDown()
        {
            player.PlaceBet(player.CurrentBet); // Double the current bet
            Pot += player.CurrentBet;
        }

        public void PlaceBet(int amount)
        {
            player.PlaceBet(amount);
            Pot += amount;
        }

        public void ResetBet()
        {
            player.ResetBet();
        }


        public List<Card> StartNewGame()
        {
            player.ClearHand();
            dealer.ClearHand();
            deck.Reset(joker);
            deck.Shuffle();

            List<Card> initialCards = DealInitialCards();
            return initialCards;
        }


        private List<Card> DealInitialCards()
        {
            List<Card> initialCards = new List<Card>();

            initialCards.Add(deck.Deal());
            initialCards.Add(deck.Deal());
            initialCards.Add(deck.Deal());
            initialCards.Add(deck.Deal());

            foreach (Card card in initialCards)
            {
                if (initialCards.IndexOf(card) % 2 == 0)
                {
                    dealer.AddCardToHand(card);
                }
                else
                {
                    player.AddCardToHand(card);
                }
            }

            CurrentState = GameState.Playing;

            return initialCards;
        }

        public Card PlayerHit()
        {
            Card drawnCard = deck.Deal();
            player.AddCardToHand(drawnCard);


            if (player.HasBusted() || player.HasBlackjack()) // Either conditions end the game.
            {
                CurrentState = GameState.GameOver;
                if (player.HasBusted())
                {
                    result = Result.Loss;
                }
                else
                {
                    result = Result.Win;
                }
            }
            return drawnCard;
        }


        public void PlayerStand()
        {
            CurrentState = GameState.DealerTurn;

            dealer.PlayTurn(deck);
            DetermineWinner();
            CurrentState = GameState.GameOver;
            
        }

        public void EndGame()
        {
            //object winner = DetermineWinner();
            if (result == Result.Win)
            {
                player.AddToWallet(Pot * 2);
            }
            else if (result == Result.Loss)
            {
            }
            else
            {
                player.AddToWallet(Pot);
            }

            Pot = 0;
            CurrentState = GameState.GameOver;
        }

        public void DetermineWinner()
        {
            if (player.HasBusted() || ((dealer.GetHandValue() > player.GetHandValue()) && dealer.GetHandValue() <= 21))
            {
                result = Result.Loss;
                
            }
            else if (dealer.HasBusted() || (player.GetHandValue() > dealer.GetHandValue()))
            {
                result = Result.Win;
                
            }
            else
            {
                result = Result.Tie;
            }
        }

        public void Split()
        {
            if (player.Hand.CheckSplit())
            {
                Card splitCard = player.Hand.RemoveCard(1); // Remove the second card
                player.ResetBet();
                player.PlaceBet(Pot); // Place the same bet again for the split hand
                player.Hand.AddCard(splitCard); // Add the removed card to the split hand
                player.Hand.Display(); // Display the split hand for debugging
            }
            else
            {
                Console.WriteLine("You cannot split this hand.");
            }
        }
        public string GetPlayerHandValue()
        {
            return player.GetHandValue().ToString();
        }
        public string GetDealerHandValue()
        {
            if (CurrentState == GameState.Playing)
            {
                return dealer.Hand.FirstCardValue().ToString();
            }
            else
            {
                return dealer.GetHandValue().ToString();
            }
        }
    }
}
