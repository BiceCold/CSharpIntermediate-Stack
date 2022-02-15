using System;
using System.Collections.Generic;

namespace CSharpIntermediate_Stack
{
    public class Stack
    {
        private List<int> _stack = new List<int>();

        public void Push(int value)
        {
            // no need to throw an exception as instructed because int cannot be null
            _stack.Add(value);
            Console.WriteLine(_stack[_stack.Count - 1]);
        }

        public void Pop()
        {
            try
            {
                var lastElement = _stack[_stack.Count - 1];
                Console.WriteLine(lastElement);
                _stack.Remove(lastElement);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("There are no elements to remove, error message: {0}", e.Message);
            }
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}