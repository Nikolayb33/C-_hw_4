// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] array = new int[8];

// если функци ничего не возвращает , то надо использовать void (заглушка)

void GetArray()
{
    System.Console.WriteLine("[");
    for(int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
        {
            array[i] = new Random().Next(0,100);
            System.Console.WriteLine(array[i] + "\n]");    
        }
        else
        {
            array[i] = new Random().Next(0,100);
            System.Console.WriteLine(array[i]+ ",");
        }
    }
}
GetArray();
