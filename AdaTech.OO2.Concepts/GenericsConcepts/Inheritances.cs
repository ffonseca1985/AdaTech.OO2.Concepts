

namespace GenericsConcepts
{
    public abstract class BaseClass<TKey>
    {
        public TKey ID { get; set; }
    }  

    public class DaughterClass : BaseClass<string>
    {

    }

}
