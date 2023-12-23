using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Теорія_алгоритмів_Лаб_3_Латиш
{
    public class HashTable : IHashTable
    {
        private Node[] buckets;

        public HashTable(int size)
        {
            this.buckets = new Node[size];
        }
        private int GetIndex(int hashCode)
        {
            return Math.Abs(hashCode % buckets.Length);
        }
        public void Put(Key key, double value)
        {
            int hash = key.GetHashCode();
            int index = GetIndex(hash);
            if(buckets[index] == null)
            {
                buckets[index] = new Node(key, value, hash, null); 
            }
            else
            {
                Node currentNode = buckets[index];
                while (currentNode.next != null)
                {
                    if (currentNode.key.Equals(key))
                        throw new Exception("Already in hash table");
                    currentNode = currentNode.next;
                }
                currentNode.next = new Node(key, value, hash, null);
            }
        }//+
        public double Get(Key key)
        {
            int hash = key.GetHashCode();
            int index = GetIndex(hash);
            Node currentNode = buckets[index];
            while (currentNode != null)
            {
                if (currentNode.key.Equals(key))
                    return currentNode.value;
                currentNode = currentNode.next;
            }
            throw new Exception("Key not found");
        }//+
        public bool ContainsKey(Key key)
        {
            int hash = key.GetHashCode();
            int index = GetIndex(hash);
            if (buckets[index] != null)
            {
                Node currentNode = buckets[index];
                while (currentNode != null)
                {
                    if (currentNode.key.Equals(key))
                    {
                        Console.WriteLine($"Key found: {key.name}:{key.number}");
                        return true;
                    }
                    currentNode = currentNode.next;
                }
            }
            Console.WriteLine($"Key not found.");
            return false;

        }//+
        public void Remove(Key key)
        {
            int hash = key.GetHashCode();
            int index = GetIndex(hash);
            if (buckets[index] != null)
            {
                Node currentNode = buckets[index];
                while (currentNode != null)
                {
                    if (currentNode.key.Equals(key))
                    {
                        Console.WriteLine("Key removed.");
                        while (currentNode.next != null)
                        {
                            currentNode = currentNode.next;
                        }
                    }
                    currentNode = currentNode.next;
                }
            }
        }//+
        public int Size()
        {
            int count = 0;
            for (int i = 0; i < buckets.Length; i++)
            {
                if (buckets[i] != null)
                {
                    Node currentNode = buckets[i];
                    while (currentNode != null)
                    {
                        count++;
                        currentNode = currentNode.next;
                    }
                }
            }
            return count;
        }//+
    }
}