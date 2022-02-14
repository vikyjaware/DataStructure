using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStack
{
    public class Stack
    {
        public Node top;

        public Stack()
        {
            this.top = null;
        }

        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", data);
        }

        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        public void Peek()
        {
            if (this.top == null)
            {
                System.Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("element {0} is in the top of the stack", this.top.data);
        }

        public void Pop()
        {
            if (this.top == null)
            {
                System.Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("element {0} popped from the stack", this.top.data);
            this.top = this.top.next;
        }

        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("Stack is empty now");
        }
    }
}
