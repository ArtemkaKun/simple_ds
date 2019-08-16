using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_ds_tests
{
    [TestClass]
    class DoubleLinkedListTests
    {
        [TestMethod]
        //this method test PeekHead() function
        public void PushBack123_1returned()
        {
            int expected = 1;
            int list_buffer;

            simple_ds.Structures.DoubleLinkedList<int> list = new simple_ds.Structures.DoubleLinkedList<int>();

            for (var number = 1; number <= 3; ++number)
            {
                list.PushBack(number);
            }

            list_buffer = list.PeekHead();

            Assert.AreEqual(expected, list_buffer);
        }

        [TestMethod]
        //this method test PeekTail() function
        public void PushBack123_3returned()
        {
            int expected = 3;
            int list_buffer;

            simple_ds.Structures.DoubleLinkedList<int> list = new simple_ds.Structures.DoubleLinkedList<int>();

            for (var number = 1; number <= 3; ++number)
            {
                list.PushBack(number);
            }

            list_buffer = list.PeekTail();

            Assert.AreEqual(expected, list_buffer);
        }

        [TestMethod]
        //this method test GetElementFromStart() function
        public void PushBack123_2returned()
        {
            int expected = 2;
            int list_buffer;

            simple_ds.Structures.DoubleLinkedList<int> list = new simple_ds.Structures.DoubleLinkedList<int>();

            for (var number = 1; number <= 3; ++number)
            {
                list.PushBack(number);
            }

            list_buffer = list.GetElementFromStart(2);

            Assert.AreEqual(expected, list_buffer);
        }

        [TestMethod]
        //this method test GetElementFromBack() function
        public void PushBack1234_3returned()
        {
            int expected = 3;
            int list_buffer;

            simple_ds.Structures.DoubleLinkedList<int> list = new simple_ds.Structures.DoubleLinkedList<int>();

            for (var number = 1; number <= 4; ++number)
            {
                list.PushBack(number);
            }

            list_buffer = list.GetElementFromBack(2);

            Assert.AreEqual(expected, list_buffer);
        }
    }
}
