using Tyuiu.MazurkevichVS.Sprint4.Task6.V21.Lib;
namespace Tyuiu.MazurkevichVS.Sprint4.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };
            int expected = 2;
            int res = ds.Calculate(array);
            Assert.AreEqual(expected, res);
        }
    }
}
