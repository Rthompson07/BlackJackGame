using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BlackJack_Console;
using Newtonsoft.Json.Serialization;

namespace BlackJackGroup4
{
    public class MultiplayerController
    {
        public Player player1;
        public Player player2;
        public Dealer dealer;
        private Deck deck;
        public int Pot;
        public MultiGameState gameState;
        public MultiGameResult result;
        public int WhosTurn;
        public bool p1stand;
        public bool p2stand;
        public bool p1bust;
        public bool p2bust;


        public MultiplayerController(Player player1, Player player2, Deck deck)
        {
            this.player1 = player1;
            this.player2 = player2;
            Dealer dealer = new Dealer();
            this.deck = deck;
            int pot = 0;
            MultiGameResult result = MultiGameResult.StillPlaying;
            MultiGameState gameState = MultiGameState.BettingP1;
            WhosTurn = 1;
            p1stand = false;
            p2stand = false;
            p1bust = false;
            p2bust = false;
        }

        // Deal could do double duty as confirm bet button for player 1
        public void PlaceBet(int amount)
        {
            if(gameState == MultiGameState.BettingP1)
            {
                player1.PlaceBet(amount);
                gameState = MultiGameState.BettingP2;
            }
            else
            {
                player2.PlaceBet(amount);
                gameState = MultiGameState.PlayingP1;
            }
        }
        
        public void ResetBet()
        {
            if(gameState == MultiGameState.BettingP1)
            {
                player1.ResetBet();
            }
            else
            {
                player2.ResetBet();
            }
        }

        public void CollectWinnings(int amount)
        {
            if(result == MultiGameResult.P1Win)
            {
                player1.AddToWallet(amount);
            }
            else
            {
                player2.AddToWallet(amount);
            }
        }

        private List<Card> DealInitialCards()
        {
            List<Card> initialCards = new List<Card>();
            initialCards.Add(deck.Deal());
            initialCards.Add(deck.Deal());
            initialCards.Add(deck.Deal());
            initialCards.Add(deck.Deal());
            initialCards.Add(deck.Deal());
            initialCards.Add(deck.Deal());
            
            foreach (Card card in initialCards)
            {
                if(initialCards.IndexOf(card) == 0 || initialCards.IndexOf(card) == 1 )
                {
                    dealer.AddCardToHand(card);
                }else if(initialCards.IndexOf(card) == 2 || initialCards.IndexOf(card) == 3)
                {
                    player1.AddCardToHand(card);
                }
                else
                {
                    player2.AddCardToHand(card);
                }
            }
            gameState = MultiGameState.PlayingP1;
            return initialCards;
        }


        public List<Card> StartNewGame()
        {
            bool joker = true;
            player1.ClearHand();
            player2.ClearHand();
            deck.Reset(joker);
            deck.Shuffle();
            List<Card> initialCards = DealInitialCards();
            return initialCards;
        }

        public Card PlayerHit()
        {
            Card drawnCard = deck.Deal();


            if(gameState == MultiGameState.PlayingP1 )
            {
                player1.AddCardToHand(drawnCard);

                if (player1.HasBusted())
                {
                    p1bust = true;

                    if (!p2stand || !p2bust)
                    {
                        gameState = MultiGameState.PlayingP2;
                    }
                }



            }
            else
            {
                player2.AddCardToHand(drawnCard);
                if (player2.HasBusted())
                {
                    p2bust = true;

                    if(!p1stand || !p2bust)
                    {
                        gameState = MultiGameState.PlayingP1;
                    }

                }


            }


            if (p1bust && p2bust)
            {
                gameState = MultiGameState.Gameover;
            }
            // FORM will need to do a check before putting this in the right player's hand.
            return drawnCard;
        }


        public void PlayerStand()
        {
            if(gameState == MultiGameState.PlayingP1)
            {
                p1stand = true;

            }
            else
            {
                p2stand = true;
            }

            if(p1stand && p2stand)
            {
                gameState = MultiGameState.DealerTurn;
            }
        }


        public void DeterminWinner()
        {

            int p1v = player1.GetHandValue();
            if (p1bust)
            {
                p1v = 0;
            }
            int p2v = player2.GetHandValue();
            if (p2bust)
            {
                p2v = 0;
            }
            int dv = dealer.GetHandValue();
            if(dv > 21)
            {
                dv = 0;
            }

            if(p1v>p2v && p1v > dv)
            {
                result = MultiGameResult.P1Win;
            }else if (p2v>p1v && p2v>dv)
            {
                result= MultiGameResult.P2Win;
            }else if((p1v == p2v && p2v == dv) && dv != 0)
            {
                result = MultiGameResult.Tie;
            }
            else
            {
                result = MultiGameResult.DealerWin;
            }

        }



        public string GetPlayer1HandValue()
        {
            return player1.GetHandValue().ToString();
        }
        public string GetPlayer2HandValue()
        {
            return player2.GetHandValue().ToString();
        }


        public string GetDealerHandValue()
        {
            if (gameState != MultiGameState.DealerTurn || gameState != MultiGameState.Gameover)
            {
                return dealer.Hand.FirstCardValue().ToString();
            }
            else
            {
                return dealer.GetHandValue().ToString();
            }
        }




        public enum MultiGameState
        {
            BettingP1,
            BettingP2,
            PlayingP1,
            PlayingP2,
            DealerTurn,
            Gameover,
        }
        public enum MultiGameResult
        {
            P1Win,
            P2Win,
            DealerWin,
            Tie,
            StillPlaying,
        }
    }
}
