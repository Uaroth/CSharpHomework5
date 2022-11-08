// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// ПРИМЕЧАНИЕ: сперва задал совсем случайный массив,
// при проверке сумма слишком больших нечётных ушла в минуса
// из-за превышения int. Если сделать double, могут вылезти
// совсем монструозные числа. Принял решение ограничить массив.

int[] someNum = new int[5];
someNum = RandomFill(someNum);
OddSum(someNum);

int[] RandomFill(int[] numbers)
{
    Console.WriteLine("Массив таков");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 51);
        Console.Write($"{numbers[i]} . ");
    }
    Console.WriteLine();
    return numbers;
}


void OddSum(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + numbers[i];
        }
    }
    Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");
}