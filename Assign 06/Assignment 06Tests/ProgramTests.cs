using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            //This is not the droid you are looking for.  :)
        }

        [TestMethod()]
        public void FindEvenTest()
        {
            List<Int64> fibNumbers = new List<Int64>();

            //Call method to determine first 50 fibNumbers
            fibNumbers = Program.FindAllFib(fibNumbers);

            List<Int64> fibNumEven = new List<Int64>();

            //Call method to determine if fibNumbers are even
            fibNumEven = Program.FindEven(fibNumbers);

            for (int i = 0; i < fibNumEven.Count; i++)
            {
                Assert.AreEqual(fibNumEven[i] % 2, 0);
            }
        }

        [TestMethod()]
        public void FindAllFibTest()
        {
            List<Int64> fibNumbers = new List<Int64>();

            //Call method to determine first 50 fibNumbers
            fibNumbers = Program.FindAllFib(fibNumbers);

            Assert.AreEqual(fibNumbers[0], 1);
            Assert.AreEqual(fibNumbers[1], 1);
            Assert.AreEqual(fibNumbers[2], 2);
            Assert.AreEqual(fibNumbers[3], 3);
            Assert.AreEqual(fibNumbers[4], 5);
            Assert.AreEqual(fibNumbers[5], 8);
            Assert.AreEqual(fibNumbers[6], 13);
        }
    }
}