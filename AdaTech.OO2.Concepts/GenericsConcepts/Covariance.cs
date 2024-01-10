
namespace GenericsConcepts
{
    public abstract class Animal
    {
        public string Name { get; set; }
    }

    public class Cat : Animal {
    
        public string GetSound()
        {
            return "Mial";
        }
    }

    public class DOG : Animal
    {
        public string GetSound()
        {
            return "AuAu";
        }
    }

    public interface IReadableListAnimal<out T> where T : Animal
    {
        int Capacity { get; }
        T[] Elementos { get; }
    }

    public interface IWritableAnimal<T> where T : Animal
    {
        bool Add(int posicao, T elemento);
    }

    public interface IListAnimal<T> : IReadableListAnimal<T>, IWritableAnimal<T> where T : Animal { }

    public class ListAnimal<T> : IListAnimal<T> where T : Animal {

        public ListAnimal(int capacity)
        {
            this.Capacity = capacity;     
        }

        public ListAnimal(T[] elementos)
        {
            this.Capacity = elementos.Length; 
            this.Elementos = elementos;
        }

        public int Capacity { get; }
        public T[] Elementos { get; }

        public T this[int index]
        {
            get { return Elementos[index]; }
            set { Elementos[index] = value; }
        }

        public bool Add(int posicao, T elemento)
        {
            if (posicao >= 0 && posicao < this.Capacity)
            {
                Elementos[posicao] = elemento;
                return true;
            }
            return false;
        }
    }

    public static class AnimalExtension
    {
        public static IListAnimal<T> ToListAnimal<T>(this IReadableListAnimal<T> list) where T : Animal
        {
            ListAnimal<T> newList = list as ListAnimal<T>;
            return newList;
        }
    }
}
