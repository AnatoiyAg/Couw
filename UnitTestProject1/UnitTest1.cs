using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 1;
            string expected = "1 корова";

            string actual = Program.CowCounter(n);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            int n = 11;
            string expected = "11 коров";

            string actual = Program.CowCounter(n);

            Assert.AreEqual(expected, actual);
        }

        


        [TestMethod]
        public void TestMethod3()
        {
            int n = 2;
            string expected = "2 коровы";

            string actual = Program.CowCounter(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int n = 0;
            string expected = "0 коров";

            string actual = Program.CowCounter(n);

            Assert.AreEqual(expected, actual);
        }

    }
}
