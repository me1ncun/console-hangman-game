using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Начать новую игру или выйти? (Нажмите '1' для начала игры или '2' для выхода): ");

        int option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Game game = new Game();
            
            game.Start();
        }
        else if (option == 2)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine(new Exception("Выбрано неправильно, повторите попытку еще раз."));
        }
    }
}
