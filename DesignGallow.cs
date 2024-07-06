using System;
public class DesignGallow
{
    public void Print(int mistakes)
    {
        switch (mistakes)
        {
            default:
                Console.WriteLine("     " + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + "\n" +
    "         " + (char)124 + "\n" +
    "         " + (char)124 + "\n" +
    "         " + (char)124 + "\n" +
    "         " + (char)124 + "\n" +
    (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)124);
                break;
            case 1: case 2:
                Console.WriteLine("     " + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + "\n" +
    "    " + (char)79 + "    " + (char)124 + "\n" +
    "         " + (char)124 + "\n" +
    "         " + (char)124 + "\n" +
    "         " + (char)124 + "\n" +
    (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)124);

                break;
            case 3:
                Console.WriteLine("     " + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + "\n" +
    "    " + (char)79 + "    " + (char)124 + "\n" +
    "    " + (char)124 + "    " + (char)124 + "\n" +
    "    " + (char)124 + "    " + (char)124 + "\n" +
    "         " + (char)124 + "\n" +
    (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)124);

                break;
            case 4:
                Console.WriteLine("     " + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + "\n" +
    "    " + (char)79 + "    " + (char)124 + "\n" +
    "  " + (char)45 + (char)45 + (char)124 + "    " + (char)124 + "\n" +
    "    " + (char)124 + "    " + (char)124 + "\n" +
    "         " + (char)124 + "\n" +
    (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)124);

                break;
            case 5:
                Console.WriteLine("     " + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + "\n" +
    "    " + (char)79 + "    " + (char)124 + "\n" +
    "  " + (char)45 + (char)45 + (char)124 + (char)45 + (char)45 + "  " + (char)124 + "\n" +
    "    " + (char)124 + "    " + (char)124 + "\n" +
    "         " + (char)124 + "\n" +
    (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)124);

                break;
            case 6:
                Console.WriteLine("     " + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + "\n" +
    "    " + (char)79 + "    " + (char)124 + "\n" +
    "  " + (char)45 + (char)45 + (char)124 + (char)45 + (char)45 + "  " + (char)124 + "\n" +
    "    " + (char)124 + "    " + (char)124 + "\n" +
    "   " + (char)47 + "     " + (char)124 + "\n" +
    (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)124);

                break;
            case 7:
                Console.WriteLine("     " + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + "\n" +
    "    " + (char)79 + "    " + (char)124 + "\n" +
    "  " + (char)45 + (char)45 + (char)124 + (char)45 + (char)45 + "  " + (char)124 + "\n" +
    "    " + (char)124 + "    " + (char)124 + "\n" +
    "   " + (char)47 + " " + (char)92 + "   " + (char)124 + "\n" +
    (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)95 + (char)124);

                break;
        }
    }
}