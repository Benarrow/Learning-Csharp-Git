using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace files_module
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store current directory
            var currentDirectory = Directory.GetCurrentDirectory();
            
            // Enter the ../stores directory
            var storesDirectory = Path.Combine(currentDirectory, "stores");
            
            // Create new directory under current directory & store its path
            var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
            Directory.CreateDirectory(salesTotalDir);

            // Store the files meeting the requirements (selected by FindFiles())
            var salesFiles = FindFiles(storesDirectory);

            // Store the sum of the values inside .json files selected above
            var salesTotal = CalculateSalesTotal(salesFiles);
            
            // Write the sum into a new file with required conditions
            File.AppendAllText(Path.Combine(salesTotalDir, "emisto.txt"), $"{salesTotal}{Environment.NewLine}");

            if (File.Exists(Path.Combine(salesTotalDir, "totals.txt")))
            {
                Console.WriteLine("Update successfully.");
            }
            else 
            {
                Console.WriteLine("Creation failed.");
            }

            // foreach (var file in salesFiles)
            // {
            //     Console.WriteLine(file);
            // }
        }
        static IEnumerable<string> FindFiles(string folderName)
        {
            List<string> salesFiles = new List<string>();

            var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

            foreach (var file in foundFiles)
            {
                var extension = Path.GetExtension(file);
                // The file name will contain the full path, so only check the end of it.
                if (extension == ".json")
                {
                    salesFiles.Add(file);
                }
            }

            return salesFiles;
        }
        class SalesData
        {
            // Get & set the visited value
            public double Total { get; set; }
        }
        static double CalculateSalesTotal(IEnumerable<string> salesFiles)
        {
            double salesTotal = 0;

            // Loop over each file path in salesFiles
            foreach (var file in salesFiles)
            {
                // Read the contents of the file
                string salesJson = File.ReadAllText(file);

                // Parse the contents as JSON. Use get & set to initialize $data
                SalesData data = JsonConvert.DeserializeObject<SalesData>(salesJson);

                // Add the amount found in the Total field to the salesTotal variable
                salesTotal += data.Total;
            }

            return salesTotal;
        }
    }
}
