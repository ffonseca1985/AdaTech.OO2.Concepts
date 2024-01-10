using AbstractClass.Constracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Models
{
    public class CsvReportGenerator : ReportGenerator
    {
        protected override void GenerateBody()
        {
            Console.WriteLine("CSV => Body");
        }

        protected override void GenerateHeader()
        {
            Console.WriteLine("CSV => Header");
        }
    }
}
