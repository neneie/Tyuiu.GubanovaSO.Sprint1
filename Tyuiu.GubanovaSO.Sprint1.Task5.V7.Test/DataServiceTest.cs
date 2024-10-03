using Tyuiu.GubanovaSO.Sprint1.Task5.V7.Lib;
namespace Tyuiu.GubanovaSO.Sprint1.Task5.V7.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            double f = 121;
            int res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(4, res);
        }
    }
}