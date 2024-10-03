using Newtonsoft.Json.Linq;
using Tyuiu.GubanovaSO.Sprint1.Task2.V3.Lib;
namespace Tyuiu.GubanovaSO.Sprint1.Task2.V3.Test
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
            int x = 2;
            var res = ds.ConvertHourToMin(x);
            Assert.AreEqual(120, res);
        }
    }
}