
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using Font = iTextSharp.text.Font;

namespace WinFormsAppDevis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneratePdf();
        }

        void AddCellToTab(string str, Font f, BaseColor c, PdfPTable t)
        {
            PdfPCell cell1 = new PdfPCell(new Phrase(str, f));
            cell1.BackgroundColor = c;
            cell1.Padding = 7;
            cell1.BorderColor = c;
            //cell1.HorizontalAlignment = DataGridViewElement.ALIGN_LEFT;
            t.AddCell(cell1);
            // Fermerture du document
           
        }
        void GeneratePdf()
        {
            string outFile = Environment.CurrentDirectory + "/devis.pdf";
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(outFile, FileMode.Create));
            doc.Open();

            //Palette de couleurs

            BaseColor blue = new BaseColor(0, 75, 155);
            BaseColor gris = new BaseColor(240,240,240);
            BaseColor blanc = new BaseColor(250, 250, 250);

            // Police d'écriture
            Font policeTitre = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD, blue);

            Font policeTh = new Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16f, iTextSharp.text.Font.BOLD, blanc);

            //Page
            // Création de paragraphe
            Paragraph p1 = new Paragraph("ELONOVACAR" + info.Text + "\n\n",policeTitre);
            p1.Alignment = Element.ALIGN_LEFT;
            doc.Add(p1);

            Paragraph p2 = new Paragraph("Client:" + client.Text + "\n\n", policeTitre);
            p2.Alignment = Element.ALIGN_RIGHT;
            doc.Add(p2);

            Paragraph p3 = new Paragraph("Devis:" + client.Text + "\n\n", policeTitre);
            p3.Alignment = Element.ALIGN_LEFT;
            doc.Add(p3);


            PdfPTable tableau = new PdfPTable(3);
            tableau.WidthPercentage = 100;
            //TODO: Ajouter la désignation et service dans un tableau
            //création de tableau:
            AddCellToTab("Désignation", policeTh, blue, tableau);
            AddCellToTab("Quantité", policeTh, blue, tableau);
            AddCellToTab("Prix", policeTh, blue, tableau);

            //lister les produits:
            string[] infosDesignation = new string[3];
            infosDesignation[0] = designation.Text;
            infosDesignation[1] = qte.Text;
            infosDesignation[2] = prix.Text;

            foreach(string info in infosDesignation)
            {
                PdfPCell cell = new PdfPCell(new Phrase(info));
                cell.BackgroundColor = gris;
                cell.Padding = 7;
                cell.BorderColor = gris;
                tableau.AddCell(cell);
            }
            doc.Add(tableau);
            doc.Add(new Phrase("\n"));

            int prixTotal = int.Parse(prix.Text) * int.Parse(qte.Text);

            Paragraph p4 = new Paragraph("Total:" + prix + "\n\n", policeTitre);
            p4.Alignment = Element.ALIGN_RIGHT;
            doc.Add(p4);

            //fermer le doc
            doc.Close();
            Process.Start(@"cmd.exe", @"/c" + outFile);
          

        }
        

    }
}