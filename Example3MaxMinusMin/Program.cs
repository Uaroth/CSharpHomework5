// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double[] someNum = new double[5];
someNum = RandomFill(someNum);
// OddSum(someNum);

double[] RandomFill(double[] numbers)
{
    Console.WriteLine("Массив таков");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Random().Next();
        Console.Write($"{numbers[i]} . ");
    }
    Console.WriteLine();
    return numbers;
}


// void OddSum(double[] numbers)
// {
//     double sum = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum = sum + numbers[i];
//         }
//     }
//     Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");
// }