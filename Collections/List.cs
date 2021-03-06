﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class List
    {

        public int Length { get; set; }
        public Node Head { get; set; }

        public void AddToTail(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Length = 1;
            }
            else
            {
                Node first = Head;
                while (first.Next != null)
                {
                    first = first.Next;
                }
                first.Next = node;
                Length++;
            }
        }

        public void AddToHead(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Length = 1;
            }
            else
            {
                node.Next = Head;
                Head = node;
                Length++;
            }
        }

        public void RemoveTail()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Empty list");
            }
            else
            {
                if(Head.Next == null)
                {
                    Head = null;
                    Length--;
                }
                else
                {
                    Node first = Head;
                    while (first.Next != null)
                    {
                        first = first.Next;
                    }
                    first = null;
                    Length--;
                }
              
            }
        }

        public void RemoveHead()
        {
            if(Head == null)
            {
                throw new InvalidOperationException("Empty list");
            }
            else
            {
                Head = Head.Next;
                Length--;

            }
        }

        public void RemoveIndex(int position)
        {
            int countElements = 0;
            bool foundElement = false;
            if(Head == null)
            {
                throw new InvalidOperationException("Empty list");
            }
            else
            {
                Node first = Head;
                while (first.Next != null)
                {
                    first = first.Next;
                    countElements++;
                    if(countElements == position)
                    {
                        first = first.Next;
                        foundElement = true;
                        Length--;
                        break;
                    }
                    
                }
                if (foundElement == false && countElements != position)
                {
                    throw new InvalidOperationException("Index not found");
                }



            }

        }

    }
}
