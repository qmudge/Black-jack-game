/* Filename: Game functioning.
 * Author: Quintin Mudge.
 * Created: 22/09/2017.
 * Operating system: Windows.
 * Version: Windows 10.
 * Description: Contains all the variables and methods that will deal out cards,
 * Calculate who wins the round and keep track of scores.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Game
{
    /* Contains all the game control structures and methods that will proccess a game
     * of blackjack.
    */
    public partial class NewGame : Form
    {
        //Players hand value.
        int playerDealHand;
        //Stores the randomed cards score value.
        int cardValue;
        //dealers hand value.
        int dealersHandScore;
        //Stores the type and value of a randomed card.
        private int cardVal;
        //Keeps count of the number of cards dealt to player/dealer.
        int hitCount;
        int dealerHitCount;
        //Keeps count of wins/ties and losses.
        int winsCount;
        int tiesCount;
        int lossesCount;
        //List of names of cards that were dealt in the current hand.
        List<string> myCollection;


        public NewGame()
        {
            InitializeComponent();
            //Sets controls to be disabled.
            hitButton.Enabled = false;
            stayButton.Enabled = false;
            //Cards not yet dealt are hidden.
            cardsOne.Visible = false;
            cardsTwo.Visible = false;
            cardsThree.Visible = false;
            cardsFour.Visible = false;
            cardsFive.Visible = false;
            cardsSix.Visible = false;
            cardsSeven.Visible = false;
            cardDealer.Visible = false;
            cardDealerTwo.Visible = false;
            cardDealerThree.Visible = false;
            cardDealerFour.Visible = false;
            cardDealerFive.Visible = false;
            cardDealerSix.Visible = false;
            cardDealerSeven.Visible = false;
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 22/09/2017.
         * Description: Action event listener for form closing. Exits the program.
        */
        private void GameExiting(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 21/09/2017.
         * Description: Action event listener for clicking the quit button. Exits the application
         * and terminates the form.
        */
        private void QuitGame(object sender, EventArgs e)
        {
            this.Hide();
            startScreen newMenu = new startScreen();
            newMenu.Closed += (s, args) => this.Close();
            newMenu.Show();

        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 21/09/2017.
         * Description: Action event listener for clicking the deal button. Starts a new
         * round by dealing two cards to the player and dealer. Resets floating scores
         * and variables used to contain current hand values.
        */
        private void DealCards(object sender, EventArgs e)
        {
            //Disables deal button after being pressed.
            dealButton.Enabled = false;
            //enables hit and stay buttons.
            hitButton.Enabled = true;
            stayButton.Enabled = true;
            //Resets the displayed text for player/dealer scores and outcome of the round.
            resultLbl.Text = "";
            scoreLbl.Text = "";
            dealerScoreLbl.Text = "";
            //Resets the card count and randomed card back to 0.
            hitCount = 0;
            dealerHitCount = 0;
            cardValue = 0;
            //Players/dealers hand total reset.
            playerDealHand = 0;
            dealersHandScore = 0;
            //Resets card list names.
            myCollection = null;
            //Resets card images.
            cardsOne.Visible = false;
            cardsTwo.Visible = false;
            cardsThree.Visible = false;
            cardsFour.Visible = false;
            cardsFive.Visible = false;
            cardsSix.Visible = false;
            cardsSeven.Visible = false;
            cardDealer.Visible = false;
            cardDealerTwo.Visible = false;
            cardDealerThree.Visible = false;
            cardDealerFour.Visible = false;
            cardDealerFive.Visible = false;
            cardDealerSix.Visible = false;
            cardDealerSeven.Visible = false;

            //first card dealt to player.
            DealCardsPlayer();
            //Second card dealt to player.
            DealCardsPlayerTwo();
            //First card dealt to dealer plus facedown card.
            DealCardDealer();

            //Checks players hand for a blackjack.
            if (playerDealHand == 21)
            {
                //Starts the dealers turn.
                DealersTurn();
            }
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 22/09/2017.
         * Description: Deals the first card to the player randomly.
        */
        private void DealCardsPlayer()
        {
            //New list that will contain all the names of the cards dealt in the current round.
            myCollection = new List<string>();

            //New random card.
            string imgName = ListCardCheck();

            //Display the card in the card1 image box.
            cardsOne.Image = Image.FromFile(imgName);
            cardsOne.Show();

            //Checks if the card is an ace and gives it a value of 11.
            if (cardValue == 0)
            {
                cardValue = 11;
            }

            //Update score.
            PlayerScore();
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 24/09/2017.
         * Description: Display and store players score.
        */
        private void PlayerScore()
        {
            //Update the players hand total.           
            playerDealHand = playerDealHand + cardValue;
            //Display the total score so far for player.
            scoreLbl.Text = playerDealHand.ToString();
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 22/09/2017.
         * Description: Deals the Second card to the player randomly.
        */
        private void DealCardsPlayerTwo()
        {
            //New random card.
            string imgName = ListCardCheck();

            //Display the card in the card2 image box.
            cardsTwo.Image = Image.FromFile(imgName);
            cardsTwo.Show();
            //If card is an ace check what the value should be.
            AceValue();
            //Update score.
            PlayerScore();
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 24/09/2017.
         * Description: Generate a random new card. Checks that the card has not already 
         * been dealt. Adds the card name to the list to prohibit duplicates.
         * Return value: String imgName.
        */
        private string ListCardCheck()
        {
            //Delay the dealing of the card by 1/2 sec.
            System.Threading.Thread.Sleep(500);

            //Gets a random card with its value.
            string imgName = CardMethod(RandomNumber(), out cardVal);

            //Checks the list to see if it contains the cards name. Gets a new card
            //if the card has already been dealt.
            while (myCollection.Contains(imgName))
            {
                imgName = CardMethod(RandomNumber(), out cardVal);
            }

            //store card value.
            cardValue = cardVal;
            //Adds the cards name to the list.
            myCollection.Add(imgName);

            return imgName;
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 23/09/2017.
         * Description: Decides wheather the ace card should have the value of 11 or 1
         * depending on the current hand total of the player.
        */
        private void AceValue()
        {
            //Hand total is equal or less than 10. Ace is 11.
            if (cardValue == 0 && playerDealHand <= 10)
            {
                cardValue = 11;
            }
            //Hand total is greater than 10. Ace is 1.
            else if (cardValue == 0 && playerDealHand > 10)
            {
                cardValue = 1;
            }
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 23/09/2017.
         * Description: Decides wheather the ace card should have the value of 11 or 1
         * depending on the current hand total of the dealer.
        */
        private void AceValueDealer()
        {
            //Hand total is equal or less than 10. Ace is 11.
            if (cardValue == 0 && dealersHandScore <= 10)
            {
                cardValue = 11;
            }
            //Hand total is greater than 10. Ace is 1.
            else if (cardValue == 0 && dealersHandScore > 10)
            {
                cardValue = 1;
            }
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 23/09/2017.
         * Description: Deals the first card and the facedown card to the dealer randomly.
        */
        private void DealCardDealer()
        {
            //New random card.
            string imgName = ListCardCheck();

            //Display the card in the dealers card1 image box.
            cardDealer.Image = Image.FromFile(imgName);
            cardDealer.Show();

            //Checks if the card is an ace and gives it a value of 11.
            if (cardValue == 0)
            {
                cardValue = 11;
            }

            //Update and display dealers score.
            DealerScore();

            //Upside down card. 
            cardDealerTwo.Image = Image.FromFile("cardbackred.JPG");
            cardDealerTwo.Show();
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 24/09/2017.
         * Description: Display and store dealers score.
        */
        private void DealerScore()
        {
            //Displays the dealers hand total.
            dealerScoreLbl.Text = cardValue.ToString();
            //Stores the dealers hand total.
            dealersHandScore = dealersHandScore + cardValue;
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 23/09/2017.
         * Description: Event listener for clicking the hit button. Will keep
         * producing a new card upon every click until players hand exceeds 21.
        */
        private void HitButtonClick(object sender, EventArgs e)
        {
            //Checks the total amount of times the hit button has been pressed this round.
            if (hitCount == 0)
            {
                //New random card.
                string imgName = ListCardCheck();
                //Display the card in the players card3 image box.
                cardsThree.Image = Image.FromFile(imgName);
                cardsThree.Show();
                //Check if card is an ace.
                AceValue();
                //Update score.
                PlayerScore();
                hitCount++;
            }
            else if (hitCount == 1)
            {
                //New random card.
                string imgName = ListCardCheck();
                //Display the card in the players card4 image box.
                cardsFour.Image = Image.FromFile(imgName);
                cardsFour.Show();
                //Check if card is an ace.
                AceValue();
                //Update score.
                PlayerScore();
                hitCount++;
            }
            else if (hitCount == 2)
            {
                //New random card.
                string imgName = ListCardCheck();
                //Display the card in the players card5 image box.
                cardsFive.Image = Image.FromFile(imgName);
                cardsFive.Show();
                //Check if card is an ace.
                AceValue();
                //Update score.
                PlayerScore();
                hitCount++;
            }
            else if (hitCount == 3)
            {
                //New random card.
                string imgName = ListCardCheck();
                //Display the card in the players card6 image box.
                cardsSix.Image = Image.FromFile(imgName);
                cardsSix.Show();
                //Check if card is an ace.
                AceValue();
                //Update score.
                PlayerScore();
                hitCount++;
            }
            else if (hitCount == 4)
            {
                //New random card.
                string imgName = ListCardCheck();
                //Display the card in the players card7 image box.
                cardsSeven.Image = Image.FromFile(imgName);
                cardsSeven.Show();
                //Check if card is an ace
                AceValue();
                //Update score.
                PlayerScore();
                hitCount++;
            }
            //hide the deal button until game is over.
            dealButton.Enabled = false;

            //Bust condition.
            if (playerDealHand >= 21)
            {
                //Dealers turn to play
                DealersTurn();
            }
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 24/09/2017.
         * Description: Dealer will receive cards and stop when their total hand value
         * is above 17.
        */
        private void DealersTurn()
        {
            //Hide buttons until end of turn.
            hitButton.Enabled = false;
            stayButton.Enabled = false;

            //Tests the amount of cards the dealer has received.
            if (dealerHitCount == 0)
            {
                //New random card.
                string imgName = ListCardCheck();
                //Display the card in the dealers card2 image box.
                cardDealerTwo.Image = Image.FromFile(imgName);
                cardDealerTwo.Show();
                //Check if card is an ace
                AceValueDealer();
                //Update and display dealers score.
                DealerScore();
                //Count extra cards.
                dealerHitCount++;
            }

            //Check if dealer is not blackjack or busted.
            if (dealersHandScore < 21)
            {
                //Keep receiving cards until score equals or exceeds 17.
                while (dealersHandScore < 17)
                {
                    //Checks the total amount of cards received by the dealer this round.
                    if (dealerHitCount == 1)
                    {
                        //New random card.
                        string imgName = ListCardCheck();
                        //Display the card in the dealers card3 image box.
                        cardDealerThree.Image = Image.FromFile(imgName);
                        cardDealerThree.Show();
                        //Check if card is an ace.
                        AceValueDealer();
                        //Update and display dealers score.
                        DealerScore();
                        //Count extra cards.
                        dealerHitCount++;
                    }
                    else if (dealerHitCount == 2)
                    {
                        //New random card.
                        string imgName = ListCardCheck();
                        cardDealerFour.Image = Image.FromFile(imgName);
                        //Display the card in the dealers card4 image box.
                        cardDealerFour.Show();
                        //Check if card is an ace.
                        AceValueDealer();
                        //Update and display dealers score.
                        DealerScore();
                        //Count extra cards.
                        dealerHitCount++;
                    }
                    else if (dealerHitCount == 3)
                    {
                        //New random card.
                        string imgName = ListCardCheck();
                        //Display the card in the dealers card5 image box.
                        cardDealerFive.Image = Image.FromFile(imgName);
                        cardDealerFive.Show();
                        //Check if card is an ace.
                        AceValueDealer();
                        //Update and display dealers score.
                        DealerScore();
                        //Count extra cards.
                        dealerHitCount++;
                    }
                    else if (dealerHitCount == 4)
                    {
                        //New random card.
                        string imgName = ListCardCheck();
                        cardDealerSix.Image = Image.FromFile(imgName);
                        //Display the card in the dealers card6 image box.
                        cardDealerSix.Show();
                        //Check if card is an ace.
                        AceValueDealer();
                        //Update and display dealers score.
                        DealerScore();
                        //Count extra cards.
                        dealerHitCount++;
                    }
                    else if (dealerHitCount == 5)
                    {
                        //New random card.
                        string imgName = ListCardCheck();
                        //Display the card in the dealers card7 image box.
                        cardDealerSeven.Image = Image.FromFile(imgName);
                        cardDealerSeven.Show();
                        //Check if card is an ace.
                        AceValueDealer();
                        //Update and display dealers score.
                        DealerScore();
                        //Count extra cards.
                        dealerHitCount++;
                    }
                }

                //Checks that dealer is not bust.
                if (dealersHandScore < 21)
                {
                    //Checks if player is bust or dealer has a higher total.
                    if (dealersHandScore > playerDealHand || playerDealHand > 21)
                    {
                        //Player bust.
                        if (playerDealHand > 21)
                        {
                            //Display result.
                            resultLbl.Text = "Bust, You lose";
                            //Adds plus one to losses.
                            ++lossesCount;
                            //Displays losses.
                            losses.Text = lossesCount.ToString();
                        }
                        //Dealer has a higher total.
                        else if (dealersHandScore > playerDealHand)
                        {
                            //Display result.
                            resultLbl.Text = "You lose";
                            //Adds plus one to losses.
                            ++lossesCount;
                            //Displays losses.
                            losses.Text = lossesCount.ToString();
                        }
                    }
                    //Player has a higher total.
                    else if (dealersHandScore < playerDealHand)
                    {
                        //Displays result.
                        resultLbl.Text = "You win";
                        //Adds plus one to wins.
                        ++winsCount;
                        //Displays wins.
                        wins.Text = winsCount.ToString();
                    }
                    //Hands are equal.
                    else if (dealersHandScore == playerDealHand)
                    {
                        //Displays result.
                        resultLbl.Text = "Game tied";
                        //Adds plus one to ties.
                        ++tiesCount;
                        //Displays ties.
                        ties.Text = tiesCount.ToString();
                    }
                }
            }

            //Dealer has blackjack.
            if (dealersHandScore == 21)
            {
                //Checks if player is bust or dealer has a higher total.
                if (dealersHandScore > playerDealHand || playerDealHand > 21)
                {
                    //Player bust.
                    if (playerDealHand > 21)
                    {
                        //Displays result.
                        resultLbl.Text = "Bust, You lose";
                        //Adds plus one to losses.
                        ++lossesCount;
                        //Displays losses.
                        losses.Text = lossesCount.ToString();
                    }
                    //Dealer has higher total.
                    else if (dealersHandScore > playerDealHand)
                    {
                        //Displays result.
                        resultLbl.Text = "You lose";
                        //Adds plus one to losses.
                        ++lossesCount;
                        //Displays losses.
                        losses.Text = lossesCount.ToString();
                    }
                }
                //hands are equal.
                else if (dealersHandScore == playerDealHand)
                {
                    //Displays result.
                    resultLbl.Text = "Game tied";
                    //Adds plus one to ties.
                    ++tiesCount;
                    //Displays ties.
                    ties.Text = tiesCount.ToString();
                }
            }
            //Dealer bust.
            else if (dealersHandScore > 21)
            {
                //Player bust
                if (playerDealHand > 21)
                {
                    //Displays result.
                    resultLbl.Text = "Bust, You lose.";
                    //Adds plus one to losses.
                    ++lossesCount;
                    //Displays losses.
                    losses.Text = lossesCount.ToString();
                }
                //Dealer bust.
                else
                {
                    //Displays result.
                    resultLbl.Text = "Dealer bust\nYou win";
                    //Adds plus one to wins.
                    ++winsCount;
                    //Displays wins.
                    wins.Text = winsCount.ToString();
                }
            }
            //Enable deal button to play next round.
            dealButton.Enabled = true;
            //Display dealer score.
            dealerScoreLbl.Text = dealersHandScore.ToString();
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 25/09/2017.
         * Description: Event listener for stay button click.
        */
        private void StayButton(object sender, EventArgs e)
        {
            //Begins the dealers turn.
            DealersTurn();
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 25/09/2017.
         * Description: Generate a random number between 0 and 51.
         * Return value: int random.
        */
        private int RandomNumber()
        {
            //New random
            Random rnd = new Random();
            //Number Between 0 and 51.
            int random = rnd.Next(52);
            //return number.
            return random;
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 25/09/2017.
         * Description: Matches the random number with a card name and value.
        */
        static string CardMethod(int card, out int cardVal)
        {
            //Reset card value.
            int cardValue = 0;
            //Reset card name.
            string imgName = null;
            //Reset card.
            cardVal = 0;

            //Match the number to a case that contains the card information. Breaks out once
            //a match has been found.
            switch (card)
            {
                //52 cards with unique case.
                case 0:
                    {
                        //Value of this card.
                        cardValue = 10;
                        //Name of card.
                        imgName = "kingClubs.JPG";
                        //Go to end
                        break;
                    }
                case 1:
                    {
                        cardValue = 10;
                        imgName = "kingSpades.JPG";
                        break;
                    }
                case 2:
                    {
                        cardValue = 10;
                        imgName = "kingDiamonds.JPG";
                        break;
                    }
                case 3:
                    {
                        cardValue = 10;
                        imgName = "kingHearts.JPG";
                        break;
                    }
                case 4:
                    {
                        cardValue = 10;
                        imgName = "queenClubs.JPG";
                        break;
                    }
                case 5:
                    {
                        cardValue = 10;
                        imgName = "queenHearts.JPG";
                        break;
                    }
                case 6:
                    {
                        cardValue = 10;
                        imgName = "QueenSpades.JPG";
                        break;
                    }
                case 7:
                    {
                        cardValue = 10;
                        imgName = "QueenDiamonds.JPG";
                        break;
                    }
                case 8:
                    {
                        cardValue = 10;
                        imgName = "jackClubs.JPG";
                        break;
                    }
                case 9:
                    {
                        cardValue = 10;
                        imgName = "jackSpades.JPG";
                        break;
                    }
                case 10:
                    {
                        cardValue = 10;
                        imgName = "jackHearts.JPG";
                        break;
                    }
                case 11:
                    {
                        cardValue = 10;
                        imgName = "jackDiamonds.JPG";
                        break;
                    }
                case 12:
                    {
                        cardValue = 10;
                        imgName = "tenClubs.JPG";
                        break;
                    }
                case 13:
                    {
                        cardValue = 10;
                        imgName = "tenSpades.JPG";
                        break;
                    }
                case 14:
                    {
                        cardValue = 10;
                        imgName = "tenHearts.JPG";
                        break;
                    }
                case 15:
                    {
                        cardValue = 10;
                        imgName = "tenDiamonds.JPG";
                        break;
                    }
                case 16:
                    {
                        cardValue = 9;
                        imgName = "nineClubs.JPG";
                        break;
                    }
                case 17:
                    {
                        cardValue = 9;
                        imgName = "nineHearts.JPG";
                        break;
                    }
                case 18:
                    {
                        cardValue = 9;
                        imgName = "nineSpades.JPG";
                        break;
                    }
                case 19:
                    {
                        cardValue = 9;
                        imgName = "nineDiamonds.JPG";
                        break;
                    }
                case 20:
                    {
                        cardValue = 8;
                        imgName = "eightClubs.JPG";
                        break;
                    }
                case 21:
                    {
                        cardValue = 8;
                        imgName = "eightSpades.JPG";
                        break;
                    }
                case 22:
                    {
                        cardValue = 8;
                        imgName = "eightHearts.JPG";
                        break;
                    }
                case 23:
                    {
                        cardValue = 8;
                        imgName = "eightDiamonds.JPG";
                        break;
                    }
                case 24:
                    {
                        cardValue = 7;
                        imgName = "sevenClubs.JPG";
                        break;
                    }
                case 25:
                    {
                        cardValue = 7;
                        imgName = "sevenDiamonds.JPG";
                        break;
                    }
                case 26:
                    {
                        cardValue = 7;
                        imgName = "sevenHearts.JPG";
                        break;
                    }
                case 27:
                    {
                        cardValue = 7;
                        imgName = "sevenSpades.JPG";
                        break;
                    }
                case 28:
                    {
                        cardValue = 6;
                        imgName = "sixClubs.JPG";
                        break;
                    }
                case 29:
                    {
                        cardValue = 6;
                        imgName = "sixSpades.JPG";
                        break;
                    }
                case 30:
                    {
                        cardValue = 6;
                        imgName = "sixDiamonds.JPG";
                        break;
                    }
                case 31:
                    {
                        cardValue = 6;
                        imgName = "sixHearts.JPG";
                        break;
                    }
                case 32:
                    {
                        cardValue = 5;
                        imgName = "fiveClubs.JPG";
                        break;
                    }
                case 33:
                    {
                        cardValue = 5;
                        imgName = "fiveHearts.JPG";
                        break;
                    }
                case 34:
                    {
                        cardValue = 5;
                        imgName = "fiveSpades.JPG";
                        break;
                    }
                case 35:
                    {
                        cardValue = 5;
                        imgName = "fiveDiamonds.JPG";
                        break;
                    }
                case 36:
                    {
                        cardValue = 4;
                        imgName = "fourClubs.JPG";
                        break;
                    }
                case 37:
                    {
                        cardValue = 4;
                        imgName = "fourDiamonds.JPG";
                        break;
                    }
                case 38:
                    {
                        cardValue = 4;
                        imgName = "fourHearts.JPG";
                        break;
                    }
                case 39:
                    {
                        cardValue = 4;
                        imgName = "fourSpades.JPG";
                        break;
                    }
                case 40:
                    {
                        cardValue = 3;
                        imgName = "threeClubs.JPG";
                        break;
                    }
                case 41:
                    {
                        cardValue = 3;
                        imgName = "threeHearts.JPG";
                        break;
                    }
                case 42:
                    {
                        cardValue = 3;
                        imgName = "threeSpades.JPG";
                        break;
                    }
                case 43:
                    {
                        cardValue = 3;
                        imgName = "threeDiamonds.JPG";
                        break;
                    }
                case 44:
                    {
                        cardValue = 2;
                        imgName = "twoClubs.JPG";
                        break;
                    }
                case 45:
                    {
                        cardValue = 2;
                        imgName = "twoHearts.JPG";
                        break;
                    }
                case 46:
                    {
                        cardValue = 2;
                        imgName = "twoSpades.JPG";
                        break;
                    }
                case 47:
                    {
                        cardValue = 2;
                        imgName = "twoDiamonds.JPG";
                        break;
                    }
                case 48:
                    {
                        cardValue = 0;
                        imgName = "aceSpades.JPG";
                        break;
                    }
                case 49:
                    {
                        cardValue = 0;
                        imgName = "aceClubs.JPG";
                        break;
                    }
                case 50:
                    {
                        cardValue = 0;
                        imgName = "aceHearts.JPG";
                        break;
                    }
                case 51:
                    {
                        cardValue = 0;
                        imgName = "aceDiamonds.JPG";
                        break;
                    }
            }
            //Return card name and value.
            cardVal = cardValue;
            return imgName;
        }
    }
}
