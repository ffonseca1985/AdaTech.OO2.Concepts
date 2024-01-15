namespace DependencyInjector
{
    using System.Data.Common;
    using System.Data.SqlClient;

    namespace DependencyInjector
    {
        public class DataBaseContext
        {
            //Para ajustar isso, use uma interface
            SqlConnection connection { get; set; }

            void Connect(string connectionString)
            {
                connection = new SqlConnection(connectionString);
            }
        }

        public class Pedido
        {
            public Customer? Customer { get; set; }

            //Pedido tem uma dependencia de Customer
            public Customer CreateCustomer(string name, int age)
            {
                Customer = new Customer(name, age);
                return Customer;
            }
        }

        public class Customer
        {
            public Customer(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class Apresentation
        {
            public void Main()
            {
                string connectionString = "";
                //Temos acoplamento com a Bussiness
                CustomerBussiness bussiness = new CustomerBussiness(connectionString);
            }
        }
        public class CustomerBussiness
        {
            //a classe tem uma dependencia com a CustomerDao
            //Logo temos um grande acoplamento
            public CustomerDao _dao;
            public CustomerBussiness(string connectionString)
            {
                _dao = new CustomerDao(new SqlConnection(connectionString));
            }
        }
        public class CustomerDao
        {
            private DbConnection Connection;

            public CustomerDao(DbConnection connection)
            {
                Connection = connection;
            }

            public void SetConnection(DbConnection connection)
            {
                Connection = connection;
            }
        }
    }
}
