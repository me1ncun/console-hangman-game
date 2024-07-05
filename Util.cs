using System.Collections.Generic;
using System.IO;

public static class Util
{
    public static IEnumerable<string> GetLines(string yourtextfile)
    {
        TextReader reader = new StreamReader(yourtextfile);
        string line;
        
        while ((line = reader.ReadLine()) != null)
        {
            yield return line;
        }
        reader.Close();
    }
}