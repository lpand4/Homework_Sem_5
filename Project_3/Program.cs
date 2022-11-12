// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] InitArray(int n)
{
    double[] array = new double[n];
    Random rnd = new Random();
    for (int i = 0; i <array.Length; i++)
    {
        array[i] = rnd.Next(-100,101);
    }
    return array;
}

void Print(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// Первым возвращается max, вторым min, третьим результат
(double, double, double) Raznica(double[] arr)
{
    double min =arr[0];
    double max =arr[0];
    double result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
            min = arr[i];
        if(arr[i] > max)
            max = arr[i];
    }
    result = max - min;
    return (max, min, result);
}

Console.WriteLine("Введите длину массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = InitArray(n);
Print(array);
(double max,double min, double result) = Raznica(array);
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} числом массива равна {result}");