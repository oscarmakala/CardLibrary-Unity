using System.Collections.Generic;

namespace Unity.Quana.CardEngine
{
    /// <summary>
    /// A pool reuses Memory for objects that are constantly created/destroyed, to prevent always allocating more memory
    /// Makes the AI much much much faster
    /// </summary>
    public class Pool<T> where T : new()
    {
        private readonly HashSet<T> _inUse = new();
        private readonly Stack<T> _available = new();

        public T Create()
        {
            if (_available.Count > 0)
            {
                T elem = _available.Pop();
                _inUse.Add(elem);
                return elem;
            }

            var newObj = new T();
            _inUse.Add(newObj);
            return newObj;
        }

        public void Dispose(T elem)
        {
            _inUse.Remove(elem);
            _available.Push(elem);
        }

        public void DisposeAll()
        {
            foreach (T obj in _inUse)
                _available.Push(obj);
            _inUse.Clear();
        }

        public void Clear()
        {
            _inUse.Clear();
            _available.Clear();
        }

        public HashSet<T> GetAllActive()
        {
            return _inUse;
        }

        public int Count
        {
            get { return _inUse.Count; }
        }

        public int CountAvailable
        {
            get { return _available.Count; }
        }

        public int CountCapacity
        {
            get { return _inUse.Count + _available.Count; }
        }
    }
}