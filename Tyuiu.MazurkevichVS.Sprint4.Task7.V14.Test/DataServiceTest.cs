using Tyuiu.MazurkevichVS.Sprint4.Task7.V14.Lib;
namespace Tyuiu.MazurkevichVS.Sprint4.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 4;
            string value = "458712659137";
            int res = ds.Calculate(n, m, value);
            int expected = 38;
            Assert.AreEqual(expected, res);

        }
    }
}
