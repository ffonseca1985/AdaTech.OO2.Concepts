
namespace InterfaceConcepts.Contracts
{
    public interface IEmployee
    {
        string Name { get; }
        decimal SalaryBase { get; }
        decimal GetSalary();
        void Work();
    }
}
