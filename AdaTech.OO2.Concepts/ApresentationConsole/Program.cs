using AbstractClass.Constracts;
using AbstractClass.Models;

namespace ApresentationConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportGenerator reportPdf = new PdfReportGenerator();
            reportPdf.Build();

            ReportGenerator reportcsv = new CsvReportGenerator();
            reportcsv.Build();

            Printer printer = new Printer();

            printer.Print(reportPdf);
            printer.Print(reportcsv);

            Console.WriteLine("Hello, World!");
        }
    }
}
