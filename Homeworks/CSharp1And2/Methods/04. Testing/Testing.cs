using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountTheNumber;

namespace _04.Testing
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] testArray = {1, 2, 2, 3};
            int result = AppearanceCount.CountTheAppearence(testArray, 2);
            Assert.AreEqual(2, result); 
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] testArray2 = { 1, 1, 1, 1, 1 };
            int result2 = AppearanceCount.CountTheAppearence(testArray2, 1);
            Assert.AreEqual(5, result2);
        }
    }
}
