using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string csvFilePath = "hebrewfile.csv";

        // Read CSV file
        string[] lines = File.ReadAllLines(csvFilePath, Encoding.UTF8);

        foreach (string line in lines)
        {
            string[] fields = line.Split(',');

            // Access individual fields
            string hebrewField = fields[0]; // Assuming Hebrew data is in the first field
            // Process or use the Hebrew field as needed
        }

        // Export data to CSV file
        string[] dataToExport = { "שלום, Hello", "עולם, World" };

        string exportFilePath = "path_to_export_csv_file.csv";

        File.WriteAllLines(exportFilePath, dataToExport, Encoding.UTF8);

        Console.WriteLine("CSV file operations completed successfully.");
    }
}
