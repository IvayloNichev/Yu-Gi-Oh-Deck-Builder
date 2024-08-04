using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;


namespace CreateDeck
{


    public partial class CreateDeckForm : Form
    {

        public CreateDeckForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }


        private void InitializeCustomComponents()
        {
            mainDeckImageList = new ImageList();
            extraDeckImageList = new ImageList();


            InitializeTableLayoutPanel(deckPlaceholder, mainDeckImageList);
            InitializeTableLayoutPanel(extraDeckPlaceholder, extraDeckImageList);

        }

        private void InitializeTableLayoutPanel(TableLayoutPanel table, ImageList imageList)
        {
            for (int row = 0; row < table.RowCount; row++)
            {
                for (int col = 0; col < table.ColumnCount; col++)
                {
                    var pictureBox = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Fill
                    };
                    table.Controls.Add(pictureBox, col, row);
                }
            }
        }


        private void CreateDeckForm_Load(object sender, EventArgs e)
        {

        }

        // Adding Cards
        private void AddToMainBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select a Card Image";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                Image selectedImage = Image.FromFile(openFileDialog.FileName);


                AddCardToPlaceholder(deckPlaceholder, selectedImage);
            }
            else
            {
                MessageBox.Show("No image selected. Please select an image to add to the deck.");
            }
        }

        private void AddToExtraBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select a Card Image";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                Image selectedImage = Image.FromFile(openFileDialog.FileName);


                AddCardToPlaceholder(extraDeckPlaceholder, selectedImage);
            }
            else
            {
                MessageBox.Show("No image selected. Please select an image to add to the deck.");
            }
        }

        private void AddCardToPlaceholder(TableLayoutPanel table, Image image)
        {
            foreach (Control control in table.Controls)
            {
                if (control is PictureBox pictureBox && pictureBox.Image == null)
                {
                    pictureBox.Image = image;
                    break;
                }
            }
        }

        // Removing cards from the deck
        private void RemoveFromMainBtn_Click(object sender, EventArgs e)
        {
            RemoveCardFromPlaceholder(deckPlaceholder, mainDeckImageList);
        }

        private void RemoveFromExtraBtn_Click(object sender, EventArgs e)
        {
            RemoveCardFromPlaceholder(extraDeckPlaceholder, extraDeckImageList);
        }


        private void RemoveCardFromPlaceholder(TableLayoutPanel table, ImageList imageList)
        {
            for (int row = table.RowCount - 1; row >= 0; row--)
            {
                for (int col = table.ColumnCount - 1; col >= 0; col--)
                {

                    Control control = table.GetControlFromPosition(col, row);


                    if (control is PictureBox pictureBox && pictureBox.Image != null)
                    {
                        pictureBox.Image = null;
                        return;
                    }
                }
            }
        }

        // Saving and Loading the Deck



        private void SaveDeck()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Deck As";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var deckData = new CardDeckData();

                    // Gather data from Main Deck
                    foreach (Control control in deckPlaceholder.Controls)
                    {
                        if (control is PictureBox pictureBox && pictureBox.Image != null)
                        {
                            deckData.MainDeck.Add(pictureBox.ImageLocation);
                        }
                    }

                    // Gather data from Extra Deck
                    foreach (Control control in extraDeckPlaceholder.Controls)
                    {
                        if (control is PictureBox pictureBox && pictureBox.Image != null)
                        {
                            deckData.ExtraDeck.Add(pictureBox.ImageLocation);
                        }
                    }

                    // Serialize the data and write to the chosen file path
                    string jsonData = JsonConvert.SerializeObject(deckData, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(saveFileDialog.FileName, jsonData);

                    MessageBox.Show("Deck saved successfully.");
                }
            }
        }
        //Load the Deck
        private void LoadDeck()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Load Deck";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read and deserialize JSON data
                    string jsonData = File.ReadAllText(openFileDialog.FileName);
                    var deckData = JsonConvert.DeserializeObject<CardDeckData>(jsonData);

                    // Clear current placeholders
                    ClearDeckPlaceholders();

                    // Load data into Main Deck
                    for (int i = 0; i < deckData.MainDeck.Count; i++)
                    {
                        if (i < deckPlaceholder.Controls.Count)
                        {
                            if (deckPlaceholder.Controls[i] is PictureBox pictureBox)
                            {
                                string imageLocation = deckData.MainDeck[i];
                                if (!string.IsNullOrEmpty(imageLocation) && File.Exists(imageLocation))
                                {
                                    pictureBox.ImageLocation = imageLocation;
                                    pictureBox.Load(); // Loads the image from the specified path
                                }
                            }
                        }
                    }

                    // Load data into Extra Deck
                    for (int i = 0; i < deckData.ExtraDeck.Count; i++)
                    {
                        if (i < extraDeckPlaceholder.Controls.Count)
                        {
                            if (extraDeckPlaceholder.Controls[i] is PictureBox pictureBox)
                            {
                                string imageLocation = deckData.ExtraDeck[i];
                                if (!string.IsNullOrEmpty(imageLocation) && File.Exists(imageLocation))
                                {
                                    pictureBox.ImageLocation = imageLocation;
                                    pictureBox.Load(); // Loads the image from the specified path
                                }
                            }
                        }
                    }

                    MessageBox.Show("Deck loaded successfully.");
                }
            }
        }

        private void ClearDeckPlaceholders()
        {
            foreach (Control control in deckPlaceholder.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Image = null;
                }
            }

            foreach (Control control in extraDeckPlaceholder.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Image = null;
                }
            }
        }
        private void SaveDeckBtn_Click(object sender, EventArgs e)
        {
            SaveDeck();
        }

        private void LoadDeckBtn_Click(object sender, EventArgs e)
        {
            LoadDeck();
        }
    }
    public class CardDeckData
    {
        public List<string> MainDeck { get; set; } = new List<string>();
        public List<string> ExtraDeck { get; set; } = new List<string>();
    }
}
