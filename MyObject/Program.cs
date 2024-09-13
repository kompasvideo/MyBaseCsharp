namespace MyObject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AnyObject anyObject = new();
            int hashCode = anyObject.GetHashCode();
            bool equals = anyObject.Equals(new object());
            string str = anyObject.ToString();
            Type type = anyObject.GetType();
            bool equalsStatic = AnyObject.Equals(anyObject, new AnyObject());
            bool referenceEquals = AnyObject.ReferenceEquals(anyObject, new object());
        }
    }
}