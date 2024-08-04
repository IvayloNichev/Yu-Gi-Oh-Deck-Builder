using CreateDeck;
using Duel;
using MainScreen;





namespace DeckBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RuleBook_Click(object sender, EventArgs e)
        {
            string pdfPath = @"D:\Coding\Yu-Gi-Oh_DeckBuilder\Resources\Rulebook.pdf";

            PdfViewerForm viewForm = new PdfViewerForm();

            viewForm.LoadPdf(pdfPath);

            viewForm.Show();



        }


        private void Duel_Click(object sender, EventArgs e)
        {
            DuelForm duelForm = new DuelForm();
            duelForm.ShowDialog();
        }

        private void Deck_Click(object sender, EventArgs e)
        {
            CreateDeckForm createDeckForm = new CreateDeckForm();
            createDeckForm.ShowDialog();
        }

    }
}
