using Tyuiu.MazurkevichVS.Sprint4.Task1.V13.Lib;
namespace Tyuiu.MazurkevichVS.Sprint4.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalculateRes()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 8, 1, 5, 4, 2, 1, 2, 7, 6, 1 };
            int res = ds.Calculate(array);
            Assert.AreEqual(22, res);
        }
    }
}
