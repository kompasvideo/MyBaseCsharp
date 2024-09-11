namespace MyObject;

public class AnyObject : Object
{
    public extern Type GetType();
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }

    protected unsafe object MemberwiseClone() {}

    // public object Clone()
    // {
    //     return this.MemberwiseClone();
    // }
}