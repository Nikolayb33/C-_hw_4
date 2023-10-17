// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int num = new Random().Next(1000, 100000);

System.Console.WriteLine($"{num}");
int[] result = num.ToString().Select(o=> Convert.ToInt32(o) - 48 ).ToArray();

// System.Console.WriteLine($"{result[2]}");

int sum = 0;

for(int i = 0; i < result.Length; i++)
{
    sum += result[i];
}

System.Console.WriteLine($"{sum}");
