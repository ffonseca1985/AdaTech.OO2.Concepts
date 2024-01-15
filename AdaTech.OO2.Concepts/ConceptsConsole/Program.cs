using AbstractClass.Contracts;
using AbstractClass.Models;
using DependencyInjector.DependencyInjector;
using GenericsConcepts;
using InterfaceConcepts.Contracts;
using InterfaceConcepts.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Security.Authentication.ExtendedProtection;

namespace ConceptsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DI();
            InterfaceConcepts();
            AbstractClass();
            GenericsVarianceAnContravariance();
        }

        public static void DI()
        {
            //O princípio da Inversão de Controle (IoC) tem por objetivo remover as
            //dependências (remover o acoplamento) entre os objetos de uma aplicação,
            //tornando-a mais desacoplada e manutenível

            //Tipo de Injecao:
            //- por metodo
            //- por construtor
            //- por parametros
            //- Service Locator => Classes que servem como localizadores
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<CustomerDao>((x) => new CustomerDao(new SqlConnection("")));

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var dao = serviceProvider.GetService<CustomerDao>();

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
            //Só posso fazer isso porque tem o "out" na assinatura da interface: IReadableListAnimal<out T>
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