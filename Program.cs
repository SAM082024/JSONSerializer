using System;
using System.IO;

namespace JSONSerializer
{
    class Program
    {
        static void Main()
        {
            FileHandler fileHandler = new FileHandler();
            string filePath = "text.txt";

            // Skriv data til fil
            fileHandler.WriteToFile(filePath, "Testing.");

            // Lese data fra fil
            fileHandler.ReadFromFile(filePath);

            // Håndtering av json filer
            JsonHandler jsonHandler = new JsonHandler();
            string jsonFilePath = "person-data.json";

            // Oppretter et objekt som lagres i json filen
            Person person = new Person { Name = "John Doe", Age = 32 };

            // Skrive objektet til json fil
            jsonHandler.WriteToJsonFile(jsonFilePath, person);

            // Lese json data fra filen
            Person? readPerson = jsonHandler.ReadFromJsonFile<Person>(jsonFilePath);
            if (readPerson == null)
            {
                Console.WriteLine("Couldn't read person.");
            }
            else
            {
                Console.WriteLine($"Name: {readPerson.Name}, Age: {readPerson.Age}");
            }
        }
    }
}
