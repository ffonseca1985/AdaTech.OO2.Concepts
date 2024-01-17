using AbstractClass.Constracts;
using AbstractClass.Models;
using DependencyInjector;
using GenericsConcepts;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Common;
using System.Data.SqlClient;

namespace ApresentationConsole
{
    using Solid.InterfaceSegregationPrinciple;
    internal class Program
    {
        static void Main(string[] args)
        {
            RelatorioRH relatorioRH = new RelatorioRH();

            //Covariance
            IFuncionario funcionario = new Gerente();

            //Em generics List não é covariante, embora o objeto seja.
            List<ISubordinado> subordinado = new List<ISubordinado>()
            {
                new Gerente(),
                new Vendedor()
            };

            relatorioRH.ListarSuperior(subordinado);
        }

        static void ClientServiceLocator()
        {
            //DAO => Data Access Object => a classe
            //DAL => Data access Layer => a camada /projeto
            //Agora quem tem a reposabilidade de dar new é o método main da classe program
            var resolveSQL = new SqlConnection("");
            var resolveLog = new LogAdaFull();

            //Aqui estou dando new nas dependencias
            var accountDao = new AccountDao(resolveSQL, resolveLog);

            var provider = BuildServiceLocator();

            //Aqui o service locator esta resolvendo a dependencia pra mim
            var instance = provider.GetService<Dao>();

            instance.Execute();

            //Para resolver isso vamos usar um padrão chamado serviceLocator que irá resolver pra mim as dependencias de acccountDao
            //Vamos usar o container do .netcore.

            Console.WriteLine("Hello, World!");
        }

        //Mapeamento
        static ServiceProvider BuildServiceLocator()
        {
            var serviceCollection = new ServiceCollection();

            //Nota:
            //Esta assim porque eu quis definir como seria a implementacao
            serviceCollection.AddSingleton<DbConnection, SqlConnection>();

            //Aqui eu estou deixando o service Collection resolver 
            serviceCollection.AddSingleton<ILogAda, LogAdaFull>();
            serviceCollection.AddSingleton<Dao, AccountDao>();

            var provider = serviceCollection.BuildServiceProvider();
            return provider;
        }

        static void Generics() {

            IList<object> listObj = new List<object>();
            listObj.Add(12);

            IList<string> listStr = new List<string>();
            listStr.Add("qqq");

            //listObj = listStr;

            IEnumerable<IAnimal> aniaml = new List<IAnimal>();

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
