using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Теорія_алгоритмів_Лаб_3_Латиш
{
    class Node
    {
        public Key key { get; set; }
        public double value { get; set; }
        public int hash { get; set; }
        public Node next { get; set; }

        public Node(Key key, double value, int hash, Node next)
        {
            this.key = key;
            this.value = value;
            this.hash = hash;
            this.next = next;
        }
    }
}
