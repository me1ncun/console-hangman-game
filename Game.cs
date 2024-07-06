using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Game
{
    private readonly Util _util;
    private readonly DesignGallow _design;
    
    public Game()
    {
        _util = new Util();
        _design = new DesignGallow();
    }
    
    public void Start()
    {
        string word = GenerateWord();
        
        List<char> mistakes = new List<char>();
        List<char> result = CloseWord(word).ToCharArray().ToList();
        
        Console.WriteLine(word + "\n" + String.Concat(result));
        
        while (mistakes.Count <= 7)
        {
            Printer(mistakes, result, word);
            if (CheckWinner(word, result))
            {
                Console.WriteLine("Вы выиграли!");
                return;
            }
        }

        Console.WriteLine($"Вы проиграли, загадано слово: {word}");
    }
    
    private string CloseWord(string word)
    {
        return new string('*', word.Length);
    }
    
    private void Printer(List<char> mistakes, List<char> result, string word)
    {
        _design.Print(mistakes.Count);
        Console.WriteLine($"\nОшибки: {mistakes.Count}, Попытки: {String.Join(",", mistakes)}");
        Console.WriteLine($"Слово: {String.Concat(result)}");
        Console.WriteLine("Введите букву: ");

        var letter = CheckLetter();
        
        CheckIfLetterIsInWord(word, letter, result, mistakes);
    }
    
    private char CheckLetter()
    {
        var input = Console.ReadLine();
        
        var parsed = Char.TryParse(input, out var letter);
        if(!parsed)
        {
            Console.WriteLine("Некорректный ввод, введите букву еще раз");
            return CheckLetter();
        }

        if (char.IsUpper(letter))
        {
            Console.WriteLine("Валидными считаются только маленькие буквы, введите букву еще раз");
            return CheckLetter();
        }
        
        return letter;
    }
    
    private void OpenLetter(string word, char letter, List<char> result)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == letter)
            {
                result[i] = letter;
            }
        }
    }
    
    private string GenerateWord()
    {
        string filePath = "dictionary.txt";
        
        _util.CheckIfFileExists(filePath);
        
        StreamReader streamReader = new StreamReader(filePath);
        Random random = new Random();
        
        int randomNumber = random.Next(_util.GetLines(filePath).Count());
        
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

    private void CheckIfLetterIsInWord(string word, char letter, List<char> result, List<char> mistakes)
    {
        if (word.Contains(letter))
        {
            OpenLetter(word, letter, result);
        }
        else
        {
            if(mistakes.Contains(letter))
            {
                Console.WriteLine("Вы уже вводили эту букву");
                return;
            }
            
            AddMistake(mistakes, letter);
        }
    }
    
    private void AddMistake(List<char> mistakes, char letter)
    {
        mistakes.Add(letter);
    }
    
    private bool CheckWinner(string word, List<char> result)
    {
        return word == String.Concat(result);
    }
}