using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_10._3
{
    class MyDictionary<TKey, TValue>
    {
        List<TKey> _key = new List<TKey>();
        List<TValue> _value = new List<TValue>();
        public void Add(TKey key, TValue value)
        {
            _key.Add(key);
            _value.Add(value);
        }
        public string ByIndex(int index)
        {
            return $"{_key[index]}, {_value[index]}";
        }
        public int KeyValue
        {
            get { return _key.Count; }
        }
    }
}
