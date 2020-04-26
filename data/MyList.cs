using System;
using System.Collections.Generic;
using System.Text;

namespace data
{
    public class MyList
    {
        private int[] values { get; set; }
        public MyList() => values = new Int32[5];
        private int elementsCount { get; set; }

        public void Add(int number)
        {
            if (elementsCount >= values.Length)
            {
                values = extendList();
            }
            if (elementsCount == 0)
            {
                values[0] = number;
                elementsCount++;
            }
            values[elementsCount] = number;
            elementsCount++;


        }

        private int[] extendList()
        {
            int[] extendedList = new int[elementsCount + 5];
            for (int i = 0; i < values.Length; i++)
            {
                extendedList[i] = values[i];  
            }
            values = extendedList;
            return values;
        }

        public int Get(int index)
        {
            return values[index];
        }
    }
}
