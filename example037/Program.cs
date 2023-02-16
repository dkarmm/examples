// 37. В одномерном массиве из 123 чисел 
// найти количество элементов из отрезка [10,99]

void addNumbers(int[] array) // Функция добавления в массив рандом чисел.
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        array[index] = new Random().Next(1, 200);
        index++;
    }
}
void showRandomNumbers(int[] array) // Функция показа этих чисел.
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}

int showElemen(int[] array)
{
    int size = array.Length;
    int index = 0;
    int start = 10;
    int end = 99;
    int count = 0;
    while (start <= end)
    {
        while (index < size)
        {
            if (array[index] == start)
            {
                count++;
            }
            index++;
        }
        index = 0;
        start++;
    }
    return count;
}
int[] array = new int[123];

addNumbers(array);
showRandomNumbers(array);
int result = showElemen(array);
Console.WriteLine();
Console.WriteLine(result);