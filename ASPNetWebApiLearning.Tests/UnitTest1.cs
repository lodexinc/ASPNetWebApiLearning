using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASPNetWebApiLearning.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Is this working");
            Assert.AreEqual(2, 2);
        }
    }
}
