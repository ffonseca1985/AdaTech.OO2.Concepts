using AbstractClass.Contracts;

namespace AbstractClass.Models
{
    public sealed class CsvReportGenerator : ReportGenerator
    {
        //Abstract Método
        protected override void GenerateHeader()
        {
            Console.WriteLine("Gerando cabeçalho CSV...");
        }

        //Abstract Método
        protected override void GenerateBody()
        {
            Console.WriteLine("Gerando corpo CSV...");
        }        
    }
}
