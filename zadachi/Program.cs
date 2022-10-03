// Zadacha34();
// Zadacha36();
Zadacha38();


void Zadacha34()
{   // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    // [345, 897, 568, 234] -> 2
    int NumbRandom = 1;
    int size = 7;
    int[] solid = new int[size];
    ElectiveMassif(solid, NumbRandom);
    PrintSolid(solid);
    Console.WriteLine($"В массиве {ShowEven(solid)} четных чисел(числа)");
}
void ElectiveMassif(int[] solid, int NumbRandom)
{
    Random rand = new Random();
    int leng = solid.Length;
    for (int i = 0; i < leng; i++)
    {
        if (NumbRandom == 1)
            solid[i] = rand.Next(100, 1000);
        if (NumbRandom == 2)
            solid[i] = rand.Next(-10, 10);
    }
}
void PrintSolid(int[] solid)
{
    Console.Write("[");
    int leng = solid.Length;
    for (int i = 0; i < leng; i++)
    {
        if (i < solid.Length - 1)
            Console.Write(solid[i] + ", ");
        else
            Console.Write(solid[i]);
    }
    Console.WriteLine("]");
}
int ShowEven(int[] solid)
{
    int count = 0;
    int leng = solid.Length;
    for (int i = 0; i < leng; i++)
    {
        if (solid[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}



void Zadacha36()
{
    // Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
    // [3, 7, 23, 12] -> 19
    // [-4, -6, 89, 6] -> 0
    int NumbRandom = 2;
    int size = 8;
    int[] solid = new int[size];
    ElectiveMassif(solid, NumbRandom);
    PrintSolid(solid);
    Console.WriteLine($"Сумма элементов с нечетными индексами приведённого выше массива равна {FindSummSolid(solid)}");
}
int FindSummSolid(int[] solid)
{
    int summ = 0;
    int leng = solid.Length;
    for (int i = 0; i < leng; i++)
    {
        if (i % 2 == 0)
        {
        }
        else
        {
            summ += solid[i];
            Console.WriteLine("Элемент с нечетным индексом:" + solid[i] + " ");
        }
    }
    return summ;
}



void Zadacha38()
{
    // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    // [3,21 7,04 22,93 -2,71 78,24] -> 75,53
    int size = 9;
    Double[] solid = new double[size];
    DoubMassif(solid);
    PrintDoubMassif(solid);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Math.Round(MinMaxDiff(solid), 2)}");
}
void DoubMassif(double[] solid)
{
    Random rand = new Random();
    int leng = solid.Length;
    for (int i = 0; i < leng; i++)
    {
        solid[i] = rand.Next(-10, 11) + rand.NextDouble();
    }
}

double MinMaxDiff(double[] solid)
{
    double min = solid[0];
    double max = solid[0];
    double diff = 0;
    int leng = solid.Length;
    for (int i = 1; i < leng; i++)
    {
        if (solid[i] < min)
        {
            min = solid[i];
        }
        else if (solid[i] > max)
        {
            max = solid[i];
        }
    }
    diff = max - min;
    return diff;
}
void PrintDoubMassif(double[] solid)
{
    Console.Write("Массив [");
    int leng = solid.Length;
    for (int i = 0; i < leng; i++)
    {
        if (i < solid.Length - 1)
            Console.Write(Math.Round(solid[i], 2) + ", ");
        else
            Console.Write(Math.Round(solid[i], 2));
    }
    Console.WriteLine("]");
}