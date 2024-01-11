
using System.Data;

namespace GenericsConcepts
{
    //DRY -> Don't repeat yourself
    //Exemplo: Repositorio Generico
    public class Repository<T> where T : IEntity
    {
        private List<T> _itens;
        public Repository()
        {
            _itens = new List<T>();
        }

        public void Insert(T obj)
        {
            _itens.Add(obj);
        }

        public IEnumerable<T> Get(Func<T, bool> func)
        {
            return _itens.Where(func);
        }

        public List<T> GetAll()
        {
            return _itens;
        }

        public T GetById(string id)
        {

            var search = _itens.FirstOrDefault(x => x.Id == id);
            return search;
        }
    }
}
