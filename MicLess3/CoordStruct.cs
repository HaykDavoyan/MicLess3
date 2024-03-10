namespace MicLess3;

public struct Coordinate
{
    public char column { get; set; }
    public int row { get; set; }

    public Coordinate(char column, int row)
    {
        this.column = char.ToUpper(column);
        this.row = row;
    }

    public Coordinate(int v1, int v2) : this()
    {
        this.column = (char)(v1 + 'A' - 1);
        this.row = v2;
    }

    public static Coordinate ParseCoordinate(string input)
    {
        char column = input[0];
        int row = int.Parse(input.Substring(1));
        return new Coordinate(column, row);
    }

    public bool IsValid()
    {
        return row >= 1 && row <= 8 && column >= 'A' && column <= 'H';
    }
}
