// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] someNum = new double[5];
someNum = RandomFill(someNum);
MaxMinusMin(someNum);

double[] RandomFill(double[] numbers)
{
    Console.WriteLine("Массив таков");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
        Console.Write($"{numbers[i]} . ");
    }
    Console.WriteLine();
    return numbers;
}


void MaxMinusMin(double[] numbers)
{
    double max = numbers[0];
    double min = numbers[0];    
    for (int i = 0; i < numbers.Length; i++)
    {
        if (max < numbers[i]) max = numbers[i];
        else if (min > numbers[i]) min = numbers[i];
    }
    Console.WriteLine($"Максимум {max}");
    Console.WriteLine($"Минимум {min}");
    Console.WriteLine($"Разница максимума и минимума = {max - min}");
}