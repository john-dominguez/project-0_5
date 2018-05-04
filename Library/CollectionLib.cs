﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class CollectionLib
    {
        private static Random rnd = new Random();
        public static bool Equals<T>(List<T> list1, List<T> list2)
        {
            var firstNotSecond = list1.Except(list2).ToList();
            var secondNotFirst = list2.Except(list1).ToList();
            return !firstNotSecond.Any() && !secondNotFirst.Any();
        }

        public static List<T> SortAscending<T>(List<T> list)
        {
            return (List<T>)list.OrderBy(i => i).ToList();
        }

        public static List<T> SortDescending<T>(List<T> list)
        {
            return (List<T>) list.OrderByDescending(i => i).ToList();
        }

        public static int RandomNumber( int max, int offset = 1)
        {
            return (int)(rnd.Next(offset, max + 1));
        }
    }
}
