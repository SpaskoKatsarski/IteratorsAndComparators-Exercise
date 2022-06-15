using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        public ListyIterator(params T[] elements)
        {
            listy = elements.ToList();
            index = 0;
        }

        private List<T> listy;
        private int index;

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index + 1 < listy.Count)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (listy.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine(listy[index]);
        }
    }
}
