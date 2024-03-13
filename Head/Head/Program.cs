using System;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        string filename = null;

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "-n" && i + 1 < args.Length)
            {
                if (int.TryParse(args[i + 1], out int num))
                {
                    n = num;
                }
            }
            else
            {
                filename = args[i];
            }
        }


        if (filename == null)
        {
            // Read from standard input
            ReadFromStandardInput(n);
        }
        else
        {
            // Read from file
            //string filename = args.Length > 0 ? args[0] : null;
            ReadFromFile(filename, n);
        }
    }

    static void ReadFromFile(string filename, int n)
    {
        //string path = @"C:\Users\David\source\repos\Coding-Challenges\Head\Head\" + filename;
        try
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                int count = 0;
                while ((line = sr.ReadLine()) != null && count < n)
                {
                    Console.WriteLine(line);
                    count++;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error reading file: " + e.Message);
        }


    }

    static void ReadFromStandardInput(int n)
    {
        string line;
        int count = 0;
        while ((line = Console.ReadLine()) != null && count < n)
        {          
            Console.WriteLine(line);
            count++;
        }
    }
}
