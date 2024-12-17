using System;
using System.Text.Json;

namespace HomeworkJson1.Utils
{
    public static class JsonHelper
    {
        public static void WriteToFile<T>(string filePath, List<T> items)
        {
            string jsonString = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
        }

        public static List<T> ReadFromFile<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<T>>(jsonString);
            }
            return new List<T>();
        }
    }
}
