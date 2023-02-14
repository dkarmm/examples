// 33. Задать массив из 12 элементов, заполненных числами от -9 до 9. 
// Найти сумму положительных/отрицательных элементов массива
Console.Clear();
void addNumbers(int[] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        array[index] = new Random().Next(-9, 9);
        index++;
    }
}
void showNumbers(int[] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}
int findSumPlus(int[] array)
{
    int index = 0;
    int size = array.Length;
    int sum = 0;
    while (index < size)
    {
        if (array[index] >= 0)
        {
            sum = sum + array[index];
        }
        index++;
    }
    return sum;
}
int findSumMinis(int []array)
{
    int index = 0;
    int size = array.Length;
    int sum = 0;
    while (index < size)
    {
        if (array[index] <= 0)
        {
            sum = sum + array[index];
        }
        index++;
    }
    return sum;
}
int[] array = new int[12];
addNumbers(array);
showNumbers(array);
int resultForPlus = findSumPlus(array);
int resultForMinus = findSumMinis(array);
Console.WriteLine();
Console.WriteLine("Сумма положительных чисел: " + resultForPlus);
Console.WriteLine("Сумма отрицательных чисел: " + resultForMinus);
Console.WriteLine();

