using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue;

namespace QTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void CreateTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            Assert.IsTrue(deq.Size == 0);
        }

        [TestMethod]
        public void PushFrontTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            deq.pushFront("a");
            Assert.IsTrue(deq.Size == 1);
            
            foreach (var item in deq)
            {
                Assert.AreEqual("a", item);
            }
        }

        [TestMethod] 
        public void PushFrontManyTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            deq.pushFront("a");
            deq.pushFront("b");
            deq.pushFront("c");
            Assert.IsTrue(deq.Size == 3);
            Assert.IsTrue(deq.Head.Data == "c");
            Assert.IsTrue(deq.Tail.Data == "a");
        }

        [TestMethod]
        public void PushBack()
        {
            DEQueue<string> deq = new DEQueue<string>();
            deq.pushBack("a");
            Assert.IsTrue(deq.Size == 1);

            foreach (var item in deq)
            {
                Assert.AreEqual("a", item);
            }
        }

        [TestMethod]
        public void PushBacktManyTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            deq.pushBack("a");
            deq.pushBack("b");
            deq.pushBack("c");
            Assert.IsTrue(deq.Size == 3);
            Assert.IsTrue(deq.Head.Data == "a");
            Assert.IsTrue(deq.Tail.Data == "c");
        }

        [TestMethod]
        public void PopFrontTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            deq.pushBack("a");
            deq.pushBack("b");
            deq.pushBack("c");
            Assert.IsTrue(deq.Size == 3);
            Assert.AreEqual("a", deq.Head.Data);
            Assert.AreEqual("c", deq.Tail.Data);

            deq.popFront();
            Assert.IsTrue(deq.Size == 2);
            Assert.AreEqual("b", deq.Head.Data);
            Assert.AreEqual("c", deq.Tail.Data);

            deq.popFront();
            Assert.IsTrue(deq.Size == 1);
            Assert.AreEqual("c", deq.Head.Data);
            Assert.AreEqual("c", deq.Tail.Data);
        }

        [TestMethod]
        public void PopFrontAloneTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            deq.popFront();
            Assert.IsTrue(deq.Size == 0);
            Assert.IsNull(deq.Head);
            Assert.IsNull(deq.Tail);
        }

        [TestMethod]
        public void PopBackTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            deq.pushBack("a");
            deq.pushBack("b");
            deq.pushBack("c");
            Assert.IsTrue(deq.Size == 3);
            Assert.AreEqual("a", deq.Head.Data);
            Assert.AreEqual("c", deq.Tail.Data);

            deq.popBack();
            Assert.IsTrue(deq.Size == 2);
            Assert.AreEqual("a", deq.Head.Data);
            Assert.AreEqual("b", deq.Tail.Data);

            deq.popBack();
            Assert.IsTrue(deq.Size == 1);
            Assert.AreEqual("a", deq.Head.Data);
            Assert.AreEqual("a", deq.Tail.Data);
        }

        [TestMethod]
        public void PopBackAloneTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            deq.popBack();
            Assert.IsTrue(deq.Size == 0);
            Assert.IsNull(deq.Head);
            Assert.IsNull(deq.Tail);
        }

        [TestMethod]
        public void BackTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            Assert.IsNull(deq.back());
        }

        [TestMethod]
        public void BackManyTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            deq.pushFront("a");
            deq.pushBack("b");
            deq.pushFront("c");
            Assert.AreEqual("b", deq.back().Data);
        }

        [TestMethod]
        public void FrontTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            Assert.IsNull(deq.front());
        }

        [TestMethod]
        public void FrontManyTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            deq.pushFront("a");
            deq.pushBack("b");
            deq.pushFront("c");
            Assert.AreEqual("c", deq.front().Data);
        }

        [TestMethod]
        public void ClearTest()
        {
            DEQueue<string> deq = new DEQueue<string>();
            deq.pushFront("a");
            deq.pushBack("b");
            deq.pushFront("c");
            Assert.IsTrue(deq.Size == 3);
            Assert.AreEqual("c", deq.Head.Data);
            Assert.AreEqual("b", deq.Tail.Data);

            deq.clear();
            Assert.IsTrue(deq.Size == 0);
            Assert.IsNull(deq.Head);
            Assert.IsNull(deq.Tail);
        }

        [TestMethod]
        public void ToArrayStringTest()
        {
            string[] output = { "c", "a", "b" };

            DEQueue<string> deq = new DEQueue<string>();
            deq.pushFront("a");
            deq.pushBack("b");
            deq.pushFront("c");
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(output[i], deq.toArray()[i]);
            }
        }

        [TestMethod]
        public void ToArrayIntTest()
        {
            int[] output = { 1, 2, 3, 4, 5 };
            DEQueue<int> deq = new DEQueue<int>();
            deq.pushFront(1);
            deq.pushBack(2);
            deq.pushBack(3);
            deq.pushBack(4);
            deq.pushBack(5);
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(output[i], deq.toArray()[i]);
            }
        }


    }
}
