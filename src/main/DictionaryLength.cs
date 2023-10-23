namespace project;

public static class Dictionary
{
    public static int CalculateLength()
    {
        string filePath = "dictionary.txt";
        StreamReader streamReader = new StreamReader(filePath);
        string line;
        var counter = 0;
        while ((streamReader.ReadLine()) != null)
        {
            counter++;
        }
        return counter;
    }
}