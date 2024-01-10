using AbstractClass.Constracts;

namespace AbstractClass.Models
{
    public class PdfReportGenerator : ReportGenerator
    {
        public override void Build()
        {
            base.Build();
            GenerateFooter();
        }

        private void GenerateFooter()
        {
            Console.WriteLine("PDF => Footer");
        }

        protected override void GenerateBody()
        {
            Console.WriteLine("PDF => Body");
        }

        protected override void GenerateHeader()
        {
            Console.WriteLine("PDF => Header");
        }
    }
}
