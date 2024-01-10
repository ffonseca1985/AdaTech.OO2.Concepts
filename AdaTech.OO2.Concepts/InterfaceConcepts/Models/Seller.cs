using InterfaceConcepts.Contracts;

namespace InterfaceConcepts.Models
{
    public class Seller : IEmployee
    {
        public Seller(string name, decimal salaryBase)
        {
            Name = name;
            SalaryBase = salaryBase;
        }

        public string Name { get; private set; }
        public decimal Commission { get; private set; }
        public decimal SalaryBase { get; private set; }

        public void AddCommission(decimal commission)
        {
            if (commission < 0)
            {
                throw new ArgumentException("Commission is invalid");
            }

            this.Commission = commission;
        }

        public decimal GetSalary()
        {
            return SalaryBase + this.Commission;
        }

        public void Work()
        {
            Console.WriteLine($"{this.Name} is selling");
        }
    }
}
