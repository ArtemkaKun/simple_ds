using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_ds_tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        //this test Enqueue(), Dequeue() and IsEmpty() methods
        public void Enqueue12345678910_Dequeue12345678910_12345678910returned()
        {
            string expected = "12345678910";
            string dequeue_buffer = "";

            simple_ds.Structures.Queue<int> test_queue = new simple_ds.Structures.Queue<int>();

            for (var item = 1; item <= 10; ++item)
            {
                test_queue.Enqueue(item);
            }

            while (!test_queue.isEmpty())
            {
                dequeue_buffer += test_queue.Dequeue().ToString();
            }

            Assert.AreEqual(expected, dequeue_buffer);
        }

        [TestMethod]
        //this test Top() methods
        public void Enqueue12_Top_1returned()
        {
            string expected = "1";
            string dequeue_buffer = "";

            simple_ds.Structures.Queue<int> test_queue = new simple_ds.Structures.Queue<int>();

            for (var item = 1; item <= 2; ++item)
            {
                test_queue.Enqueue(item);
            }

            dequeue_buffer += test_queue.Top().ToString();

            Assert.AreEqual(expected, dequeue_buffer);
        }

        [TestMethod]
        //this test Clear() and Size() methods
        public void Enqueue12_Clear_Size_0returned()
        {
            int expected = 0;
            int dequeue_buffer;

            simple_ds.Structures.Queue<int> test_queue = new simple_ds.Structures.Queue<int>();

            for (var item = 1; item <= 2; ++item)
            {
                test_queue.Enqueue(item);
            }

            test_queue.Clear();
            dequeue_buffer = test_queue.Size();

            Assert.AreEqual(expected, dequeue_buffer);
        }

        [TestMethod]
        //this test Copy() method
        public void Enqueue12345678910_Copy_12345678910returned()
        {
            string expected = "12345678910";
            string dequeue_buffer = "";

            simple_ds.Structures.Queue<int> test_queue = new simple_ds.Structures.Queue<int>();

            for (var item = 1; item <= 10; ++item)
            {
                test_queue.Enqueue(item);
            }

            simple_ds.Structures.Queue<int> test_copy_queue = new simple_ds.Structures.Queue<int>();

            test_copy_queue = test_queue.Copy();
            test_queue.Clear();

            while (!test_copy_queue.isEmpty())
            {
                dequeue_buffer += test_copy_queue.Dequeue().ToString();
            }

            Assert.AreEqual(expected, dequeue_buffer);
        }

        [TestMethod]
        //this test Sort() method
        public void Enqueue19410723856_Sort_12345678910returned()
        {
            string expected = "12345678910";
            string dequeue_buffer = "";

            simple_ds.Structures.Queue<int> test_queue = new simple_ds.Structures.Queue<int>();

            test_queue.Enqueue(1);
            test_queue.Enqueue(9);
            test_queue.Enqueue(4);
            test_queue.Enqueue(10);
            test_queue.Enqueue(7);
            test_queue.Enqueue(2);
            test_queue.Enqueue(3);
            test_queue.Enqueue(8);
            test_queue.Enqueue(5);
            test_queue.Enqueue(6);

            test_queue.Sort();
            while (!test_queue.isEmpty())
            {
                dequeue_buffer += test_queue.Dequeue().ToString();
            }

            Assert.AreEqual(expected, dequeue_buffer);
        }

        [TestMethod]
        //this test Reverse() method
        public void Enqueue12345678910_Reverse_10987654321returned()
        {
            string expected = "10987654321";
            string dequeue_buffer = "";

            simple_ds.Structures.Queue<int> test_queue = new simple_ds.Structures.Queue<int>();

            for (var item = 1; item <= 10; ++item)
            {
                test_queue.Enqueue(item);
            }

            test_queue.Reverse();
            while (!test_queue.isEmpty())
            {
                dequeue_buffer += test_queue.Dequeue().ToString();
            }

            Assert.AreEqual(expected, dequeue_buffer);
        }

        [TestMethod]
        //this test Reverse(n) method
        public void Enqueue12345678910_Reverse_54321678910returned()
        {
            string expected = "54321678910";
            string dequeue_buffer = "";

            simple_ds.Structures.Queue<int> test_queue = new simple_ds.Structures.Queue<int>();

            for (var item = 1; item <= 10; ++item)
            {
                test_queue.Enqueue(item);
            }

            test_queue.Reverse(5);
            while (!test_queue.isEmpty())
            {
                dequeue_buffer += test_queue.Dequeue().ToString();
            }

            Assert.AreEqual(expected, dequeue_buffer);
        }
    }
}
