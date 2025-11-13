using Tyuiu.MazurkevichVS.Sprint4.Task0.V26.Lib;
namespace Tyuiu.MazurkevichVS.Sprint4.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SumOdd()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int res = ds.GetSumOddArrEl(array);
            Assert.AreEqual(2, res);
        }
    }
}
