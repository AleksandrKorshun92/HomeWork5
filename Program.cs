//Задача 34.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
int[] FillArayRandom(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i=0; i<arr.Length; i++)
    {
        arr[i]=rnd.Next(100,1000);
    }
    return arr;
}
Console.Write("Hello, write size massiv ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[] array = FillArayRandom(size);

int ChackMassiv(int[] arr)
{
    int count = 0;
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count++;
        }       
    }
    return count;
}
Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine($"The number of even numbers in the array = {ChackMassiv(array)}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int[] FiilArrNewMassiv(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i<arr.Length; i++)
    {
        arr[i] = rnd.Next(-100,100);
    }
    return arr;
}
Console.Write("Hello, write size massiv ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[] array = FiilArrNewMassiv(size);

int SummaMassiva(int[] array)
{
    int summa = 0;
    for(int i =1; i<array.Length; i+=2)
    {
        summa += array[i];
    }
    return summa;
}

Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine($"Summa elementov massiva from odd indexes = {SummaMassiva(array)}");
*/
//Задача 38: Задайте массив вещественных чисел(тип double). Найдите разницу между максимальным и минимальным элементов массива.
//[3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

/*
double[] FiilArrNewMassiv(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for(int i = 0; i<arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()*100;
        arr[i] = Math.Round(arr[i],2);
    }
    return arr;
}
Console.Write("Write size massiv ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Clear();
double[] array = FiilArrNewMassiv(size);

double SearchDifferenceMinMaxMassiv(double[] array)
{
    double difference = 0;
    double max = array[0];
    double min = array[0];
    for(int i=0; i<array.Length; i++)
    {
        for(int j=0; j<array.Length; j++)
        {
        if(array[j]>max)
        {
            max = array[j];
        }
        if(array[i]<min)
        {
            min = array[i];
        }
        }
       
    }
    return difference = max-min;
}
Console.WriteLine($"[{string.Join("; ", array)}]");
Console.WriteLine($"Difference max elementa massiva and min elementa = {SearchDifferenceMinMaxMassiv(array)}");
*/