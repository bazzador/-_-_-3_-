using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Теорія_алгоритмів_Лаб_3_Латиш
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable ht = new HashTable(10);
            ht.Put(new Key("apple", 223), 180.0);
            ht.Put(new Key("META", 300), 160.34);
            ht.Put(new Key("banana", 112), 120.5);
            ht.Put(new Key("orange", 450), 200.75);
            ht.Put(new Key("grape", 555), 90.25);

            Double metaPrice = ht.Get(new Key("META", 300));    // повинно повертати 160.34
            Double applePrice = ht.Get(new Key("apple", 223));  // повинно повертати 180.0
            Double bananaPrice = ht.Get(new Key("banana", 112)); // повинно повертати 120.5
            Double orangePrice = ht.Get(new Key("orange", 450)); // повинно повертати 200.75
            Double grapePrice = ht.Get(new Key("grape", 555));   // повинно повертати 90.25

            Console.WriteLine(metaPrice);
            Console.WriteLine(applePrice);
            Console.WriteLine(bananaPrice);
            Console.WriteLine(orangePrice);
            Console.WriteLine(grapePrice);

            ht.ContainsKey(new Key("META", 300)); // ключ буде знайдений
            ht.ContainsKey(new Key("juice", 127)); // такого ключа немає

            ht.Remove(new Key("META", 300)); // ключ буде винесений 
            ht.Remove(new Key("cucumber", 121)); // такого ключа немає і нічого не виведе

            Console.WriteLine(ht.Size()); // виведе 5
        }
    }
}
