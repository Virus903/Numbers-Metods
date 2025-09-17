using System;

public class Example
{
    private static int n;

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива:");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = new int[size];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Введите элемент массива № {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nЭлементы массива:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }

        Console.WriteLine("\nвведите колличество первых элементов массива");
        int n = int.Parse(Console.ReadLine());

        int sum = numbers.Take(n).Sum();

        Console.WriteLine($"Сумма первых {n} элементов: {sum}");
    }
}