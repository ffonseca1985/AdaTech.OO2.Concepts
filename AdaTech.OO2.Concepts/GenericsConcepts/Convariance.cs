using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsConcepts
{
    public interface IAnimal { }
    public class Cat : IAnimal { }
    public class Dog : IAnimal { }

    //Por segurança eu tenho que falar para o generics que ele vai ser covariante
    public interface IReadableListAnimal<out T> where T : IAnimal
    {
        int Capacity { get; }
        T[] Elementos { get; }
    }

    public interface IWritableAnimal<in T> where T : IAnimal
    {
        bool Add(int posicao, T elemento);
    }

    //Por segurança eu tenho que falar para o generics que ele vai ser covariante
    public interface IReadableListAnimal<out T, in T2> where T : IAnimal
    {
        int Capacity { get; }
        T[] Elementos { get; }

        void GetTest(T2 t);
    }

    public interface IListAnimal<T> : IReadableListAnimal<T>, IWritableAnimal<T> where T : IAnimal { }

    public class ListAnimal<T> : IListAnimal<T> where T : IAnimal
    {
        public int Capacity => throw new NotImplementedException();

        public T[] Elementos => throw new NotImplementedException();

        public bool Add(int posicao, T elemento)
        {
            throw new NotImplementedException();
        }
    }
}
