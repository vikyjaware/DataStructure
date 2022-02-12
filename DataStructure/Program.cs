// See https://aka.ms/new-console-template for more information
using DataStructure;

LinkedList list = new LinkedList();
list.Add(10);
list.Add(20);
list.Add(30);
list.Add(40);
list.Add(50);
Console.WriteLine("Provided LinkedList :");
list.Display();

list.Add(60);
list.AddInReverseOrder(1);
list.RemoveFirstNode();
list.RemoveLastNode();
list.Search(30);
int Requiredposition = list.Search(30);
list.DeleteNodeAtPerticularPosition(Requiredposition);
Console.WriteLine("The updated LinkedList :");
list.Size();
