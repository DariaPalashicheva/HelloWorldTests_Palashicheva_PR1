using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace HelloWorldTests_Palashicheva_PR1
{
    [TestClass]
    public class UnitTest1
    {

        private const string Expected = "Hello World!";
        private const string Expected2 = "Goodbye World!";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Palashicheva_PR1_testir.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Palashicheva_PR1_testir.Program.SayGoodbye();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected2, result);
            }
        }

    }
}
