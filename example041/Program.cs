// 41. Выяснить являются ли три числа сторонами треугольника 

void CreateTriagle(int[] triagle)
{
    int index = 0;
    int size = triagle.Length;
    int position = 1;
    while (index < size)
    {
        Console.Write("Введите " + position + " координату точки: ");
        triagle[index] = Convert.ToInt32(Console.ReadLine());
        index++;
        position++;
    }
}
void ShowCoords(int[] triagle)
{
    int index = 0;
    int size = triagle.Length;
    while (index < size)
    {
        Console.Write(triagle[index] + " ");
        index++;
    }
}
bool TriagleOrNot(int [] triagle)
{
    int index = 0;
    int size = triagle.Length;
    while (index < size)
    {
        if (triagle[index] < 0)
        {
            return false;
        }
        index++;
    }
    return true;
}


int [] triagle = new int [3];
CreateTriagle(triagle);
ShowCoords(triagle);
Console.WriteLine();
bool result = TriagleOrNot(triagle);
if (result == true)
{
    Console.WriteLine("Числа являются сторонами треугольника.");
}
else
{
    Console.WriteLine("Числа не являются сторонами треугольника.");
}