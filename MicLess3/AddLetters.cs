namespace MicLess3;

class AddLetters
{ /// <summary>
  /// Add letters on the board
  /// </summary>
   public  void AddLettersOnTheBoard()
    {
        Console.Write("");
        for (char num = 'A'; num <= 'H'; num++)
        {
            Console.Write(" " + num + "");
        }
        Console.WriteLine();
    }
}
