using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineFreightManager.Common
{
    // Logic to read orders from JSON file using path
    internal class JsonFileReader
    {
        string currentDirectory = "";
        public JsonFileReader()
        {
            if (Directory.GetCurrentDirectory().EndsWith("\\bin\\Debug"))
            {
                currentDirectory = Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "");
            }
            else
            {
                currentDirectory = Directory.GetCurrentDirectory();
            }
        }
        public string ReadFile(string filePath)
        {
            try
            {
                // Logic to read orders from JSON file using path
                string json = "";
                using (StreamReader reader = File.OpenText(Path.Combine(currentDirectory, filePath)))
                {
                    json = reader.ReadToEnd();
                }
                return json;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to open file: {filePath} \nError Message: {ex.Message}");
                return "";
            }
        }
    }
}
