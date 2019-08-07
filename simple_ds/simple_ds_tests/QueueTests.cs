using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_ds_tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        //this test test Enqueue(), Dequeue() and IsEmpty() methods
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
    }
}
