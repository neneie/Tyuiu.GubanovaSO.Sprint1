using Tyuiu.GubanovaSO.Sprint1.Task4.V21.Lib;
namespace Tyuiu.GubanovaSO.Sprint1.Task4.V21.Test
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
            double x = 5;
            double y = 36;
            double wait = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}