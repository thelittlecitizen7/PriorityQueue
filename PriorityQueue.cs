using PriorityQueue.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PriorityQueueRunner
{
    public class PriorityQueue<T> : IPriorityQueue<T>
    {
        

        public List<KeyValuePair<int,T>> MapItems { get; set; }

        public PriorityQueue()
        {
            MapItems = new List<KeyValuePair<int, T>>();
            
        } 
        public int Count => MapItems.Count;

        public T Dequeue()
        {
            KeyValuePair<int,T> foundItem = MapItems.OrderByDescending(p => p.Key).ToList().Last();
            int itemIndex = MapItems.IndexOf(foundItem);
            MapItems = MapItems.Where(v => MapItems.IndexOf(v) != itemIndex).ToList();
            return foundItem.Value;
        }

        public void Enqueue(uint priority, T item)
        {
            MapItems.Add(new KeyValuePair<int, T>((int)priority, item));
        }
    }
}
