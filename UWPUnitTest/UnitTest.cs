using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using SimplePlugin;

namespace UWPUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual("Hello", Plugin.SayHello());
        }
    }
}
