﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_10._2
{
    class MyList<T>
    {
        List<T> array = new List<T>();
        List<int> id = new List<int>();
        public void Add(T param, int myId)
        {
            array.Add(param);
            id.Add(myId);
        }
        public string SpecifiedElement(int myId)
        {
            for (int i = 0; i < array.Capacity; i++)
            {
                if (id[i] == myId)
                {
                    return $"id-{id[i]}, elem-{array[i]}";
                }
            }
            return "Такого элемента нет.";
        }
        public int Element
        {
            get { return id.Count; }
        }
    }
}
