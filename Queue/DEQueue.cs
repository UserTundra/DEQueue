using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class DEQueue<T>  : IEnumerable<T>
    {
        
        Node<T> head;
        Node<T> tail;
        int count;

        public DEQueue()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public int Size
        {
            get { return count; }
        }

        public Node<T> Head
        {
            get { return head; }
        }

        public Node<T> Tail
        {
            get { return tail; }
        }

        public void pushBack(T data)
        {
            Node<T> node = new Node<T>(data);

            if (count == 0)
                head = node;
            else
            {
                tail.Next = node;
            }
            node.Previous = tail;
            tail = node;
            count++;

        }

        public void pushFront(T data)
        {
            Node<T> node = new Node<T>(data);
            if (count == 0)
            {
                head = node;
                tail = head;
            }
            else
            {
                Node<T> buf = head;
                node.Next = buf;
                head = node;
                buf.Previous = node;
            }
            count++;
        }

        public Node<T> popFront()
        {
            Node<T> pointer = head;
            if (count != 0)
            {
                head = head.Next;
                count--;
            }
            return pointer;
        }

        public Node<T> popBack()
        {
            Node<T> pointer = tail;
            if (count != 0 )
            {
                tail = tail.Previous;
                count--;
            }
            return pointer;
        }

        public Node<T> back()
        {
            return tail;
        }

        public Node<T> front()
        {
            return head;
        }

        public void clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public T[] toArray()
        {
            T[] array = new T[this.Size];
            int idx = 0;
            foreach (var el in this)
            {
                array[idx++] = el;
            }
            return array;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
