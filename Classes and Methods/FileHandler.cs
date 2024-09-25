using System;
using System.IO;

public class FileHandler
{
    // Metode for å skrive data til filen
    public void WriteToFile(string filePath, string data)
    {
        try
        {
            // Skriver data til filen og erstatter innholdet
            File.WriteAllText(filePath, data);
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error has occured: {e.Message}");
        }
    }
    public void ReadFromFile(string filePath)
    {
        try
        {
            // Leser teksten fra filen
            string data = File.ReadAllText(filePath);
            Console.WriteLine("Innholdet i filen:");
            Console.WriteLine(data);
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error has occured: {e.Message}");
        }
    }
}
