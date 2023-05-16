using MintaZH3.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{

    public class ChildTestFixture
    {
        [
            Test,
            TestCase(1, true),
            TestCase(2, true),
            TestCase(3, true),
            TestCase(4, true),
            TestCase(5, true),
            TestCase(0, false),
            TestCase(666, false)
        ]
        public void TestCheckBehaviour(int value, bool expectedResult)
        {
            var c = new Child();

            var actualResult = c.CheckBehaviour(value);

            Assert.AreEqual(expectedResult, actualResult);


        }
    }
}
