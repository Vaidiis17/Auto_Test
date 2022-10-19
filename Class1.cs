using NUnit.Framework;
using System;
using System.Threading;

namespace ClassLibrary1
{
    public class SimpleTest
    {

        [Test]
        public static void Test()
        {
           
        Assert.True(0 == 995 % 3);

        }

        [Test]
        public static void DayOfWeekTest()
        {
            DateTime Ketvirtadienis = DateTime.Today;
            Assert.AreEqual(DateTime.Today, Ketvirtadienis);
        }


        [Test]

        public static void TestWait()
        {
            Thread.Sleep(5000);
            Assert.Pass();
        }
    }
}
