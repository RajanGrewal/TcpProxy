﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace MinerProxy.Web
{
    class ConsoleList
    {

        public ConsoleColor color { get; set; }
        public string message { get; set; }
        public string endPoint { get; set; }

        public ConsoleList(string text, string endPoint, ConsoleColor color)

        {
            this.message = text;
            this.color = color;
            this.endPoint = endPoint;
        }

    }

    class SlidingBuffer<T> : IEnumerable<T>
    {
        private readonly Queue<T> _queue;
        private readonly int _maxCount;

        public SlidingBuffer(int maxCount)
        {
            _maxCount = maxCount;
            _queue = new Queue<T>(maxCount);
        }

        public void Add(T item)
        {
            if (_queue.Count == _maxCount)
                _queue.Dequeue();
            _queue.Enqueue(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
