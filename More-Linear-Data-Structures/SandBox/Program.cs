﻿using Problem02.DoublyLinkedList;
using Problem03.ReversedList;
using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ReversedList<int>();
            list.Add(1);
            list.Add(2);
            list.Insert(1, 0);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
