using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_ds_tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        //this method test PushBack() method
        public void PushBack123_1returned()
        {
            int expected = 1;
            int expected_size = 3;
            int list_buffer;

            simple_ds.Structures.LinkedList<int> list = new simple_ds.Structures.LinkedList<int>();

            for (var number = 1; number <= 3; ++number)
            {
                list.PushBack(number);
            }

            list_buffer = list.PeekHead();

            Assert.AreEqual(expected, list_buffer);
            Assert.AreEqual(expected_size, list.Size());
        }

        [TestMethod]
        //this method test RemoveHead() method
        public void PushBack12345_1returned()
        {
            int expected = 1;
            int expected_size = 4;
            int list_buffer;

            simple_ds.Structures.LinkedList<int> list = new simple_ds.Structures.LinkedList<int>();

            for (var number = 1; number <= 5; ++number)
            {
                list.PushBack(number);
            }

            list_buffer = list.RemoveHead();

            Assert.AreEqual(expected, list_buffer);
            Assert.AreEqual(expected_size, list.Size());
        }

        [TestMethod]
        //this method test GetElement() method
        public void PushBack12345_3returned()
        {
            int expected = 3;
            int expected_size = 5;
            int list_buffer;

            simple_ds.Structures.LinkedList<int> list = new simple_ds.Structures.LinkedList<int>();

            for (var number = 1; number <= 5; ++number)
            {
                list.PushBack(number);
            }

            list_buffer = list.GetElement(3);

            Assert.AreEqual(expected, list_buffer);
            Assert.AreEqual(expected_size, list.Size());
        }

        [TestMethod]
        //this method test RemoveElement() method
        public void PushBack12345_1245returned()
        {
            string expected = "1245";
            int expected_size = 4;
            string list_buffer = "";
            int expected_return = 3;
            int retrn;

            simple_ds.Structures.LinkedList<int> list = new simple_ds.Structures.LinkedList<int>();

            for (var number = 1; number <= 5; ++number)
            {
                list.PushBack(number);
            }

            retrn = list.RemoveElement(3);

            while (!list.isEmpty())
            {
                list_buffer += list.RemoveHead();
            }

            Assert.AreEqual(expected, list_buffer);
            
            Assert.AreEqual(expected_return, retrn);
        }

        [TestMethod]
        //this method test PushStart() method
        public void PushStart12345_1returned()
        {
            int expected = 5;
            int expected_size = 5;
            int list_buffer;

            simple_ds.Structures.LinkedList<int> list = new simple_ds.Structures.LinkedList<int>();

            for (var number = 1; number <= 5; ++number)
            {
                list.PushStart(number);
            }

            list_buffer = list.PeekHead();

            Assert.AreEqual(expected, list_buffer);
            Assert.AreEqual(expected_size, list.Size());
        }

        [TestMethod]
        //this method test isEmpty() method
        public void PushStart12345_falsereturned()
        {
            bool expected = false;
            bool list_buffer;

            simple_ds.Structures.LinkedList<int> list = new simple_ds.Structures.LinkedList<int>();

            for (var number = 1; number <= 5; ++number)
            {
                list.PushStart(number);
            }

            list_buffer = list.isEmpty();

            Assert.AreEqual(expected, list_buffer);
        }

        [TestMethod]
        //this method test Clear() method
        public void PushStart12345_0returned()
        {
            int expected = 0;

            simple_ds.Structures.LinkedList<int> list = new simple_ds.Structures.LinkedList<int>();

            for (var number = 1; number <= 5; ++number)
            {
                list.PushStart(number);
            }

            list.Clear();

            Assert.AreEqual(expected, list.Size());
        }

        [TestMethod]
        //this method test Sort() method
        public void PushBack15324_12345returned()
        {
            string expected = "12345";
            string list_buffer = "";

            simple_ds.Structures.LinkedList<int> list = new simple_ds.Structures.LinkedList<int>();

            list.PushBack(1);
            list.PushBack(5);
            list.PushBack(3);
            list.PushBack(2);
            list.PushBack(4);

            list.Sort();

            while (!list.isEmpty())
            {
                list_buffer += list.RemoveHead();
            }

            Assert.AreEqual(expected, list_buffer);
        }

        [TestMethod]
        //this method test Copy() method
        public void PushBack12345_12345returned()
        {
            string expected = "12345";
            string list_buffer = "";

            simple_ds.Structures.LinkedList<int> list = new simple_ds.Structures.LinkedList<int>();
            simple_ds.Structures.LinkedList<int> copied_list = new simple_ds.Structures.LinkedList<int>();

            for (var number = 1; number <= 5; ++number)
            {
                list.PushBack(number);
            }

            copied_list = list.Copy();

            while (!copied_list.isEmpty())
            {
                list_buffer += copied_list.RemoveHead();
            }

            Assert.AreEqual(expected, list_buffer);
        }

        [TestMethod]
        //this method test Copy() method
        public void PushBack12345_54321returned()
        {
            string expected = "54321";
            string list_buffer = "";

            simple_ds.Structures.LinkedList<int> list = new simple_ds.Structures.LinkedList<int>();

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
