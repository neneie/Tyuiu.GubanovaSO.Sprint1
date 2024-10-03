using Tyuiu.GubanovaSO.Sprint1.Task1.V2.Lib;
namespace Tyuiu.GubanovaSO.Sprint1.Task1.V2.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            double x = 5.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);

        }
    }
}