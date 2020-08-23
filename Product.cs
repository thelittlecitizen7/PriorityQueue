using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueueRunner
{
    public class Product
    {
        public uint Priority { get; set; }

        public char Tav { get; set; }
        public Product(uint priority, char tav)
        {
            Priority = priority;
            Tav = tav;
        }
    }
}
