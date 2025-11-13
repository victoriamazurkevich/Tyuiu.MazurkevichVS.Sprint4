using Tyuiu.MazurkevichVS.Sprint4.Task1.V13.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Исходный массив:");
int len;
Console.WriteLine("Введите количество элементов массива:");
len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];

for (int i = 0; i <= len-1; i++)
{
    Console.WriteLine("Введите значение " + i + " элемента массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
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
Console.WriteLine("Сумма чётных элементов массива: ");
Console.WriteLine(res);
Console.ReadKey();
