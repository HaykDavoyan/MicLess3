namespace MicLess3
{
    public struct Coordinate
    {
        public char column { get; set; }
        public int row { get; set; }

        public Coordinate(char column, int row)
        {
            this.column = char.ToUpper(column);
            this.row = row;
        }

        public static Coordinate ParseCoordinate(string input)
        {
            char column = input[0];
            int row = int.Parse(input.Substring(1));
            return new Coordinate(column, row);
        }
    }
}
