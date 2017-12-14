/* Filename: New game form components.
 * Author: Quintin Mudge.
 * Created: 21/09/2017.
 * Operating system: Windows.
 * Version: Windows 10.
 * Description: Creates all the components contained on the new game form.
*/

namespace Blackjack_Game
{
    partial class NewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.leaveGame = new System.Windows.Forms.Button();
            this.dealButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.stayButton = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.dealerScoreLbl = new System.Windows.Forms.Label();
            this.ties = new System.Windows.Forms.Label();
            this.wins = new System.Windows.Forms.Label();
            this.losses = new System.Windows.Forms.Label();
            this.chips = new System.Windows.Forms.PictureBox();
            this.cardDealerSeven = new System.Windows.Forms.PictureBox();
            this.cardDealerSix = new System.Windows.Forms.PictureBox();
            this.cardDealerFive = new System.Windows.Forms.PictureBox();
            this.cardDealerFour = new System.Windows.Forms.PictureBox();
            this.cardDealerThree = new System.Windows.Forms.PictureBox();
            this.cardsSeven = new System.Windows.Forms.PictureBox();
            this.cardsSix = new System.Windows.Forms.PictureBox();
            this.cardsFive = new System.Windows.Forms.PictureBox();
            this.cardsFour = new System.Windows.Forms.PictureBox();
            this.cardsThree = new System.Windows.Forms.PictureBox();
            this.cardDealerTwo = new System.Windows.Forms.PictureBox();
            this.cardDealer = new System.Windows.Forms.PictureBox();
            this.cardsTwo = new System.Windows.Forms.PictureBox();
            this.cardsOne = new System.Windows.Forms.PictureBox();
            this.headingLabel = new System.Windows.Forms.PictureBox();
            this.scoreBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealerSeven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealerSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealerFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealerFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealerThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsSeven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealerTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headingLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // leaveGame
            // 
            this.leaveGame.BackColor = System.Drawing.Color.DarkRed;
            this.leaveGame.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveGame.Location = new System.Drawing.Point(1194, 12);
            this.leaveGame.Name = "leaveGame";
            this.leaveGame.Size = new System.Drawing.Size(142, 60);
            this.leaveGame.TabIndex = 1;
            this.leaveGame.Text = "Quit Game";
            this.leaveGame.UseVisualStyleBackColor = false;
            this.leaveGame.Click += new System.EventHandler(this.QuitGame);
            // 
            // dealButton
            // 
            this.dealButton.BackColor = System.Drawing.Color.Black;
            this.dealButton.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.ForeColor = System.Drawing.Color.DarkRed;
            this.dealButton.Location = new System.Drawing.Point(344, 639);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(177, 64);
            this.dealButton.TabIndex = 0;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = false;
            this.dealButton.Click += new System.EventHandler(this.DealCards);
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.Black;
            this.hitButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hitButton.Location = new System.Drawing.Point(581, 653);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(91, 50);
            this.hitButton.TabIndex = 2;
            this.hitButton.Text = "HIT";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Click += new System.EventHandler(this.HitButtonClick);
            // 
            // stayButton
            // 
            this.stayButton.BackColor = System.Drawing.Color.Black;
            this.stayButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stayButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.stayButton.Location = new System.Drawing.Point(712, 653);
            this.stayButton.Name = "stayButton";
            this.stayButton.Size = new System.Drawing.Size(91, 50);
            this.stayButton.TabIndex = 3;
            this.stayButton.Text = "STAY";
            this.stayButton.UseVisualStyleBackColor = false;
            this.stayButton.Click += new System.EventHandler(this.StayButton);
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.scoreLbl.Location = new System.Drawing.Point(512, 497);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scoreLbl.Size = new System.Drawing.Size(0, 28);
            this.scoreLbl.TabIndex = 5;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resultLbl.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.ForeColor = System.Drawing.Color.Gold;
            this.resultLbl.Location = new System.Drawing.Point(338, 352);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 32);
            this.resultLbl.TabIndex = 6;
            // 
            // dealerScoreLbl
            // 
            this.dealerScoreLbl.AutoSize = true;
            this.dealerScoreLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dealerScoreLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerScoreLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dealerScoreLbl.Location = new System.Drawing.Point(512, 192);
            this.dealerScoreLbl.Name = "dealerScoreLbl";
            this.dealerScoreLbl.Size = new System.Drawing.Size(0, 28);
            this.dealerScoreLbl.TabIndex = 7;
            // 
            // ties
            // 
            this.ties.AutoSize = true;
            this.ties.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ties.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ties.ForeColor = System.Drawing.Color.Silver;
            this.ties.Location = new System.Drawing.Point(1141, 500);
            this.ties.Name = "ties";
            this.ties.Size = new System.Drawing.Size(0, 30);
            this.ties.TabIndex = 8;
            // 
            // wins
            // 
            this.wins.AutoSize = true;
            this.wins.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wins.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wins.ForeColor = System.Drawing.Color.Silver;
            this.wins.Location = new System.Drawing.Point(1025, 500);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(0, 30);
            this.wins.TabIndex = 26;
            // 
            // losses
            // 
            this.losses.AutoSize = true;
            this.losses.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.losses.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losses.ForeColor = System.Drawing.Color.Silver;
            this.losses.Location = new System.Drawing.Point(1257, 499);
            this.losses.Name = "losses";
            this.losses.Size = new System.Drawing.Size(0, 30);
            this.losses.TabIndex = 27;
            // 
            // chips
            // 
            this.chips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chips.Image = global::Blackjack_Game.Properties.Resources.aces;
            this.chips.Location = new System.Drawing.Point(80, 110);
            this.chips.Name = "chips";
            this.chips.Size = new System.Drawing.Size(198, 190);
            this.chips.TabIndex = 29;
            this.chips.TabStop = false;
            // 
            // cardDealerSeven
            // 
            this.cardDealerSeven.Location = new System.Drawing.Point(1026, 121);
            this.cardDealerSeven.Name = "cardDealerSeven";
            this.cardDealerSeven.Size = new System.Drawing.Size(70, 99);
            this.cardDealerSeven.TabIndex = 22;
            this.cardDealerSeven.TabStop = false;
            // 
            // cardDealerSix
            // 
            this.cardDealerSix.Location = new System.Drawing.Point(949, 121);
            this.cardDealerSix.Name = "cardDealerSix";
            this.cardDealerSix.Size = new System.Drawing.Size(70, 99);
            this.cardDealerSix.TabIndex = 21;
            this.cardDealerSix.TabStop = false;
            // 
            // cardDealerFive
            // 
            this.cardDealerFive.Location = new System.Drawing.Point(872, 121);
            this.cardDealerFive.Name = "cardDealerFive";
            this.cardDealerFive.Size = new System.Drawing.Size(70, 99);
            this.cardDealerFive.TabIndex = 20;
            this.cardDealerFive.TabStop = false;
            // 
            // cardDealerFour
            // 
            this.cardDealerFour.Location = new System.Drawing.Point(795, 121);
            this.cardDealerFour.Name = "cardDealerFour";
            this.cardDealerFour.Size = new System.Drawing.Size(70, 99);
            this.cardDealerFour.TabIndex = 19;
            this.cardDealerFour.TabStop = false;
            // 
            // cardDealerThree
            // 
            this.cardDealerThree.Location = new System.Drawing.Point(718, 122);
            this.cardDealerThree.Name = "cardDealerThree";
            this.cardDealerThree.Size = new System.Drawing.Size(70, 99);
            this.cardDealerThree.TabIndex = 18;
            this.cardDealerThree.TabStop = false;
            // 
            // cardsSeven
            // 
            this.cardsSeven.Location = new System.Drawing.Point(676, 378);
            this.cardsSeven.Name = "cardsSeven";
            this.cardsSeven.Size = new System.Drawing.Size(70, 99);
            this.cardsSeven.TabIndex = 17;
            this.cardsSeven.TabStop = false;
            // 
            // cardsSix
            // 
            this.cardsSix.Location = new System.Drawing.Point(657, 396);
            this.cardsSix.Name = "cardsSix";
            this.cardsSix.Size = new System.Drawing.Size(70, 99);
            this.cardsSix.TabIndex = 16;
            this.cardsSix.TabStop = false;
            // 
            // cardsFive
            // 
            this.cardsFive.Location = new System.Drawing.Point(638, 413);
            this.cardsFive.Name = "cardsFive";
            this.cardsFive.Size = new System.Drawing.Size(70, 99);
            this.cardsFive.TabIndex = 15;
            this.cardsFive.TabStop = false;
            // 
            // cardsFour
            // 
            this.cardsFour.Location = new System.Drawing.Point(619, 430);
            this.cardsFour.Name = "cardsFour";
            this.cardsFour.Size = new System.Drawing.Size(70, 99);
            this.cardsFour.TabIndex = 14;
            this.cardsFour.TabStop = false;
            // 
            // cardsThree
            // 
            this.cardsThree.Location = new System.Drawing.Point(600, 447);
            this.cardsThree.Name = "cardsThree";
            this.cardsThree.Size = new System.Drawing.Size(70, 99);
            this.cardsThree.TabIndex = 13;
            this.cardsThree.TabStop = false;
            // 
            // cardDealerTwo
            // 
            this.cardDealerTwo.Location = new System.Drawing.Point(564, 121);
            this.cardDealerTwo.Name = "cardDealerTwo";
            this.cardDealerTwo.Size = new System.Drawing.Size(70, 99);
            this.cardDealerTwo.TabIndex = 12;
            this.cardDealerTwo.TabStop = false;
            // 
            // cardDealer
            // 
            this.cardDealer.Location = new System.Drawing.Point(641, 121);
            this.cardDealer.Name = "cardDealer";
            this.cardDealer.Size = new System.Drawing.Size(70, 99);
            this.cardDealer.TabIndex = 11;
            this.cardDealer.TabStop = false;
            // 
            // cardsTwo
            // 
            this.cardsTwo.Location = new System.Drawing.Point(581, 464);
            this.cardsTwo.Name = "cardsTwo";
            this.cardsTwo.Size = new System.Drawing.Size(70, 99);
            this.cardsTwo.TabIndex = 10;
            this.cardsTwo.TabStop = false;
            // 
            // cardsOne
            // 
            this.cardsOne.Location = new System.Drawing.Point(564, 481);
            this.cardsOne.Name = "cardsOne";
            this.cardsOne.Size = new System.Drawing.Size(70, 99);
            this.cardsOne.TabIndex = 9;
            this.cardsOne.TabStop = false;
            // 
            // headingLabel
            // 
            this.headingLabel.Image = global::Blackjack_Game.Properties.Resources.blackjack_350x219;
            this.headingLabel.Location = new System.Drawing.Point(473, -50);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(350, 113);
            this.headingLabel.TabIndex = 4;
            this.headingLabel.TabStop = false;
            // 
            // scoreBoard
            // 
            this.scoreBoard.Image = global::Blackjack_Game.Properties.Resources.scoreboard;
            this.scoreBoard.Location = new System.Drawing.Point(976, 400);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(354, 141);
            this.scoreBoard.TabIndex = 28;
            this.scoreBoard.TabStop = false;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blackjack_Game.Properties.Resources.green_background;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.chips);
            this.Controls.Add(this.losses);
            this.Controls.Add(this.wins);
            this.Controls.Add(this.cardDealerSeven);
            this.Controls.Add(this.cardDealerSix);
            this.Controls.Add(this.cardDealerFive);
            this.Controls.Add(this.cardDealerFour);
            this.Controls.Add(this.cardDealerThree);
            this.Controls.Add(this.cardsSeven);
            this.Controls.Add(this.cardsSix);
            this.Controls.Add(this.cardsFive);
            this.Controls.Add(this.cardsFour);
            this.Controls.Add(this.cardsThree);
            this.Controls.Add(this.cardDealerTwo);
            this.Controls.Add(this.cardDealer);
            this.Controls.Add(this.cardsTwo);
            this.Controls.Add(this.cardsOne);
            this.Controls.Add(this.ties);
            this.Controls.Add(this.dealerScoreLbl);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.stayButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.leaveGame);
            this.Controls.Add(this.scoreBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameExiting);
            ((System.ComponentModel.ISupportInitialize)(this.chips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealerSeven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealerSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealerFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealerFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealerThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsSeven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealerTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headingLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button leaveGame;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button stayButton;
        private System.Windows.Forms.PictureBox headingLabel;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label dealerScoreLbl;
        private System.Windows.Forms.Label ties;
        private System.Windows.Forms.PictureBox cardsOne;
        private System.Windows.Forms.PictureBox cardsTwo;
        private System.Windows.Forms.PictureBox cardDealer;
        private System.Windows.Forms.PictureBox cardDealerTwo;
        private System.Windows.Forms.PictureBox cardsThree;
        private System.Windows.Forms.PictureBox cardsFour;
        private System.Windows.Forms.PictureBox cardsFive;
        private System.Windows.Forms.PictureBox cardsSix;
        private System.Windows.Forms.PictureBox cardsSeven;
        private System.Windows.Forms.PictureBox cardDealerThree;
        private System.Windows.Forms.PictureBox cardDealerFour;
        private System.Windows.Forms.PictureBox cardDealerFive;
        private System.Windows.Forms.PictureBox cardDealerSix;
        private System.Windows.Forms.PictureBox cardDealerSeven;
        private System.Windows.Forms.Label wins;
        private System.Windows.Forms.Label losses;
        private System.Windows.Forms.PictureBox scoreBoard;
        private System.Windows.Forms.PictureBox chips;
    }
}