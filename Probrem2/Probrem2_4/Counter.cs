using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probrem2_4
{
    public class Counter
    {
        private static int totalCount = 0;
        private int count = 0;

        public void Reset()
        {
            totalCount -= count;
            count = 0;
        }

        public void Increment()
        {
            count++;
            totalCount++;
        }

        public static int TotalCount()
        {
            return totalCount;
        }

        public int Count
        {
            get { return count; }
        }
    }
}
