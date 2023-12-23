using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Теорія_алгоритмів_Лаб_3_Латиш
{
    public interface IHashTable
    {
        void Put(Key key, double value);
        double Get(Key key);
        bool ContainsKey(Key key);
        void Remove(Key key);
        int Size();
    }
}

