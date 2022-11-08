// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве

int[] trioNum = new int[4];
trioNum = RandomTrioFill(trioNum);
EvenCheck(trioNum);

int[] RandomTrioFill(int[] numbers)
{
    Console.WriteLine("Массив таков");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
        Console.Write($"{numbers[i]} . ");
    }
    return numbers;
}
void EvenCheck(int[] numbers)
{
    int evenCount = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) evenCount++;
    }
    if (evenCount > 0) Console.WriteLine($"Чётных {evenCount}");
    else Console.WriteLine("Чётных нет");
}