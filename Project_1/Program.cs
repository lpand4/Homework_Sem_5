// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] InitArray(int n)
{
    int[] array = new int[n];
    Random rnd = new Random();
    for (int i = 0; i <array.Length; i++)
    {
        array[i] = rnd.Next(100,1000);
    }
    return array;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int CountDigit(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2==0)
        count++;
    }    
    return count;
}

Console.WriteLine("Введите длину массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = InitArray(n);
Print(array);
Console.WriteLine($"В массиве {CountDigit(array)} четных чисел");