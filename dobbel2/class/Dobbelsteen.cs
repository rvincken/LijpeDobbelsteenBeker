namespace dobbel2;

class Dobbelsteen
{
    public string Color;
    public string Shape;
    public List<int> Sides;

    public Dobbelsteen(string color, string shape, List<int> sides)
    {
        Color = color;
        Shape = shape;
        Sides = sides;
    }

    public virtual int Dobbel()
    {
        Random rnd = new Random();
        return rnd.Next(Sides.Min(), Sides.Max() + 1);
    }
}
