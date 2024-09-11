namespace MyObject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AnyObject anyObject = new();
            int hashCode = anyObject.GetHashCode();
            bool equals = anyObject.Equals(new object());
            Type type = anyObject.GetType();
            string str = anyObject.ToString();
            bool equalsStatic = AnyObject.Equals(anyObject, new AnyObject());
            bool referenceEquals = AnyObject.ReferenceEquals(anyObject, new object());
        }
    }
}