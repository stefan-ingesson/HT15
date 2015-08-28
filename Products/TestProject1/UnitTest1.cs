using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOfBoxSizePrintPass()
        {
            Size s = new BoxSize(1,1,1);
            string text = s.GetAsText();
            Assert.AreEqual("1x1x1 mm", text);
        }
    }
}
