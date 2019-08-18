using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_ds_tests
{
    [TestClass]
    public class DoubleLinkedListTests
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

        [TestMethod]
        //this method test RemoveHead() function
        public void PushBack23_2returned()
        {
            int expected = 2;
            int list_buffer;

            simple_ds.Structures.DoubleLinkedList<int> list = new simple_ds.Structures.DoubleLinkedList<int>();

            for (var number = 2; number <= 3; ++number)
            {
                list.PushBack(number);
            }

            list_buffer = list.RemoveHead();

            Assert.AreEqual(expected, list_buffer);
        }

        [TestMethod]
        //this method test RemoveTail() function
        public void PushBack23_3returned()
        {
            int expected = 3;
            int list_buffer;

            simple_ds.Structures.DoubleLinkedList<int> list = new simple_ds.Structures.DoubleLinkedList<int>();

            for (var number = 2; number <= 3; ++number)
            {
                list.PushBack(number);
            }

            list_buffer = list.RemoveTail();

            Assert.AreEqual(expected, list_buffer);
        }

        [TestMethod]
        //this method test RemoveElementFromStart() function
        public void PushBack12345_3returned()
        {
            int expected = 3;
            int list_buffer;

            simple_ds.Structures.DoubleLinkedList<int> list = new simple_ds.Structures.DoubleLinkedList<int>();

            for (var number = 1; number <= 5; ++number)
            {
                list.PushBack(number);
            }

            list_buffer = list.RemoveElementFromStart(3);

            Assert.AreEqual(expected, list_buffer);
        }

        [TestMethod]
        //this method test RemoveElementFromBack() function
        public void PushBack12345_4returned()
        {
            int expected = 4;
            int list_buffer;

            simple_ds.Structures.DoubleLinkedList<int> list = new simple_ds.Structures.DoubleLinkedList<int>();

            for (var number = 1; number <= 5; ++number)
            {
                list.PushBack(number);
            }

            list_buffer = list.RemoveElementFromBack(2);

            Assert.AreEqual(expected, list_buffer);
        }

        [TestMethod]
        //this method test Reverse() function
        public void PushBack12345_54321returned()
        {
            string expected = "54321";
            string list_buffer = "";

            simple_ds.Structures.DoubleLinkedList<int> list = new simple_ds.Structures.DoubleLinkedList<int>();

            for (var number = 1; number <= 5; ++number)
            {
                list.PushBack(number);
            }

            list.Reverse();

            while (!list.isEmpty())
            {
                list_buffer += list.RemoveHead();
            }

            Assert.AreEqual(expected, list_buffer);
        }
    }
}
