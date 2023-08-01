using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace TraversalCoreProje.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path,FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document,stream);

            document.Open();
            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/dosya1.pdf","application/pdf","/dosya1.pdf");
        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(),
              "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir Tc");

            pdfPTable.AddCell(" Eylül");
            pdfPTable.AddCell(" Yucedag");
            pdfPTable.AddCell("11111111110");

            pdfPTable.AddCell(" Kemal");
            pdfPTable.AddCell(" Yıldırım");
            pdfPTable.AddCell("12345678912");
            document.Add(pdfPTable);
            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "/dosya2.pdf");

        }
    }
}
