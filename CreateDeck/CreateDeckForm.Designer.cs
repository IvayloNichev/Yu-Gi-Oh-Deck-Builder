namespace CreateDeck
{
    partial class CreateDeckForm
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
            components = new System.ComponentModel.Container();
            deckPlaceholder = new TableLayoutPanel();
            AddToMainBtn = new Button();
            RemoveFromMainBtn = new Button();
            SaveDeckBtn = new Button();
            extraDeckPlaceholder = new TableLayoutPanel();
            AddToExtraBtn = new Button();
            RemoveFromExtraBtn = new Button();
            LoadDeckBtn = new Button();
            mainDeckImageList = new ImageList(components);
            extraDeckImageList = new ImageList(components);
            SuspendLayout();
            // 
            // deckPlaceholder
            // 
            deckPlaceholder.BackColor = SystemColors.ButtonFace;
            deckPlaceholder.ColumnCount = 10;
            deckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            deckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            deckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            deckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            deckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            deckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            deckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            deckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            deckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            deckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            deckPlaceholder.Cursor = Cursors.Hand;
            deckPlaceholder.Location = new Point(147, 35);
            deckPlaceholder.Name = "deckPlaceholder";
            deckPlaceholder.RowCount = 6;
            deckPlaceholder.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666718F));
            deckPlaceholder.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            deckPlaceholder.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            deckPlaceholder.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            deckPlaceholder.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            deckPlaceholder.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            deckPlaceholder.Size = new Size(613, 310);
            deckPlaceholder.TabIndex = 1;
            // 
            // AddToMainBtn
            // 
            AddToMainBtn.Location = new Point(12, 35);
            AddToMainBtn.Name = "AddToMainBtn";
            AddToMainBtn.Size = new Size(129, 39);
            AddToMainBtn.TabIndex = 2;
            AddToMainBtn.Text = "Add to Main";
            AddToMainBtn.UseVisualStyleBackColor = true;
            AddToMainBtn.Click += AddToMainBtn_Click;
            // 
            // RemoveFromMainBtn
            // 
            RemoveFromMainBtn.Location = new Point(12, 125);
            RemoveFromMainBtn.Name = "RemoveFromMainBtn";
            RemoveFromMainBtn.Size = new Size(129, 49);
            RemoveFromMainBtn.TabIndex = 3;
            RemoveFromMainBtn.Text = "Remove from Main";
            RemoveFromMainBtn.UseVisualStyleBackColor = true;
            RemoveFromMainBtn.Click += RemoveFromMainBtn_Click;
            // 
            // SaveDeckBtn
            // 
            SaveDeckBtn.Location = new Point(12, 235);
            SaveDeckBtn.Name = "SaveDeckBtn";
            SaveDeckBtn.Size = new Size(129, 39);
            SaveDeckBtn.TabIndex = 4;
            SaveDeckBtn.Text = "Save Deck";
            SaveDeckBtn.UseVisualStyleBackColor = true;
            SaveDeckBtn.Click += SaveDeckBtn_Click;
            // 
            // extraDeckPlaceholder
            // 
            extraDeckPlaceholder.ColumnCount = 15;
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.66666651F));
            extraDeckPlaceholder.Location = new Point(147, 363);
            extraDeckPlaceholder.Name = "extraDeckPlaceholder";
            extraDeckPlaceholder.RowCount = 1;
            extraDeckPlaceholder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            extraDeckPlaceholder.Size = new Size(613, 55);
            extraDeckPlaceholder.TabIndex = 6;
            // 
            // AddToExtraBtn
            // 
            AddToExtraBtn.Location = new Point(12, 80);
            AddToExtraBtn.Name = "AddToExtraBtn";
            AddToExtraBtn.Size = new Size(129, 39);
            AddToExtraBtn.TabIndex = 7;
            AddToExtraBtn.Text = "Add to Extra";
            AddToExtraBtn.UseVisualStyleBackColor = true;
            AddToExtraBtn.Click += AddToExtraBtn_Click;
            // 
            // RemoveFromExtraBtn
            // 
            RemoveFromExtraBtn.Location = new Point(12, 180);
            RemoveFromExtraBtn.Name = "RemoveFromExtraBtn";
            RemoveFromExtraBtn.Size = new Size(129, 49);
            RemoveFromExtraBtn.TabIndex = 8;
            RemoveFromExtraBtn.Text = "Remove from Extra";
            RemoveFromExtraBtn.UseVisualStyleBackColor = true;
            RemoveFromExtraBtn.Click += RemoveFromExtraBtn_Click;
            // 
            // LoadDeckBtn
            // 
            LoadDeckBtn.Location = new Point(12, 280);
            LoadDeckBtn.Name = "LoadDeckBtn";
            LoadDeckBtn.Size = new Size(129, 39);
            LoadDeckBtn.TabIndex = 9;
            LoadDeckBtn.Text = "Load Deck";
            LoadDeckBtn.UseVisualStyleBackColor = true;
            LoadDeckBtn.Click += LoadDeckBtn_Click;
            // 
            // mainDeckImageList
            // 
            mainDeckImageList.ColorDepth = ColorDepth.Depth32Bit;
            mainDeckImageList.ImageSize = new Size(16, 16);
            mainDeckImageList.TransparentColor = Color.Transparent;
            // 
            // extraDeckImageList
            // 
            extraDeckImageList.ColorDepth = ColorDepth.Depth32Bit;
            extraDeckImageList.ImageSize = new Size(16, 16);
            extraDeckImageList.TransparentColor = Color.Transparent;
            // 
            // CreateDeckForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(LoadDeckBtn);
            Controls.Add(RemoveFromExtraBtn);
            Controls.Add(AddToExtraBtn);
            Controls.Add(extraDeckPlaceholder);
            Controls.Add(SaveDeckBtn);
            Controls.Add(RemoveFromMainBtn);
            Controls.Add(AddToMainBtn);
            Controls.Add(deckPlaceholder);
            Cursor = Cursors.Hand;
            Name = "CreateDeckForm";
            Text = "Create a Deck";
            Load += CreateDeckForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel deckPlaceholder;
        private Button AddToMainBtn;
        private Button RemoveFromMainBtn;
        private Button SaveDeckBtn;
        private TableLayoutPanel extraDeckPlaceholder;
        private Button AddToExtraBtn;
        private Button RemoveFromExtraBtn;
        private Button LoadDeckBtn;
        private ImageList mainDeckImageList;
        private ImageList extraDeckImageList;
    }
}
