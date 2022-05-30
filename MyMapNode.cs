using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class MyMapNode<k,v>
    {
       private readonly int size;
       private readonly LinkedList<KeyValuePair<k, v>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValuePair<k,v>>[size];
        }
        protected int GetArrayPosition(k key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public v Get(k key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<k, v>> linkedlist = GetLinkedList(position);
            foreach (KeyValuePair<k, v> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(v);
        }
        public void Add(k key,v value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<k, v>> linkedlist = GetLinkedList(position);
            KeyValuePair<k, v> item = new KeyValuePair<k, v>() { Key = key, Value = value };
            linkedlist.AddLast(item);
        }
        public void Remove(k key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<k, v>> linkedlist = GetLinkedList(position);
            bool itemfound = false;
            KeyValuePair<k, v> founditem = default(KeyValuePair<k,v>);
            foreach (KeyValuePair<k, v> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    itemfound = true;
                    founditem = item;
                }
            }
            if (itemfound)
            {
                linkedlist.Remove(founditem);
            }
        }

        protected LinkedList<KeyValuePair<k,v>> GetLinkedList(int position)
        {
            LinkedList<KeyValuePair<k, v>> linkedlist = items[position];
            if(linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValuePair<k,v>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }
    }
    public struct KeyValuePair<k, v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }
}
