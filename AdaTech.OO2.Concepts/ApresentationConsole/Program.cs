using AbstractClass.Constracts;
using AbstractClass.Models;
using GenericsConcepts;
using System.Collections.Generic;

namespace ApresentationConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IListAnimal<Cat> listCats = new ListAnimal<Cat>();
            IReadableListAnimal<IAnimal> animais = listCats;

            List<Cat> animal = new List<Cat>();

            IReadableListAnimal<IAnimal> dog = (IListAnimal<Cat>)animal;

            int val1 = 1;
            int val2 = 2;

            float val3 = 1;
            float val4 = 2;

            string val5 = "1";
            string val6 = "b";

            CompareHelper helper = new CompareHelper();

            Console.WriteLine(helper.Compare<int>(val1, val2));
            Console.WriteLine(helper.Compare<float>(val1, val4));
            Console.WriteLine(helper.Compare<int, float>(val1, val4));
            Console.WriteLine(helper.Compare<string, float>(val5, val4));

            Console.WriteLine("Hello, World!");
        }


        static void AbstractClass()
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
