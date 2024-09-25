using System;
using System.IO;
using System.Text.Json;

namespace JSONSerializer
{
    public class JsonHandler
    {
        // Metode for å skrive et object til en JSON fil
        public void WriteToJsonFile<T>(string filePath, T obj)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(obj);
                File.WriteAllText(filePath, jsonString);
                Console.WriteLine("Data be skrevet til json filen");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error has occured: {e.Message}");
            }
        }

        public T? ReadFromJsonFile<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found: {filePath}");
                return default; // Returner null hvis filen ikke finnes
            }

            try
            {
                string jsonString = File.ReadAllText(filePath);
                T? obj = JsonSerializer.Deserialize<T>(jsonString);
                Console.WriteLine("Innholdet i JSON-filen:");
                Console.WriteLine(jsonString);
                return obj;
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error has occured whilst reading from the JSON file: {e.Message}");
                return default; // Returner null hvis en feil oppstår
            }
        }
    }
}

