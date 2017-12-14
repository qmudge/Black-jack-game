/* Filename: Menu form components.
 * Author: Quintin Mudge.
 * Created: 21/09/2017.
 * Operating system: Windows.
 * Version: Windows 10.
 * Description: Creates the components contained on the menu form.
*/

namespace Blackjack_Game
{
    partial class startScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startScreen));
            this.blackJackBackground = new System.Windows.Forms.PictureBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.blackJackBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // blackJackBackground
            // 
            this.blackJackBackground.Image = ((System.Drawing.Image)(resources.GetObject("blackJackBackground.Image")));
            this.blackJackBackground.Location = new System.Drawing.Point(0, 0);
            this.blackJackBackground.Name = "blackJackBackground";
            this.blackJackBackground.Size = new System.Drawing.Size(1366, 768);
            this.blackJackBackground.TabIndex = 4;
            this.blackJackBackground.TabStop = false;
            // 
            // newGameButton
            // 
            this.newGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newGameButton.AutoSize = true;
            this.newGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.newGameButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.newGameButton.Location = new System.Drawing.Point(569, 244);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(205, 85);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "New Game\r\n";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.NewGameButtonClick);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Maroon;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quitButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(569, 390);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(205, 85);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButtonClick);
            // 
            // startScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.blackJackBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "startScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack Game";
            ((System.ComponentModel.ISupportInitialize)(this.blackJackBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox blackJackBackground;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button quitButton;
    }
}

