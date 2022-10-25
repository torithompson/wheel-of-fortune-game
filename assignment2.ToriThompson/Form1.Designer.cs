namespace assignment2.ToriThompson
{
    partial class Form1
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
            this.player1Label = new System.Windows.Forms.Label();
            this.player1Name = new System.Windows.Forms.TextBox();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.TextBox();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.player2Score = new System.Windows.Forms.TextBox();
            this.targetWordBox = new System.Windows.Forms.TextBox();
            this.targetWordLabel = new System.Windows.Forms.Label();
            this.letterGuessBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.prizeWheel = new System.Windows.Forms.PictureBox();
            this.gameTitle = new System.Windows.Forms.PictureBox();
            this.playerTurnLabel = new System.Windows.Forms.Label();
            this.letterAlreadyGuessed = new System.Windows.Forms.TextBox();
            this.letterGuessedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prizeWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.Location = new System.Drawing.Point(52, 144);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(105, 18);
            this.player1Label.TabIndex = 1;
            this.player1Label.Text = "Player 1 Name:";
            // 
            // player1Name
            // 
            this.player1Name.Location = new System.Drawing.Point(55, 165);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(100, 20);
            this.player1Name.TabIndex = 2;
            this.player1Name.TextChanged += new System.EventHandler(this.player1Name_TextChanged);
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLabel.Location = new System.Drawing.Point(53, 213);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(102, 18);
            this.player1ScoreLabel.TabIndex = 3;
            this.player1ScoreLabel.Text = "Player 1 Score:";
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameLabel.Location = new System.Drawing.Point(52, 294);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(105, 18);
            this.player2NameLabel.TabIndex = 4;
            this.player2NameLabel.Text = "Player 2 Name:";
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreLabel.Location = new System.Drawing.Point(53, 361);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(102, 18);
            this.player2ScoreLabel.TabIndex = 5;
            this.player2ScoreLabel.Text = "Player 2 Score:";
            // 
            // player1Score
            // 
            this.player1Score.Location = new System.Drawing.Point(55, 234);
            this.player1Score.Name = "player1Score";
            this.player1Score.ReadOnly = true;
            this.player1Score.Size = new System.Drawing.Size(100, 20);
            this.player1Score.TabIndex = 6;
            // 
            // player2Name
            // 
            this.player2Name.Location = new System.Drawing.Point(55, 315);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(100, 20);
            this.player2Name.TabIndex = 7;
            this.player2Name.TextChanged += new System.EventHandler(this.player2Name_TextChanged);
            // 
            // player2Score
            // 
            this.player2Score.Location = new System.Drawing.Point(55, 382);
            this.player2Score.Name = "player2Score";
            this.player2Score.ReadOnly = true;
            this.player2Score.Size = new System.Drawing.Size(100, 20);
            this.player2Score.TabIndex = 8;
            // 
            // targetWordBox
            // 
            this.targetWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetWordBox.Location = new System.Drawing.Point(375, 92);
            this.targetWordBox.Name = "targetWordBox";
            this.targetWordBox.ReadOnly = true;
            this.targetWordBox.Size = new System.Drawing.Size(142, 26);
            this.targetWordBox.TabIndex = 9;
            // 
            // targetWordLabel
            // 
            this.targetWordLabel.AutoSize = true;
            this.targetWordLabel.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetWordLabel.Location = new System.Drawing.Point(385, 65);
            this.targetWordLabel.Name = "targetWordLabel";
            this.targetWordLabel.Size = new System.Drawing.Size(121, 24);
            this.targetWordLabel.TabIndex = 10;
            this.targetWordLabel.Text = "Target Word:";
            // 
            // letterGuessBox
            // 
            this.letterGuessBox.Location = new System.Drawing.Point(239, 350);
            this.letterGuessBox.Mask = "L";
            this.letterGuessBox.Name = "letterGuessBox";
            this.letterGuessBox.ReadOnly = true;
            this.letterGuessBox.Size = new System.Drawing.Size(42, 20);
            this.letterGuessBox.TabIndex = 11;
            this.letterGuessBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letterGuessBox.Click += new System.EventHandler(this.letterGuessBox_Click);
            this.letterGuessBox.TextChanged += new System.EventHandler(this.letterGuessBox_TextChanged);
            this.letterGuessBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.letterGuessBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Guess a letter:";
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(213, 263);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(93, 36);
            this.startGame.TabIndex = 14;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Visible = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // prizeWheel
            // 
            this.prizeWheel.Image = global::assignment2.ToriThompson.Properties.Resources.wof;
            this.prizeWheel.Location = new System.Drawing.Point(375, 234);
            this.prizeWheel.Name = "prizeWheel";
            this.prizeWheel.Size = new System.Drawing.Size(187, 199);
            this.prizeWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prizeWheel.TabIndex = 13;
            this.prizeWheel.TabStop = false;
            // 
            // gameTitle
            // 
            this.gameTitle.Image = global::assignment2.ToriThompson.Properties.Resources.woftitle;
            this.gameTitle.Location = new System.Drawing.Point(43, 32);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(263, 90);
            this.gameTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameTitle.TabIndex = 0;
            this.gameTitle.TabStop = false;
            // 
            // playerTurnLabel
            // 
            this.playerTurnLabel.AutoSize = true;
            this.playerTurnLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTurnLabel.Location = new System.Drawing.Point(222, 163);
            this.playerTurnLabel.Name = "playerTurnLabel";
            this.playerTurnLabel.Size = new System.Drawing.Size(0, 20);
            this.playerTurnLabel.TabIndex = 15;
            this.playerTurnLabel.Visible = false;
            // 
            // letterAlreadyGuessed
            // 
            this.letterAlreadyGuessed.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterAlreadyGuessed.Location = new System.Drawing.Point(604, 69);
            this.letterAlreadyGuessed.Multiline = true;
            this.letterAlreadyGuessed.Name = "letterAlreadyGuessed";
            this.letterAlreadyGuessed.ReadOnly = true;
            this.letterAlreadyGuessed.Size = new System.Drawing.Size(125, 266);
            this.letterAlreadyGuessed.TabIndex = 16;
            // 
            // letterGuessedLabel
            // 
            this.letterGuessedLabel.AutoSize = true;
            this.letterGuessedLabel.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterGuessedLabel.Location = new System.Drawing.Point(592, 50);
            this.letterGuessedLabel.Name = "letterGuessedLabel";
            this.letterGuessedLabel.Size = new System.Drawing.Size(151, 17);
            this.letterGuessedLabel.TabIndex = 17;
            this.letterGuessedLabel.Text = "Letters Already Guessed:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.letterGuessedLabel);
            this.Controls.Add(this.letterAlreadyGuessed);
            this.Controls.Add(this.playerTurnLabel);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.prizeWheel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.letterGuessBox);
            this.Controls.Add(this.targetWordLabel);
            this.Controls.Add(this.targetWordBox);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player2NameLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.gameTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prizeWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameTitle;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.TextBox player1Name;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.TextBox player1Score;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.TextBox player2Score;
        private System.Windows.Forms.TextBox targetWordBox;
        private System.Windows.Forms.Label targetWordLabel;
        private System.Windows.Forms.MaskedTextBox letterGuessBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox prizeWheel;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Label playerTurnLabel;
        private System.Windows.Forms.TextBox letterAlreadyGuessed;
        private System.Windows.Forms.Label letterGuessedLabel;
    }
}

