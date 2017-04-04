using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace UWPUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual("Hello", Plugin.Plugin.SayHello());
        }
    }
}
