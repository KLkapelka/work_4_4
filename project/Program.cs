// Дан файл numsTask4.txt с целыми числами, расположенными через пробел.
// Определите количество одинаковых рядом стоящих чисел;


using System;
using System.IO;
class work_4_4
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask4.txt"); 
        int[] numbers = lines[0].Split(' ').Select(int.Parse).ToArray(); 
        int sum = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i - 1] == numbers[i])
            {
                sum ++;
            }
        }
        Console.WriteLine($"Одинаковых рядом стоящих чисел: {sum}");
    }
}  
