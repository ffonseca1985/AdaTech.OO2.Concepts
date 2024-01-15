using AbstractClass.Constracts;
using AbstractClass.Models;
using GenericsConcepts;

namespace ApresentationConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<object> listObj = new List<object>();
            listObj.Add(12);

            IList<string> listStr = new List<string>();
            listStr.Add("qqq");

            //listObj = listStr;

            IEnumerable<IAnimal> aniaml = new List<IAnimal>();
            
            Console.WriteLine("Hello, World!");
        }

        static void Generics() {

            //Contravariance
            IWritableAnimal<Cat> cat = new ListAnimal<IAnimal>();
                        
            //Covariance
            IReadableListAnimal<Cat> listCats = new ListAnimal<Cat>();
            IReadableListAnimal<IAnimal> animais = listCats;

            List<Cat> animais2 = new List<Cat>();

            IReadableListAnimal<Cat> dog = (IListAnimal<Cat>)animais2;

            int val1 = 1;
            int val2 = 2;

            float val3 = 1;
            float val4 = 2;

            string val5 = "1";
            string val6 = "b";

            CompareHelper helper = new CompareHelper();

            Console.WriteLine(helper.Compare<int>(val1, val2));
            Console.WriteLine(helper.Compare<float>(val1, val3));
            Console.WriteLine(helper.Compare<int, float>(val1, val4));
            Console.WriteLine(helper.Compare<string, float>(val5, val4));
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
