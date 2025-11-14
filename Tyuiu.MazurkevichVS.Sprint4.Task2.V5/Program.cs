using Tyuiu.MazurkevichVS.Sprint4.Task2.V5.Lib;
DataService ds = new DataService();
Random rnd = new Random();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Исходный массив:");
int len;
Console.WriteLine("Введите количество элементов массива:");
len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];

for (int i = 0; i <= len - 1; i++)
{
    array[i] = rnd.Next(3, 9);
}
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i <= len - 1; i++)
{
    Console.Write(array[i] + "\t");
}
int res = ds.Calculate(array);
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Произведение чётных элементов массива: ");
Console.WriteLine(res);
Console.ReadKey();
