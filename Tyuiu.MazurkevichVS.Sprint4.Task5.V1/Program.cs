using Tyuiu.MazurkevichVS.Sprint4.Task5.V1.Lib;
DataService ds = new DataService();
Random rnd = new Random();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Исходный массив:");
Console.WriteLine("Введите кол-во строк и столбцов:");
int rows = Convert.ToInt32(Console.ReadLine());
int length = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, length];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < length; j++)
    {
        array[i, j] = rnd.Next(-9, 8);
    }
}
Console.WriteLine();
Console.WriteLine("Ваш массив");
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
int[,] res = ds.Calculate(array);
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Ваш массив: ");
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write(res[i, j] + "\t");
    }

}
Console.WriteLine(res);
Console.ReadKey();
