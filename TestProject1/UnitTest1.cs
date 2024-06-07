using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerifyZeroIsNotEqualToFive()
        {
            Random rand = new Random();
            Assert.AreEqual(false, rand.Next(0, 5) == 0);
        }

        [TestMethod]
        public void VerifyZeroIsEqualToZero()
        {
            Random rand = new Random();
            Assert.AreEqual(true, rand.Next(0, 0) == 0);
        }
    }
}