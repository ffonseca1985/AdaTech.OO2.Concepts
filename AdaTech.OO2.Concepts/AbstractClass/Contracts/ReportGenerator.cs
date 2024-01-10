
namespace AbstractClass.Contracts
{
    public abstract class ReportGenerator
    {
        //public virtual void GenerateReport()
        public virtual void GenerateReport()
        {
            Console.WriteLine("Iniciando a geração do relatório...");
            GenerateHeader();
            GenerateBody();
            Console.WriteLine("Relatório gerado com sucesso!");
        }

        // Métodos abstratos que devem ser implementados pelas subclasses
        protected abstract void GenerateHeader();
        protected abstract void GenerateBody();
    }
}
