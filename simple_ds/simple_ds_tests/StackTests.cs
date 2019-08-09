using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace simple_ds_tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        //test Size() and Push() methods
        public void Push12_Size_2returned()
        {
            int expected = 2;
            int stack_buffer;

            simple_ds.Structures.Stack<int> stack = new simple_ds.Structures.Stack<int>();

            for (var item = 1; item <= 2; ++item)
            {
                stack.Push(item);
            }

            stack_buffer = stack.Size();

            Assert.AreEqual(expected, stack_buffer);
        }

        [TestMethod]
        //test Peek() and isEmpty() methods
        public void Push123_Peek_3returned()
        {
            int expected = 3;
            int stack_buffer;

            simple_ds.Structures.Stack<int> stack = new simple_ds.Structures.Stack<int>();

            for (var item = 1; item <= 3; ++item)
            {
                stack.Push(item);
            }

            stack_buffer = stack.Peek();

            Assert.AreEqual(expected, stack_buffer);
        }

        [TestMethod]
        //test Pop() method
        public void Push123_Pop_3returned()
        {
            int expected = 3;
            int stack_buffer;

            simple_ds.Structures.Stack<int> stack = new simple_ds.Structures.Stack<int>();

            for (var item = 1; item <= 3; ++item)
            {
                stack.Push(item);
            }

            stack_buffer = stack.Pop();

            Assert.AreEqual(expected, stack_buffer);
        }

        [TestMethod]
        //test Reverse(), Copy() and Clear() methods
        public void Push12345678910_Reverse_12345678910returned()
        {
            string expected = "12345678910";
            string stack_buffer = "";

            simple_ds.Structures.Stack<int> stack = new simple_ds.Structures.Stack<int>();

            for (var item = 1; item <= 10; ++item)
            {
                stack.Push(item);
            }

            stack.Reverse();

            while (!stack.isEmpty())
            {
                stack_buffer += stack.Pop().ToString();
            }
            Assert.AreEqual(expected, stack_buffer);
        }

        [TestMethod]
        //test Clear() method
        public void Push123_Clear_0returned()
        {
            int expected = 0;
            int stack_buffer;

            simple_ds.Structures.Stack<int> stack = new simple_ds.Structures.Stack<int>();

            for (var item = 1; item <= 3; ++item)
            {
                stack.Push(item);
            }

            stack.Clear();
            stack_buffer = stack.Size();

            Assert.AreEqual(expected, stack_buffer);
        }
    }
}
