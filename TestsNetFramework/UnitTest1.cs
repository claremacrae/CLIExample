using CLI;
using Native;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTestNetFramework
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(4, 4);
            Assert.AreEqual("Hello from C#", Class1.Hello());
            Entity e = new Entity("The Wallman", 20, 35);
            Assert.AreEqual(e.XPosition, 20);
        }
    }
}
