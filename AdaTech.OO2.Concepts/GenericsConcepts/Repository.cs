
namespace GenericsConcepts
{
    public class Repository<T, TKey> where T : BaseClass<TKey>
    {
        private List<T> _dataBase;

        public Repository() {
            _dataBase = new List<T>();
        }

        public void Add(T item)
        {
            _dataBase.Add(item);
        }

        public T? Get(TKey id) {

            var search = _dataBase.FirstOrDefault(x => Equals(x.ID, id));
            return search;
        }

        public List<T> Get() { 
            return _dataBase;
        }
    }
}
