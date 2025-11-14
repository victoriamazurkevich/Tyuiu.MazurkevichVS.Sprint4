using Tyuiu.MazurkevichVS.Sprint4.Task6.V21.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Исходный массив:");
string[] array = { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "\t");
}
int res = ds.Calculate(array);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("количество элементов, длина которых меньше 8: ");
Console.WriteLine(res);
Console.ReadKey();
