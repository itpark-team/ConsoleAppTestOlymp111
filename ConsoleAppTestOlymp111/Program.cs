using System;
using System.IO;

public class Program
{
    private static void Main()
    {
        StreamReader reader = new StreamReader("input.txt");
        StreamWriter writer = new StreamWriter("output.txt");

        string[] inputValues = reader.ReadLine().Split(' ');
        int n = int.Parse(inputValues[0]);
        int a = int.Parse(inputValues[1]);
        int b = int.Parse(inputValues[2]);

        int result = n * a * b * 2;

        writer.WriteLine(result);

        reader.Close();
        writer.Close();
    }
}