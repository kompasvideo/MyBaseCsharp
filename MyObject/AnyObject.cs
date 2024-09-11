namespace MyObject;

public class AnyObject : Object
{
    public extern Type GetType();
    //protected unsafe object MemberwiseClone() {}

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}