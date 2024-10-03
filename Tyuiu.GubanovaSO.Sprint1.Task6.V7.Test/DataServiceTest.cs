using Tyuiu.GubanovaSO.Sprint1.Task6.V7.Lib;
namespace Tyuiu.GubanovaSO.Sprint1.Task6.V7.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidString()
        {
            string strTest = "hello world";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter(strTest);
            string wait = "hell worl";
            Assert.AreEqual(wait, res);
        }
    }
}