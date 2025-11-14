using Tyuiu.MazurkevichVS.Sprint4.Task3.V25.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Исходный массив:");
int[,] array = new int[,] { { 7, 3, 5, 3, 6 },
                            { 4, 6, 2, 5, 7 },
                            { 2, 3, 3, 3, 5 },
                            { 2, 7, 7, 6, 2 },
                            { 6, 6, 4, 3, 6 } };
for (int i = 0; i <5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
}
int res = ds.Calculate(array);
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Произведение элементов четвёртого столбца: ");
Console.WriteLine(res);
Console.ReadKey();
