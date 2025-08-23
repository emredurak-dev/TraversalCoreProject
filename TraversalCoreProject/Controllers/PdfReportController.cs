using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path,FileMode.Create);

            Document document=new Document(PageSize.A4);
            PdfWriter.GetInstance(document,stream);

            document.Open();
            Paragraph paragraph = new Paragraph("traversal rezervasyon pdf raporu");
            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }

        public IActionResult StaticCustomerReport()
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("misafir adi");
            pdfPTable.AddCell("misafir soyadi");
            pdfPTable.AddCell("misafir tc");

            pdfPTable.AddCell("eylul");
            pdfPTable.AddCell("yucedag");
            pdfPTable.AddCell("11111111111");

            pdfPTable.AddCell("murat");
            pdfPTable.AddCell("yucedag");
            pdfPTable.AddCell("22222222222");

            pdfPTable.AddCell("mesut");
            pdfPTable.AddCell("yucedag");
            pdfPTable.AddCell("33333333333");

            pdfPTable.AddCell("emre");
            pdfPTable.AddCell("yucedag");
            pdfPTable.AddCell("44444444444");

            document.Add(pdfPTable);

            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}
