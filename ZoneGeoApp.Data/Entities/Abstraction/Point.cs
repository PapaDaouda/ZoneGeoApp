namespace ZoneGeoApp.Data.Entities.Abstraction;

public class Point
{
    private float abs;
    private float ord;
    public Point(float X, float Y)
    {
        abs = X;
        ord = Y;
    }

    public override string ToString()
    {
        return $"[{abs}, {ord}]";
    }

}
