// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] InitArray(int n)
{
    int[] array = new int[n];
    Random rnd = new Random();
    for (int i = 0; i <array.Length; i++)
    {
        array[i] = rnd.Next(-100,101);
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

int SummOfDigit(int[] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i+=2)
    {
        sum+=arr[i];
    }    
    return sum;
}

Console.WriteLine("Введите длину массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = InitArray(n);
Print(array);
Console.WriteLine($"Сумма чисел стоящих на нечетных позициях равнв {SummOfDigit(array)}");