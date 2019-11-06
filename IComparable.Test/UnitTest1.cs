using System;
using NUnit.Framework;
using IComparable_01;

namespace IComparable.Test
{
    [TestFixture]
    public class UnitTest1
    {
        Item Icompare;

        [SetUp]
        public void SetupMethod() 
        {
            Icompare = new Item();
        }
        


        [Test]
        public void TestMethod1()
        {
            Assert.IsNotNull("Hi", Icompare.Comparabilities("hi"));
        }


        [TearDown] 
        public void CLeanUp()
        {
            Icompare = null;
        }
    }
}
