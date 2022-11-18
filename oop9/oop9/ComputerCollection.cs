using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace oop9
{
    class MyCollection<T>:ISet<T>
    {
        public HashSet<T> hset { get; set; }
        public int count = 0;
        public MyCollection()
        {
            hset = new HashSet<T>();
        }

        //public bool Add(T item)
        //{
        //    bool isOrNot = hset.Contains(item);
        //    if (isOrNot)
        //        return false;
        //    this.hset.Add(item);
        //    count++;
        //    return true;
        //}

        public bool Add(T item)
        {
            return this.hset.Add(item);
        }
       

        public void Show()
        {
            foreach (T element in this.hset)
            {
                Console.Write(element + "\n");
            }
            Console.WriteLine("\n");
        }

        //public T Find(Predicate<T> match)
        //{
        //    return this.Find(match)
        //}


        public void ExceptWith(IEnumerable<T> other)
        {
            this.hset.ExceptWith(other);
        }

        public void UnionWith(IEnumerable<T> other)
        {
            this.hset.UnionWith(other);
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            this.hset.IntersectWith(other);
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            return this.hset.IsProperSubsetOf(other);
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            return this.hset.IsProperSupersetOf(other);
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            return this.hset.IsSubsetOf(other);
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            return this.hset.IsSupersetOf(other);
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            return this.hset.Overlaps(other);
        }

        public bool SetEquals(IEnumerable<T> other)
        {
            return this.hset.SetEquals(other);
        }

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            this.hset.SymmetricExceptWith(other);
        }

        public int Count { get; }

        public bool IsReadOnly { get; }

        public void Clear()
        {
            this.hset.Clear();
        }
       
        public bool Contains(T item)
        {
            return this.hset.Contains(item);
        }
  
        public void CopyTo(T[] array, int arrayIndex)
        {
            this.hset.CopyTo(array, arrayIndex);
        }
       
        public bool Remove(T item)
        {
            return this.hset.Remove(item);
        }
        public void AddEl(T item)
        {
            this.hset.Add(item);
        }

        

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Add(T item)
        {
            ((ICollection<T>)hset).Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)hset).GetEnumerator();
        }
    }






}
