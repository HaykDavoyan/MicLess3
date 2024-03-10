using System.Drawing;

namespace MicLess3.Figures;

public abstract class Figure
{
    public string Name { get; set; }
    public Color Color { get; set; }

    public Figure(string name, Color color)
    {
        Name = name;
        Color = color;
    }

    public abstract bool CheckMove(Coordinate currentCoordinate, Coordinate newCoordinate);
}