using System;

namespace lab7
{
    public struct LinkedList
    {
        private Node _head;
        private Node _tail;

        public int count;

        public void AddAfterSecond(float num)
        {
            Node node = new Node(num);

            if (_head == null) // Add first
            {
                _head = node;
                _tail = node;
            }
            else if (_head.next == null) // Add second
            {
                _head.next = node;
                _tail = node;
            }
            else if (_head.next.next == null) // Add third
            {
                _head.next.next = node;
                _tail = node;
            }
            else // Add after second
            {
                Node third = _head.next.next;
                _head.next.next = node;
                _head.next.next.next = third;
            }
            count++;
        }

        public void AddInEnd(float num)
        {
            Node node = new Node(num);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else 
            {
                _tail.next = node;
                _tail = node;
            }
            count++;
        }

        public void Remove(float item)
        {
            Node previous = null;
            Node current = _head;

            while (current != null)
            {
                if (current.value.Equals(item))
                {
                    // Узел в середине или в конце.
                    if (previous != null)
                    {
                        // До:    Head -> 3 -> 5 -> null
                        // После: Head -> 3 ------> null
                        previous.next = current.next;

                        // Если в конце, то меняем _tail.
                        if (current.next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        // До:    Head -> 3 -> 5
                        // После: Head ------> 5

                        // Head -> 3 -> null
                        // Head ------> null
                        _head = _head.next;

                        // Список теперь пустой?
                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }
                    count--;
                }
                previous = current;
                current = current.next;
            }
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            count = 0;
        }

        public bool Contains(float item)
        {
            Node current = _head;
            while (current != null)
            {
                if (current.value.Equals(item))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public void PrintList()
        {
            Node node = _head;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
            Console.WriteLine();
        }

        public int FindCount(float n)
        {
            int k = 0;
            Node node = _head;

            while (node != null)
            {
                if (node.value > n)
                    k++;
                node = node.next;
            }

            return k;
        }

        public void DeleteGreater()
        {
            Node node = _head;
            float average = 0;

            while (node != null)
            {
                average += node.value;
                node = node.next;
            }

            average /= count;
            Console.WriteLine("Average: " + average);

            node = _head.next;
            Node previous = _head;

            while (node != null)
            {
                if (node.value > average)
                {
                    previous.next = node.next;                    
                }
                else
                {
                    previous = node;                    
                }
                node = node.next;
            }

            if(_head.value > average)
                _head = _head.next;
        }
    }     
}
