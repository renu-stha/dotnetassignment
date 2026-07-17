using System;
class Program
{
    static void Main()
    {
        int[][] m = { new[] { 80, 90, 85 }, new[] { 75, 88 }, new[] { 92, 95, 89, 100 } };
        for (int i = 0; i < m.Length; i++)
        {
            Console.Write($"Student {i + 1}: ");
            foreach (var x in m[i]) Console.Write(x + " "); Console.WriteLine();
        }
    }
}