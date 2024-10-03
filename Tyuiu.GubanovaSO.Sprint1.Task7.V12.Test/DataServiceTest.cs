using Tyuiu.GubanovaSO.Sprint1.Task7.V12.Lib;
namespace Tyuiu.GubanovaSO.Sprint1.Task7.V12.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 153;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}