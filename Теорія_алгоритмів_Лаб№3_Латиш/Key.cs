using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Теорія_алгоритмів_Лаб_3_Латиш
{
    public class Key
    {
        public string name { get; }
        public int number { get; }
        public Key(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
        public override bool Equals(object obj)
        {
            if (obj is Key otherKey)
            {
                return this.name == otherKey.name && this.number == otherKey.number;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode() ^ number.GetHashCode();
        }
    }
}
