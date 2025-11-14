using Tyuiu.MazurkevichVS.Sprint4.Task5.V1.Lib;
namespace Tyuiu.MazurkevichVS.Sprint4.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[,]{{ 6, 6, 5, 3, 3 },
                                      { 5, -7, 4, 6, 4 },
                                      { 1, 2, -4, 1, 5 },
                                      { 1, 7, 2, -5, 7 },
                                      { 4, 2, 6, 5, 6 }};
            int[,] expected = new int[,]{{ 1, 1, 1, 1, 1 },
                                      { 1, -7, 1, 1, 1 },
                                      { 1, 1, -4, 1, 1 },
                                      { 1, 1, 1, -5, 1 },
                                      { 1, 1, 1, 1, 1 }};
            int[,] result = ds.Calculate(array);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
