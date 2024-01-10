using AbstractClass.Constracts;


namespace AbstractClass.Models
{
    public class Printer
    {
        public void Print(ReportGenerator reportGenerator)
        {
            reportGenerator.Build();
        }
    }
}
