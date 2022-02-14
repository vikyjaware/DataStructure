﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListQueues
{
    public class Queue
    {
        public Node head;
        public Queue()
        {
            this.head = null;
        }

        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Element {0} inserted in the Queue", node.data);
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
                return ;
            }
                Console.WriteLine("Elemet {0} is deleted ", this.head.data);
                this.head=this.head.next;
        }
        public void IsEmpty()
        {
            while (this.head != null)
            {
                Dequeue();
            }
        }
    }
}
