namespace project;

public class Game
{
    private string GenerateWord()
    {
        string filePath = "dictionary.txt";
        StreamReader streamReader = new StreamReader(filePath);
        Random random = new Random();
        int randomNumber = random.Next(Dictionary.CalculateLength());
        string line;
        var counter = 0;
        while ((line = streamReader.ReadLine()) != null)
        {
            counter++;
            if (counter == randomNumber)
            {
                return line;
            }
        }
        return "none";
    }
    public void Start()
    {
        string word = GenerateWord();
        Console.WriteLine(word);
        List<char> mistakes = new List<char>();
        char[] result = new char[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            result[i] = '_';
        }
        int counter = 1;
        while (mistakes.Count <= 8)
        {
            
            string compareResult = new string(result);
            if (compareResult == word)
            {
                Console.WriteLine("\nВи виграли! Мої вітання!");
                break;
            }

            Console.WriteLine("\n\nСпроба №" + counter++);
            DesignGallow.Print(mistakes.Count);
            if (mistakes.Count == 7) 
            {
                Console.WriteLine($"\nВи програли, загадане слово {word}");
                break;
            }
            Console.Write($"Буква: ");
            char answer = Convert.ToChar(Console.ReadLine());
            if (word.Contains(answer))
            {
                CountLetters(word, answer, result);

                Console.Write("Слово: ");
                foreach (char c in result)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            else if (!word.Contains(answer))
            {
                Console.Write("Слово: ");
                foreach (char c in result)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                mistakes.Add(answer);
            }

            Console.Write($"Помилки: ({mistakes.Count}) ");
            foreach (char c in mistakes)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(c + ", ");
                Console.ResetColor();
            }

        }
    }

    private void CountLetters(string word, char answer, char[] result)
    {
        int counter = 0;
        foreach (char c in word)
        {
            if(c == answer)
            {
                counter++;
            }
        }
        if(counter == 1) 
        {
            int indexEntrance = word.IndexOf(answer);
            for (int i = 0; i < result.Length; i++)
            {
                if (i == indexEntrance)
                {
                    result[i] = answer;
                }
            }
        }
        if(counter == 2)
        {
            int firstIndexEntrance = word.IndexOf(answer);
            int lastIndexEntrance = word.LastIndexOf(answer);

            for (int i = 0; i < result.Length; i++)
            {
                if (i == firstIndexEntrance || i == lastIndexEntrance)
                {
                    result[i] = answer;
                }
            }
        }
    }
}