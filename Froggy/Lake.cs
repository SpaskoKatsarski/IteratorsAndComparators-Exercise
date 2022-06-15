using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Froggy
{
    public class Lake<T> : IEnumerable<T>
    {
        public Lake(params T[] stones)
        {
            this.stones = stones.ToList();
        }

        private List<T> stones;

        public int Count => stones.Count;

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return stones[i];
                }
            }

            for (int i = stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
