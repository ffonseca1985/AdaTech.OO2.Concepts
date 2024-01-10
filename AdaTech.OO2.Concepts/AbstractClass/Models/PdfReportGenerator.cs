using AbstractClass.Contracts;

namespace AbstractClass.Models
{
    //sealed => não pode ser herdada
    public sealed class PdfReportGenerator : ReportGenerator
    {
        protected override void GenerateHeader()
        {
            Console.WriteLine("Gerando cabeçalho PDF...");
        }

        protected override void GenerateBody()
        {
            Console.WriteLine("Gerando corpo PDF...");
        }

        //Abstract Método
        private void GenerateFooter()
        {
            Console.WriteLine("Gerando rodapé CSV...");
        }

        //Virtual Método
        public override void GenerateReport()
        {
            Console.WriteLine("<<<<<<<<<<<<< INICIO >>>>>>>>>>>>>>>>>");
            GenerateHeader();
            GenerateBody();
            GenerateFooter();
            Console.WriteLine("<<<<<<<<<<<<< FIM >>>>>>>>>>>>>>>>>");
        }
    }
}
