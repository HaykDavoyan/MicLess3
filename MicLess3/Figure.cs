using System.Drawing;

namespace MicLess3.Figures;

public abstract class Figure
{
    public string name { get; set; }
    public Color color { get; set; }

    public Figure(string name, Color color)
    {
        this.name = name;
        this.color = color;
    }
}