using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DependencyInjector
{
    //Separation of concern
    public interface Dao { void Execute(); }
    public class AccountDao : Dao
    {
        //A classe AccountDao Tem a responsabilidade de dar o new no SqlConnection ou no MySqlConnection
        //A classe AccountDao também tem a responsabilidade de dar o new em  dbWithSQL e dbWithMySQL
        private DbConnection _connection;
        private ILogAda _log;

        public AccountDao(DbConnection connection, ILogAda log)
        {
            _connection = connection;
            _log = log;
        }

        public void Execute()
        {
            DataBase2 dbWithSQL = new DataBase2(_connection, _log);
            //DataBase2 dbWithMySQL = new DataBase2(new MySqlConnection(""), new LogAdaBasic());
        }
    }

    public interface ILogAda {
        void Debug(string text);
        void Trace(string text);
    }

    public class LogAdaFull : ILogAda
    {
        public void Debug(string text)
        {
            throw new NotImplementedException();
        }

        public void Trace(string text)
        {
            throw new NotImplementedException();
        }
    }
    public class LogAdaBasic : ILogAda
    {
        public void Debug(string text)
        {
            throw new NotImplementedException();
        }

        public void Trace(string text)
        {
            throw new NotImplementedException();
        }
    }

    public class DataBase
    {
        private SqlConnection _connection;

        public DataBase(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }
    }

    public class DataBase2
    {
        //Troquei por uma abstração => DbConnection
        private DbConnection _connection;
        private ILogAda _log;

        public DataBase2(DbConnection connection, ILogAda log)
        {
            _connection = connection;
            _log = log;
        }
    }
}
