using AbstractClass.Contracts;
using AbstractClass.Models;
using GenericsConcepts;
using InterfaceConcepts.Contracts;
using InterfaceConcepts.Models;

namespace ConceptsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfaceConcepts();
            AbstractClass();
            GenericsVarianceAnContravariance();
        }

        public static void InterfaceConcepts()
        {
            IEmployee manager = new Manager("Joao", 12000);
            IEmployee seller = new Seller("Pedro", 34000);
        }

        public static void AbstractClass()
        {
            ReportGenerator pdfReportGenerator = new PdfReportGenerator();
            pdfReportGenerator.GenerateReport();
        }

        public static void GenericsVarianceAnContravariance()
        {
            //COVARIANCE

            var listCat = new ListAnimal<Cat>(2);
            listCat.Add(0, new Cat() { Name = "Gato1" });
            listCat.Add(1, new Cat() { Name = "Gato2" });

            //A covariância em C# é uma característica que permite que tipos genéricos sejam mais flexíveis em relação à hierarquia de tipos. Especificamente, 
            //a covariância permite que um tipo seja tratado como seu tipo base. Isso é particularmente útil em situações em que você está lidando com tipos de retorno, 
            //como em coleções ou delegados. A covariância em C# é indicada pela palavra-chave out.

            //É importante destacar que, embora a covariância forneça flexibilidade, ela também impõe algumas restrições para garantir a segurança de tipo.
            //Se a covariância fosse aplicada indiscriminadamente, isso poderia resultar em comportamento indefinido ou falhas de tempo de execução devido a incompatibilidades de tipos.

            //Em resumo, a covariância é uma característica projetada para tornar o código mais expressivo e flexível.

            IReadableListAnimal<Animal> animais = listCat;

            IEnumerable<Animal> animal = new List<Cat>();

            //CONTRAVARIANCE
            //Nota: é o contrario da Covariancia
            IComparer<Circle> comparer = new ShapeAreaComparer<Shape>();
            SortedSet<Circle> circlesByArea = new SortedSet<Circle>(comparer) { new Circle(7.2), new Circle(100), null, new Circle(.01) };

            foreach (Circle c in circlesByArea)
            {
                Console.WriteLine(c == null ? "null" : "Circle with area " + c.Area);
            }
        }

        //NOTE:
        //OUT Saída e IN Entrada
    }
}