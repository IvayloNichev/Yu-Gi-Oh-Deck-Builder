namespace Duel
{
    partial class DuelForm
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
            HighlightedCard = new PictureBox();
            DrawCardBtn = new Button();
            BanishBtn = new Button();
            TopDeckBtn = new Button();
            BottomDeckBtn = new Button();
            GYBtn = new Button();
            PlayMat = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)HighlightedCard).BeginInit();
            SuspendLayout();
            // 
            // HighlightedCard
            // 
            HighlightedCard.Location = new Point(29, 59);
            HighlightedCard.Name = "HighlightedCard";
            HighlightedCard.Size = new Size(136, 206);
            HighlightedCard.TabIndex = 0;
            HighlightedCard.TabStop = false;
            // 
            // DrawCardBtn
            // 
            DrawCardBtn.Location = new Point(29, 328);
            DrawCardBtn.Name = "DrawCardBtn";
            DrawCardBtn.Size = new Size(94, 29);
            DrawCardBtn.TabIndex = 1;
            DrawCardBtn.Text = "Draw";
            DrawCardBtn.UseVisualStyleBackColor = true;
            // 
            // BanishBtn
            // 
            BanishBtn.Location = new Point(29, 354);
            BanishBtn.Name = "BanishBtn";
            BanishBtn.Size = new Size(94, 29);
            BanishBtn.TabIndex = 2;
            BanishBtn.Text = "Banish";
            BanishBtn.UseVisualStyleBackColor = true;
            // 
            // TopDeckBtn
            // 
            TopDeckBtn.Location = new Point(29, 380);
            TopDeckBtn.Name = "TopDeckBtn";
            TopDeckBtn.Size = new Size(94, 29);
            TopDeckBtn.TabIndex = 3;
            TopDeckBtn.Text = "To Top";
            TopDeckBtn.UseVisualStyleBackColor = true;
            // 
            // BottomDeckBtn
            // 
            BottomDeckBtn.Location = new Point(29, 406);
            BottomDeckBtn.Name = "BottomDeckBtn";
            BottomDeckBtn.Size = new Size(94, 29);
            BottomDeckBtn.TabIndex = 4;
            BottomDeckBtn.Text = "To bottom";
            BottomDeckBtn.UseVisualStyleBackColor = true;
            // 
            // GYBtn
            // 
            GYBtn.Location = new Point(29, 431);
            GYBtn.Name = "GYBtn";
            GYBtn.Size = new Size(94, 29);
            GYBtn.TabIndex = 5;
            GYBtn.Text = "To GY";
            GYBtn.UseVisualStyleBackColor = true;
            // 
            // PlayMat
            // 
            PlayMat.ColumnCount = 7;
            PlayMat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            PlayMat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            PlayMat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            PlayMat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            PlayMat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            PlayMat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            PlayMat.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            PlayMat.Location = new Point(211, 59);
            PlayMat.Name = "PlayMat";
            PlayMat.RowCount = 2;
            PlayMat.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PlayMat.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            PlayMat.Size = new Size(649, 259);
            PlayMat.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Location = new Point(283, 369);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(458, 91);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // Duel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 506);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(PlayMat);
            Controls.Add(GYBtn);
            Controls.Add(BottomDeckBtn);
            Controls.Add(TopDeckBtn);
            Controls.Add(BanishBtn);
            Controls.Add(DrawCardBtn);
            Controls.Add(HighlightedCard);
            Cursor = Cursors.Hand;
            Name = "Duel";
            Text = "Duel";
            Load += Duel_Load;
            ((System.ComponentModel.ISupportInitialize)HighlightedCard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox HighlightedCard;
        private Button DrawCardBtn;
        private Button BanishBtn;
        private Button TopDeckBtn;
        private Button BottomDeckBtn;
        private Button GYBtn;
        private TableLayoutPanel PlayMat;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
