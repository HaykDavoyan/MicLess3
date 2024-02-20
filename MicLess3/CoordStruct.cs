namespace MicLess3
{
    public struct Coordinate
    {
        private int v1;
        private int v2;

        public char column { get; set; }
        public int row { get; set; }

        public Coordinate(char column, int row)
        {
            this.column = char.ToUpper(column);
            this.row = row;
        }

        public Coordinate(int v1, int v2) : this()
        {
            this.v1 = v1;
            this.v2 = v2;
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
}
