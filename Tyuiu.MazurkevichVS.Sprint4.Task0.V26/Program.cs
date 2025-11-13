using Tyuiu.MazurkevichVS.Sprint4.Task0.V26.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Исходный массив:");
int[] array = new int[] { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
int res = ds.GetSumOddArrEl(array);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма нечётных элементов массива: ");
Console.WriteLine(res);
Console.ReadKey();
