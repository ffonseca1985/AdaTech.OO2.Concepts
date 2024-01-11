using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConcepts
{
    public class CompareHelper
    {
        //Estou passando tipo via parametro
        //Quando passo o tipo por parametro, estou usando o conceito de Generics
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }

            return false;
        }

        public bool Compare<T1, T2>(T1 a, T2 b)
        {
            if (a.Equals(b))
            {
                return true;
            }

            return false;
        }

        //public bool Compare(int a, int b)
        //{
        //    if (a.Equals(b))
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //public bool Compare(float a, float b)
        //{
        //    if (a.Equals(b))
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //public bool Compare(object a, object b)
        //{
        //    if (a.Equals(b))
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //Não dá para usar o operador "+"
        //public void SomarDecimal<T1, T2>(T1 a, T2 b)  
        //{
        //    var c = a + b;
        //    return a + b;
        //}

        //Problemas: 
        //1 - unbox
        //2 - não seguro
        //public bool SomarDecimal(object a, object b)
        //{
        //    decimal parseA = (decimal)a; //unbox
        //    decimal parseB = (decimal)b;

        //    return false;
        //}

    }
}
