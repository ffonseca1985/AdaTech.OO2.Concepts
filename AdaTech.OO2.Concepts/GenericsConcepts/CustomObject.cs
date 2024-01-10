
namespace GenericsConcepts
{
    public class CustomObject<TKey, TValue>
    {
        public CustomObject(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public string ShowObject() {
            return $"Key {this.Key} and Value {this.Value}";
        }
    }
}
