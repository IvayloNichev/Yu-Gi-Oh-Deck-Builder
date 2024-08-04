using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;

namespace MainScreen
{
    public partial class PdfViewerForm : Form
    {

        private PdfViewer pdfViewer;

        public PdfViewerForm()
        {
            InitializeComponent();
            InitializePdfViewer();
        }


        private void PdfViewerForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializePdfViewer()
        {
            pdfViewer = new PdfViewer();

            pdfViewer.Dock = DockStyle.Fill;

            this.Controls.Add(pdfViewer);
        }

        public void LoadPdf(string pdfPath)
        {
            try
            {
                pdfViewer.Document = PdfDocument.Load(pdfPath);
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured while loading the PDF:" + e.Message);
            }
        }

        
    }
}
