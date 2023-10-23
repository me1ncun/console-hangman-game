using project;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Почати нову гру або вийти з програми? (Введіть 'Start' чи 'Exit'): ");

        string option = Console.ReadLine();

        if (option.ToLower() == "start")
        {
            Game game = new Game();

            game.Start();

        }
        else if (option.ToLower() == "exit")
        {
            Environment.Exit(0);
        }
        else
        {
            throw new Exception("Введено неправильно, повторіть спробу");
        }
    }
}
