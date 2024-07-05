using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Game
{
    private string GenerateWord()
    {
        string filePath = "dictionary.txt";
        
        StreamReader streamReader = new StreamReader(filePath);
        Random random = new Random();
        
        int randomNumber = random.Next(Util.GetLines(filePath).Count());
        
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
        
        return null;
    }
    
    public void Start()
    {
        string generateWord = GenerateWord();
        
        List<char> mistakesList = new List<char>();
        List<char> result = new List<char>();
        for (int i = 0; i < generateWord.Length; i++)
        {
            result[i] = '_';
        }
        int counter = 1;
        while (mistakesList.Count <= 8)
        {
            string compareResult = result.ToString();
            if (compareResult == generateWord)
            {
                Console.WriteLine("\nВы выиграли!");
                break;
            }

            Console.WriteLine("\n\nПопытка №" + counter++);
            DesignGallow.Print(mistakesList.Count);
            if (mistakesList.Count == 7) 
            {
                Console.WriteLine($"\nВи проиграли, загадано слово {generateWord}");
                break;
            }
            Console.Write($"Буква: ");
            char answer = Convert.ToChar(Console.ReadLine());
            if (generateWord.Contains(answer))
            {
                CountLetters(generateWord, answer, result);

                Console.Write("Слово: ");
                foreach (char c in result)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            else if (!generateWord.Contains(answer))
            {
                Console.Write("Слово: ");
                foreach (char c in result)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                mistakesList.Add(answer);
            }

            Console.Write($"Ошибки: ({mistakesList.Count}) ");
            foreach (char c in mistakesList)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(c + ", ");
                Console.ResetColor();
            }

        }
    }
    
    public string CloseWord(string word)
    {
        string closeWord = "";
        for (int i = 0; i < word.Length; i++)
        {
            closeWord += "_";
        }
        return closeWord;
    }

    private void CountLetters(string word, char answer, List<char> result)
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
            for (int i = 0; i < result.Count; i++)
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

            for (int i = 0; i < result.Count; i++)
            {
                if (i == firstIndexEntrance || i == lastIndexEntrance)
                {
                    result[i] = answer;
                }
            }
        }
    }
}