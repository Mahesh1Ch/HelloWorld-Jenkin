using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
namespace ConsoleAppTest2
{
    [TestClass]
    public class UnitTest1
    {
        public static string Expected = "Hello, Test Main method";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);//seting out put of down statement to sw object
                ConsoleApp2.Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected,result);
            }
        }
    }
}