// Задача 23
// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void showResult (int number)
{
    int start = 1;
    int index = 0;
    while (index < number)
    {
        Console.Write(Math.Pow(start,3) + " ");
        index++;
        start++;
    }
}

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
showResult(number);
Console.WriteLine();