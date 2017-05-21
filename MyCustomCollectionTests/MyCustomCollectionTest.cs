using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PreAndAppenderStrategies;

namespace MyCustomCollectionTests
{
    [TestClass]
    public class MyCustomCollectionTest
    {
        [TestMethod]
        public void TestAppendAndFirst()
        {
            var coll = new MyCustomCollection();

            // add 100 items
            for(var i = 0; i < 100; i++)
            {
                coll.Append(i.ToString());
            }

            // check 100 items
            for(var i = 0; i < 100; i++)
            {
                Assert.AreEqual(i.ToString(), coll.First());
            }
        }

        [TestMethod]
        public void TestPrependAndLast()
        {
            var coll = new MyCustomCollection();

            // add 100 items
            for(var i = 0; i < 100; i++)
            {
                coll.Prepend(i.ToString());
            }

            // check 100 items
            for(var i = 0; i < 100; i++)
            {
                Assert.AreEqual(i.ToString(), coll.Last());
            }
        }

        [TestMethod]
        public void TestBigSize()
        {
            var coll = new MyCustomCollection();

            // add 550 items
            for(var i = 0; i < 550; i++)
            {
                coll.Prepend(i.ToString());
            }

            Assert.AreEqual(550, coll.Count);

            // check 550 items
            for(var i = 0; i < 550; i++)
            {
                Assert.AreEqual(i.ToString(), coll.Last());
            }
        }

        [TestMethod]
        public void TestClear()
        {
            var coll = new MyCustomCollection();

            // add 50 items
            for(var i = 0; i < 50; i++)
            {
                coll.Append(i.ToString());
            }

            Assert.AreEqual(50, coll.Count);

            coll.Clear();

            Assert.AreEqual(0, coll.Count);
        }
    }
}
