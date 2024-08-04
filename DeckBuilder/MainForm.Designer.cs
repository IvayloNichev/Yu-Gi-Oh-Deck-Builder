
namespace DeckBuilder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Deck = new Button();
            RuleBook = new Button();
            Duel = new Button();
            SuspendLayout();
            // 
            // Deck
            // 
            Deck.Anchor = AnchorStyles.Top;
            Deck.BackColor = SystemColors.ButtonFace;
            Deck.Cursor = Cursors.Hand;
            Deck.Font = new Font("Showcard Gothic", 7.8F);
            Deck.Location = new Point(144, 312);
            Deck.Margin = new Padding(4, 3, 4, 3);
            Deck.Name = "Deck";
            Deck.Size = new Size(136, 25);
            Deck.TabIndex = 0;
            Deck.Text = "Create a Deck";
            Deck.UseVisualStyleBackColor = false;
            Deck.Click += Deck_Click;
            // 
            // RuleBook
            // 
            RuleBook.Anchor = AnchorStyles.Top;
            RuleBook.BackColor = SystemColors.ButtonFace;
            RuleBook.Cursor = Cursors.Hand;
            RuleBook.Font = new Font("Showcard Gothic", 7.8F);
            RuleBook.Location = new Point(508, 312);
            RuleBook.Margin = new Padding(4, 3, 4, 3);
            RuleBook.Name = "RuleBook";
            RuleBook.Size = new Size(136, 25);
            RuleBook.TabIndex = 2;
            RuleBook.Text = "Rulebook";
            RuleBook.UseVisualStyleBackColor = false;
            RuleBook.Click += RuleBook_Click;
            // 
            // Duel
            // 
            Duel.Anchor = AnchorStyles.Top;
            Duel.BackColor = SystemColors.ButtonFace;
            Duel.Cursor = Cursors.Hand;
            Duel.Font = new Font("Showcard Gothic", 7.8F);
            Duel.Location = new Point(329, 312);
            Duel.Margin = new Padding(4, 3, 4, 3);
            Duel.Name = "Duel";
            Duel.Size = new Size(136, 25);
            Duel.TabIndex = 3;
            Duel.Text = "Duel";
            Duel.UseVisualStyleBackColor = false;
            Duel.Click += this.Duel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = MainScreen.Properties.Resources.LoginScreeenBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(818, 382);
            Controls.Add(Duel);
            Controls.Add(RuleBook);
            Controls.Add(Deck);
            Cursor = Cursors.Hand;
            Font = new Font("Showcard Gothic", 7.8F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Main Menu";
            Load += Form1_Load;
            ResumeLayout(false);
        }

      

        #endregion

        private Button Deck;
        private Button RuleBook;
        private Button Duel;
    }
}
