// See https://aka.ms/new-console-template for more information
using LinkedListStack;

Stack stack = new Stack();
stack.Push(56);
stack.Push(30);
stack.Push(70);
Console.WriteLine("The current data is :");
stack.Display();
stack.Peek();
stack.Pop();
stack.IsEmpty();