using BlackJack_Console;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BlackJackGroup4
{
    public partial class frmSinglePlayer : Form
    {
        private BlackJackWelcome mainMenu;
        private Theme theme;
        private Game game;
        private List<Card> drawnCards;
        private Dictionary<Button, Size> originalButtonSizes = new Dictionary<Button, Size>();
        private Dictionary<Button, Point> originalButtonLocations = new Dictionary<Button, Point>();
        private PictureBox hiddenPictureBox;
        private int playerCardX = 0;


        public PlayerManager playerManager;

        // Constructor to receive the theme instance
        public frmSinglePlayer(BlackJackWelcome mainMenuForm, Image backgroundImage, string musicPath, bool joker)
        {
            InitializeComponent();
            this.theme = new Theme(this, backgroundImage, musicPath);
            InitializeButtons();
            panelPlayerCards.Parent = pbGameTable;
            btnDoubleDown.Parent = pbGameTable;
            panelPlayerCards.Location = new Point(190, 240);
            panelDealerCards.Parent = pbGameTable;
            panelDealerCards.Location = new Point(190, 40);
            mainMenu = mainMenuForm;


            //Login login = new Login();
            //login.Show();
            // TODO: Have Login return a Username.
            PlayerManager playerManager = new PlayerManager();
            string username = "Jeff";
            Player player = playerManager.GetOrMakePlayer(username);
            
            Dealer dealer = new Dealer();
            Deck deck = new Deck(joker);
            game = new Game(player, dealer, deck, joker);
            drawnCards = new List<Card>();
            //initialPot = game.player.CurrentBet;
            lblDealerHandValue.Visible = false;
            lblHandValue.Visible = false;
            btnDoubleDown.Visible = false;
            Update_UI();
        }

        private void SinglePlayer_Load(object sender, EventArgs e)
        {

        }

        /***********************************************
         * BUTTONS
        ***********************************************/
        // GAME SETUP BUTTONS //

        // DEAL
        private void btnDeal_Click(object sender, EventArgs e)
        {
            List<Card> initialCards = game.StartNewGame(); // Start a new game and get the initial cards
            drawnCards.AddRange(initialCards); // Add the drawn cards to the list
            DisplayInitialDeal();
            btnDeal.Enabled = false;
            btnHit.Enabled = true;
            btnStand.Enabled = true;
            game.CurrentState = GameState.Playing;
            btnDoubleDown.Visible = true;
            Update_UI();
        }
        // RESET
        private void btnReset_Click(object sender, EventArgs e)
        {
            game.ResetBet();
            Update_UI();
        }

        // MAINMENU
        private void Button_Click(object sender, EventArgs e)
        {
            this.Close();
            if (mainMenu != null)
            {
                mainMenu.Show();
            }
        }

        // BETTING BUTTONS //
        private void btnOneDollar_Click(object sender, EventArgs e)
        {
            try
            {
                game.PlaceBet(1);
                Update_UI();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnFiveDollars_Click(object sender, EventArgs e)
        {
            try
            {
                game.PlaceBet(5);
                Update_UI();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnTwentyDollars_Click(object sender, EventArgs e)
        {
            try
            {
                game.PlaceBet(20);
                Update_UI();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnFiftyDollars_Click(object sender, EventArgs e)
        {
            try
            {
                game.PlaceBet(50);
                Update_UI();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // GAME BUTTONS //

        // HIT
        private void btnHit_Click(object sender, EventArgs e)
        {
            Card drawnCard = game.PlayerHit();
            DisplayPlayerDeal();
            btnDoubleDown.Visible = false;
            Update_UI();
        }

        // STAND
        private void btnStand_Click(object sender, EventArgs e)
        {
            ClearHiddenCard();
            game.PlayerStand();
            btnDoubleDown.Visible = false;
            Update_UI();
        }

        // DOUBLE DOWN
        private void btnDoubleDown_Click(object sender, EventArgs e)
        {
            game.DoubleDown();
            btnDoubleDown.Visible = false;
            Update_UI();
        }

        public void DisableBetButtons()
        {
            foreach (Control control in panelBet.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = false;
                }
            }
        }
        /****************************************************
         * UI LOGIC
         ***************************************************/

        // Updates the UI, run after every button press.
        private void Update_UI()
        {
            //btnDoubleDown.Visible = false;
            btnSplit.Visible = false;

            if (game.CurrentState == GameState.Betting)
            {
                foreach (Control control in panelBet.Controls)
                {
                    if (control is Button button)
                    {
                        button.Enabled = true;
                    }
                }
            }
            else if (game.CurrentState == GameState.Playing)
            {
                DisableBetButtons();
                lblDealerHandValue.Text = game.GetDealerHandValue();
                lblHandValue.Text = game.GetPlayerHandValue();
                lblHandValue.Visible = true;
                lblDealerHandValue.Visible = true;
            }
            else if (game.CurrentState == GameState.DealerTurn)
            {
                DisableBetButtons();
                // Update UI for dealer's turn
                lblDealerHandValue.Text = game.GetDealerHandValue();
                lblHandValue.Text = game.GetPlayerHandValue();
                DisplayDealerHand();

            }
            else if (game.CurrentState == GameState.GameOver)
            {
                // Update UI for game over state
                lblDealerHandValue.Text = game.GetDealerHandValue();
                lblHandValue.Text = game.GetPlayerHandValue();
                if(game.dealer.Hand.GetNumberOfCards() > 2)
                {
                    DisplayDealerHand();
                }
                else
                {
                    ClearHiddenCard();
                }

                if (game.result == Result.Win)
                {
                    MessageBox.Show("Player wins! This round...", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (game.result == Result.Loss)
                {
                    MessageBox.Show("Dealer wins! Muhahaha", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("It's a draw! Ah man this wamps", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DisplayDealerHand();
                game.EndGame();
                ClearCards();
                game.NewGame();
                lblDealerHandValue.Visible = false;
                lblHandValue.Visible = false;
                playerCardX = 0;
                drawnCards.Clear();
                NewGameUI();
            }

            if (game.player.CurrentBet > 0)
            {
                btnDeal.Enabled = true;
            }
            lblPlayerWallet.Text = $"Your Balance: ${game.player.Wallet}.00";
            lblBet.Text = $"Bet: ${game.player.CurrentBet}.00";

        }

        private void NewGameUI()
        {
            btnDeal.Enabled = false;
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            foreach (Control control in panelBet.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                }
            }
        }

        private void InitializeButton(Button button)
        {
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.BackColor = Color.FromArgb(115, Color.WhiteSmoke);

        }
        private void InitializeButtons()
        {
            btnHit.Parent = pbGameTable;
            panelBet.Parent = pbGameTable;
            lblBet.BackColor = Color.FromArgb(115, Color.WhiteSmoke);
            lblPlayerWallet.BackColor = Color.FromArgb(115, Color.WhiteSmoke);
            foreach (Control control in panelBet.Controls)
            {
                if (control is Button button)
                {
                    InitializeButton(button);
                }
            }
            InitializeButton(btnHit);
            InitializeButton(btnStand);
            InitializeButton(btnDeal);
            InitializeButton(btnDoubleDown);
            InitializeButton(btnSplit);
            panelBet.Location = new Point(0, 70);
            btnHit.Location = new Point(480, 35);
            btnStand.Location = new Point(570,74);
            btnDeal.Location = new Point(482, 13);
            btnDoubleDown.Location = new Point(568, 90);
            btnSplit.Location = new Point(480, 130);
        }

        

        // Event handler for mouse entering the button

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Store the original size and location of the button if not already stored
            if (!originalButtonSizes.ContainsKey(button))
            {
                originalButtonSizes.Add(button, button.Size);
                originalButtonLocations.Add(button, button.Location);
            }

            // Calculate the increased size as a percentage of the original size
            float zoomFactor = 1.1f; // 10% increase
            Size newSize = new Size((int)(originalButtonSizes[button].Width * zoomFactor), (int)(originalButtonSizes[button].Height * zoomFactor));

            // Adjust the size of the button to create a zoom effect
            button.BackColor = Color.FromArgb(170, Color.LightYellow);
            button.Size = newSize;
            // Adjust the location to keep the button centered
            button.Location = new Point(originalButtonLocations[button].X - (newSize.Width - originalButtonSizes[button].Width) / 2,
                                        originalButtonLocations[button].Y - (newSize.Height - originalButtonSizes[button].Height) / 2);
        }

        // Event handler for mouse leaving the button
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            // Restore the original size and location of the button
            button.BackColor = Color.FromArgb(128, Color.WhiteSmoke);
            button.Size = originalButtonSizes[button];
            button.Location = originalButtonLocations[button];
        }

        private void ClearHiddenCard()
        {
            if (hiddenPictureBox != null)
            {
                panelDealerCards.Controls.Remove(hiddenPictureBox);
                hiddenPictureBox.Dispose(); // Dispose the picture box to release resources
                hiddenPictureBox = null; // Set the reference to null
            }
        }
       
        private void DisplayInitialDeal()
        {
            int count = 0;
            int dealerX = 0; // Initial X position for dealer cards

            foreach (Card card in drawnCards)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = card.Image;
                pictureBox.Width = 70; // Set the width
                pictureBox.Height = 100; // Set the height

                if (drawnCards.IndexOf(card) % 2 == 0) // If the index is even, it's for the dealer
                {
                    if (count > 0) // If it's not the first dealer card, add the hidden card first
                    {
                        Image hiddenCardImage = (Image)Properties.Resources.ResourceManager.GetObject(gameSettings.GetCardFace());
                        hiddenPictureBox = new PictureBox(); // Store the reference to the hidden picture box
                        hiddenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        hiddenPictureBox.Image = hiddenCardImage;
                        hiddenPictureBox.Width = 70; // Set the width
                        hiddenPictureBox.Height = 100; // Set the height
                        hiddenPictureBox.Location = new Point(dealerX, 0); // Set the location for the hidden card
                        panelDealerCards.Controls.Add(hiddenPictureBox);
                    }

                    pictureBox.Location = new Point(dealerX, 0); // Set the location for dealer cards
                    panelDealerCards.Controls.Add(pictureBox); // Add to dealer's panel

                    dealerX += 85; // Increment X position for the next dealer card
                    count++;
                }
                else // If the index is odd, it's for the player
                {
                    pictureBox.Location = new Point(playerCardX, 0); // Set the location for player cards
                    panelPlayerCards.Controls.Add(pictureBox); // Add to player's panel
                    playerCardX += 85; // Increment X position for the next player card
                }
            }
        }

        private void DisplayPlayerDeal()
        {
            // Clear all images currently in the panel
            panelPlayerCards.Controls.Clear();

            // Reset playerCardX for proper spacing
            playerCardX = 0;

            // Calculate spacing dynamically based on the number of cards
            int numCards = game.player.Hand.GetNumberOfCards();
            int totalWidthNeeded = numCards * 70; // Width of each PictureBox
            int totalSpacing = panelPlayerCards.Width - totalWidthNeeded;
            
            int spacing = totalSpacing / (numCards - 1);

            // Redraw the images with adjusted spacing
            foreach (Card card in game.player.Hand) // Accessing the Hand property of the Player class
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = card.Image;
                pictureBox.Width = 70; // Set the width
                pictureBox.Height = 100; // Set the height
                pictureBox.Location = new Point(playerCardX, 0); // Set the location for player cards
                panelPlayerCards.Controls.Add(pictureBox); // Add to player's panel
                playerCardX += 70 + spacing; // Adjust spacing
            }
        }


        private void DisplayDealerHand()
        {
            panelDealerCards.Controls.Clear();

            int dealerCardX = 0;

            int numCards = game.dealer.Hand.GetNumberOfCards();
            int totalWidthNeeded = numCards * 70;
            int totalSpacing = panelDealerCards.Width - totalWidthNeeded;
            int spacing = totalSpacing / (numCards - 1);
            foreach(Card card in game.dealer.Hand)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = card.Image;
                pictureBox.Width = 70; // Set the width
                pictureBox.Height = 100; // Set the height
                pictureBox.Location = new Point(dealerCardX, 0);
                panelDealerCards.Controls.Add(pictureBox);
                dealerCardX +=70 + spacing;
            }

        }

        private void ClearCards()
        {
            panelPlayerCards.Controls.Clear();
            panelDealerCards.Controls.Clear();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
