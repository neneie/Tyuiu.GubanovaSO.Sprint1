using Tyuiu.GubanovaSO.Sprint1.Task0.V30.Lib;
namespace Tyuiu.GubanovaSO.Sprint1.Task0.V30.Test
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
            DataService dataService = new DataService();
            var res = dataService.Calculate();
            Assert.AreEqual(96, res);
        }
    }
}