using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Game
{
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
        DesignGallow.Print(mistakes.Count);
        Console.WriteLine($"\nОшибки: {mistakes.Count}, Попытки: {String.Join(",", mistakes)}");
        Console.WriteLine($"Слово: {String.Concat(result)}");
        Console.Write("Введите букву: ");

        char letter = Convert.ToChar(Console.ReadLine());
        letter = CheckValidInput(letter);

        CheckIfLetterIsInWord(word, letter, result, mistakes);
    }
    
    private char CheckValidInput(char letter)
    {
        if (!char.IsLetter(letter))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите одну букву: ");
        }

        if (Char.IsUpper(letter))
        {
            Console.WriteLine("Пожалуйста, введите букву в нижнем регистре: ");
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
        
        Util.CheckIfFileExists(filePath);
        
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

    private void CheckIfLetterIsInWord(string word, char letter, List<char> result, List<char> mistakes)
    {
        if (word.Contains(letter))
        {
            OpenLetter(word, letter, result);
        }
        else
        {
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