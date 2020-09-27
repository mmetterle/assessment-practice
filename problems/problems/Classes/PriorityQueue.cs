using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problems.Classes
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TElement">The type of the actual elements that are stored</typeparam>
    /// <typeparam name="TKey">The type of the priority.  It probably makes sense to be an int or long, \
    /// but any type that can be the key of a SortedDictionary will do.</typeparam>
    /// <typeparam name="T"></typeparam>
    public class PriorityQueue<T>
    {
        // The items and priorities.
        List<T> Values = new List<T>();
        List<int> Priorities = new List<int>();

        // Return the number of items in the queue.
        public int NumItems => Values.Count;

        public bool IsEmpty => Values.Count == 0;

        // Add an item to the queue.
        public void Enqueue(T new_value, int new_priority)
        {
            Values.Add(new_value);
            Priorities.Add(new_priority);
        }

        // Remove the item with the largest priority from the queue.
        public void Dequeue(out T top_value, out int top_priority)
        {
            // Find the hightest priority.
            int best_index = 0;
            int best_priority = Priorities[0];
            for (int i = 1; i < Priorities.Count; i++)
            {
                if (best_priority < Priorities[i])
                {
                    best_priority = Priorities[i];
                    best_index = i;
                }
            }

            // Return the corresponding item.
            top_value = Values[best_index];
            top_priority = best_priority;

            // Remove the item from the lists.
            Values.RemoveAt(best_index);
            Priorities.RemoveAt(best_index);
        }
    }
}
