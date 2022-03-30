using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Service;

namespace UnitTestService
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           Assert.IsTrue(Autorization.loginMethod("admin"));
           Assert.IsTrue(Autorization.passwordMethod("admin"));
        }
    }
}
