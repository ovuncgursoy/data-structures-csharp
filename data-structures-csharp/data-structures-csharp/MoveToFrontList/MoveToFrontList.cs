﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.MoveToFrontListSpace
{
    [Serializable]
    public class MoveToFrontList<T> : IEnumerable<T>
        where T : IEquatable<T>
    {
        private List<T> list = new List<T>();

        public int Count { get { return list.Count; } }

        /// <summary>
        /// Retrieves specific node and updates that node position
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public T Get(T node)
        {
            T element = list.Where(e => e.Equals(node)).FirstOrDefault();
            list.Remove(element);
            list.Insert(0, element);
            return element;
        }

        public void Add(T element)
        {
            list.Add(element);
        }

        /// <summary>
        /// Removes element from list, throws exception
        /// </summary>
        /// <param name="element"></param>
        public void Remove(T element)
        {
            list.Remove(element);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}