using Tyuiu.MazurkevichVS.Sprint4.Task2.V5.Lib;
namespace Tyuiu.MazurkevichVS.Sprint4.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 8, 1, 5, 4, 2, 1, 2, 7, 6, 1, 3, 7, 2, 1 };
            int res = ds.Calculate(array);
            Assert.AreEqual(1536, res);
        }
    }
}
