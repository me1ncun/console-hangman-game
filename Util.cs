using System.Collections.Generic;
using System.IO;

public class Util
{
    public IEnumerable<string> GetLines(string yourtextfile)
    {
        TextReader reader = new StreamReader(yourtextfile);
        string line;
        
        while ((line = reader.ReadLine()) != null)
        {
            yield return line;
        }
        
        reader.Close();
    }
    
    public void CheckIfFileExists(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("File not found");
        }
        if(GetLines(filePath) == null)
        {
            throw new FileLoadException("File is empty");
        }
    }
}