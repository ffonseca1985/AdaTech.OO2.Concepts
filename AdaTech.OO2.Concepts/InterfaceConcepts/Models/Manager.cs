using InterfaceConcepts.Contracts;

namespace InterfaceConcepts.Models
{
    public class Manager : IEmployee
    {
        public Manager(string name, decimal salaryBase)
        {
            Name = name;
            SalaryBase = salaryBase;
        }

        public string Name { get; private set; }

        private decimal _salaryBase;
        public decimal SalaryBase
        {
            get
            {
                return _salaryBase;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary Base is Null");
                }

                _salaryBase = value;
            }
        }
        public decimal GetSalary()
        {
            return _salaryBase;
        }

        public void Work()
        {
            Console.WriteLine($"{this.Name} is managing the team");
        }
    }
}
