using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using log4net;

namespace AutomationFramework
{
    /// <summary>
    /// Class for PDF data assertions
    /// </summary>
    class PDFAssertions
    {
        public static readonly ILog logger = LogManager.GetLogger(typeof(PDFAssertions));
        /// <summary>
        /// Method to extract all text from a PDF document
        /// </summary>
        /// <param name="pdfFilePath">File path of the pdf document</param>
        /// <returns>The text content of the PDF document.</returns>
        public static string ExtractAllTextFromPDF(string pdfFilePath)
        {
            StringBuilder pdfText = new StringBuilder();

            PdfReader reader = new PdfReader(pdfFilePath);

            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                SimpleTextExtractionStrategy strategy = new SimpleTextExtractionStrategy();

                string currPageText = PdfTextExtractor.GetTextFromPage(reader, page, strategy);

                pdfText.Append(currPageText);
            }

            logger.Info("PDF text:"+ pdfText.ToString());

            return pdfText.ToString();
        }

        /// <summary>
        /// Extract data from a particular page in the pdf document
        /// </summary>
        /// <param name="pdfFilePath">File path of the pdf document</param>
        /// <param name="pageNumber">Page number of the pdf document to extract</param>
        /// <returns>The text contene </returns>
        public static string ExtractPDFDataFromPage(string pdfFilePath, int pageNumber)
        {
            StringBuilder pdfText = new StringBuilder();

            PdfReader reader = new PdfReader(pdfFilePath);

            SimpleTextExtractionStrategy strategy = new SimpleTextExtractionStrategy();

            string currPageText = PdfTextExtractor.GetTextFromPage(reader, pageNumber, strategy);

            pdfText.Append(currPageText);

            logger.Info("PDF Page text:" + pdfText.ToString());

            return pdfText.ToString();
        }
    }
}
