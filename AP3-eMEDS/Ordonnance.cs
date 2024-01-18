using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    public class Ordonnance
    {
        public int Id { get; set; }
        public string Posologie { get; set; }
        public string Duree {  get; set; }
        public string InstructionsSpe {  get; set; }
        public string Code { get; set; }

        // create item from db
        public Ordonnance(int id, string posologie, string duree, string instructionSpe, string code ) {
            this.Id = id;
            this.Posologie = posologie;
            this.Duree = duree;
            this.InstructionsSpe = instructionSpe;
            this.Code = code;
        }

        // create item to send to db
        public Ordonnance(string posologie, string duree, string instructionSpe, string code)
        {
            this.Posologie = posologie;
            this.Duree = duree;
            this.InstructionsSpe = instructionSpe;
            this.Code = code;
        }

        // method to generate the entire pdf
        public void GeneratePDF(Patient patient, Medecin medecin, Ordonnance ordonnance, List<Medicament> meds, string fileName)
        {
            // create path to dl file 
            string outFile = Environment.CurrentDirectory + $"/{fileName}.pdf";
            // create document and add table
            Document doc = new Document();
            PdfPTable tableLayout = new PdfPTable(2);

            PdfWriter.GetInstance(doc, new FileStream(outFile, FileMode.Create));
            doc.Open();

            Paragraph patientInfos = new Paragraph($"{patient.Nom} {patient.Prenom} {patient.Sexe} - {patient.NumSecu}");
            patientInfos.Alignment = Element.ALIGN_LEFT;
            doc.Add(patientInfos);

            Paragraph medecinInfo = new Paragraph($"{medecin.Nom} {medecin.Prenom}");
            medecinInfo.Alignment = Element.ALIGN_RIGHT;
            doc.Add(medecinInfo);

            doc.Add(GeneratePdfTable(tableLayout, meds));

            Paragraph posologie = new Paragraph($"Posologie : {ordonnance.Posologie}");
            posologie.Alignment = Element.ALIGN_LEFT;
            doc.Add(posologie);

            Paragraph duree = new Paragraph($"Durée du traitement : {ordonnance.Duree}");
            duree.Alignment = Element.ALIGN_LEFT;
            doc.Add(duree);

            doc.Close();
            Process.Start(@"cmd.exe", @"/c " + outFile);
        }

        // method to generate pdf table medicament
        private PdfPTable GeneratePdfTable(PdfPTable tableLayout, List<Medicament> medicament)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase("Creating PDF file using iTextsharp", new Font(Font.NORMAL, 13, 1, new iTextSharp.text.BaseColor(153, 51, 0))))
            {
                Colspan = 4,
                Border = 0,
                PaddingBottom = 20,
                HorizontalAlignment = Element.ALIGN_CENTER
            });
            //Add header  
            AddCellToHeader(tableLayout, "Libellé du médicament");
            AddCellToHeader(tableLayout, "Contre-indications");
            //Add body
            foreach (Medicament med in medicament)
            {
                AddCellToBody(tableLayout, med.Libelle);
                AddCellToBody(tableLayout, med.ContreIndication);
            }
            return tableLayout;
        }

        // Method to add single cell to the header  
        private static void AddCellToHeader(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.NORMAL, 8, 1, iTextSharp.text.BaseColor.WHITE)))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 5,
                BackgroundColor = new iTextSharp.text.BaseColor(0, 51, 102)
            });
        }
        // Method to add single cell to the body  
        private static void AddCellToBody(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.NORMAL, 8, 1, iTextSharp.text.BaseColor.BLACK)))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 5,
                BackgroundColor = iTextSharp.text.BaseColor.WHITE
            });
        }
    }


}
