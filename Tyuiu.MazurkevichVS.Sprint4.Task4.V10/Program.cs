using Tyuiu.MazurkevichVS.Sprint4.Task4.V10.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите кол-во строк и столбцов:");
int rows = Convert.ToInt32(Console.ReadLine());
int length = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, length];

Console.WriteLine("Введите элементы массива");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < length; j++)
    {
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }

}

Console.WriteLine("Ваш массив");
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
int[,] res = ds.Calculate(array);

for (int i = 0; i < length; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write(res[i, j] + "\t");
    }

}
Console.WriteLine();