using System;
using System.Collections.Generic;
using System.Text;

namespace PriorityQueueRunner
{
    public class Product
    {
        public int Priority { get; set; }

        public char Tav { get; set; }
        public Product(uint priority, char tav)
        {
            Priority = (int)priority;
            Tav = tav;
        }
    }
}
