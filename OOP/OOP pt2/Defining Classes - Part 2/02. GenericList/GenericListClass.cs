using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T> where T : IComparable, new()
    {
        private T[] elements;
        private int currentIndex;
        private int capacity;

        public GenericList(int currentCapacity)
        {
            this.Capacity = currentCapacity;
            this.Elements = new T[Capacity];
            this.currentIndex = 0;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value >= 2)
                {
                    this.capacity = value;
                }
            }
        }

        public T[] Elements
        {
            get
            {
                return this.elements;
            }
            set
            {
                this.elements = value;
            }
        }

        public int Count
        {
            get
            {
                return currentIndex;
            }
        }

        public void Add(T currentElement)
        {
            if (currentIndex >= this.Elements.Length)
            {
                Resize();
            }

            this.Elements[currentIndex] = currentElement;
            currentIndex++;
        }

        public T GetAt(int index)
        {
            if (index < 0 || index >= currentIndex)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }

            return this.Elements[index];

        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index >= currentIndex)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }

            T elementToRemove = this.Elements[index];

            for (int i = index; i < this.Elements.Length - 1; i++)
            {
                this.Elements[i] = this.Elements[i + 1];
            }

            currentIndex--;
            return elementToRemove;
        }

        public void InsertAt(T element, int position)
        {
            if (position < 0 || position >= currentIndex)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }

            if (currentIndex >= this.Elements.Length)
            {
                Resize();
            }

            for (int i = currentIndex + 1; i >= position; i--)
            {
                this.Elements[i] = this.Elements[i - 1];
            }

            currentIndex++;
            this.Elements[position] = element;
        }

        public void Clear()
        {
            this.Elements = new T[Capacity];
            this.currentIndex = 0;
        }

        public int Find(T element)
        {
            int index = 0;

            for (int i = 0; i < currentIndex; i++)
            {
                if (this.Elements[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < currentIndex; i++)
            {
                builder.Append(this.Elements[i] + ", ");
            }

            return builder.ToString();
        }

        public T Min()
        {
            T minElement = this.Elements[0];

            for (int i = 0; i < currentIndex; i++)
            {
                if (this.Elements[i].CompareTo(minElement) < 0)
                {
                    minElement = this.Elements[i];
                }
            }

            return minElement;
        }

        public T Max()
        {
            T maxElement = this.Elements[0];

            for (int i = 0; i < currentIndex; i++)
            {
                if (this.Elements[i].CompareTo(maxElement) > 0)
                {
                    maxElement = this.Elements[i];
                }
            }

            return maxElement;
        }

        private void Resize()
        {
            T[] newElements = new T[this.Elements.Length * 2];

            for (int i = 0; i < this.Elements.Length; i++)
            {
                newElements[i] = this.Elements[i];
            }

            this.Elements = newElements;
            this.Capacity *= 2;
        }
    }
}
