using System.IO;
using Syncfusion.Pdf;
using Syncfusion.HtmlConverter;


namespace DaveEvansTech.Helpers
{
    public class ConvertHtmlToPdfService
    {
        public void CreatePDF(string htmlString)
        {
            //Initialize the HTML to PDF converter 
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);

            WebKitConverterSettings settings = new WebKitConverterSettings();
            
            //Set WebKit path
            settings.WebKitPath = @"/QtBinaries/";
            
            //Assign WebKit settings to HTML converter
            htmlConverter.ConverterSettings = settings;

            //Convert HTML to PDF
            PdfDocument document = htmlConverter.Convert(htmlString);

            //Save and close the PDF document 
            using (var stream = File.OpenWrite("my-pdf.pdf"))
            {
                document.Save(stream);
            }

            document.Close(true);
        }
    }
}