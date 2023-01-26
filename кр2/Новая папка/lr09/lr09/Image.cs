using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lr09
{
    internal class Image<Pixel> : ISet<Pixel>, IEnumerable<Pixel>  
    {

        private LinkedList<Pixel> pixels = new LinkedList<Pixel>();

        
        public IEnumerator<Pixel> GetEnumerator()
        {
            return pixels.GetEnumerator();
        }

        IEnumerator<Pixel> IEnumerable<Pixel>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static Image<Pixel> operator +(Image<Pixel> image1, Image<Pixel> image2)
        {
            Image<Pixel> image3 = new Image<Pixel>();
            foreach (Pixel p in image1)
            {
                image3.Add(p);
            }
            foreach (Pixel p in image2)
            {
                image3.Add(p);
            }
            return image3;
        }

        public bool Add(Pixel pixel)
        {
            pixels.AddLast(pixel);
            return true;
        }


        void ICollection<Pixel>.Add(Pixel item)
        {
            pixels.AddLast(item);
        }

        public void Clear()
        {
            pixels.Clear();
        }

        public bool Contains(Pixel item)
        {
            return pixels.Contains(item);
        }

        public void CopyTo(Pixel[] array, int arrayIndex)
        {
            pixels.CopyTo(array, arrayIndex);
        }

        public bool Remove(Pixel item)
        {
            return pixels.Remove(item);
        }

        public int Count => pixels.Count;

        public bool IsReadOnly => false;

        public void UnionWith(IEnumerable<Pixel> other)
        {
            foreach (var pixel in other)
            {
                pixels.AddLast(pixel);
            }
        }

        public void IntersectWith(IEnumerable<Pixel> other)
        {
            throw new NotImplementedException();
        }

        public void ExceptWith(IEnumerable<Pixel> other)
        {
            throw new NotImplementedException();
        }

        public void SymmetricExceptWith(IEnumerable<Pixel> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<Pixel> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<Pixel> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<Pixel> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IEnumerable<Pixel> other)
        {
            throw new NotImplementedException();
        }

        public bool SetEquals(IEnumerable<Pixel> other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return pixels.ToString();
        }

        public override bool Equals(object obj)
        {
            return pixels.Equals(obj);
        }

        public override int GetHashCode()
        {
            return pixels.GetHashCode();
        }

        public void AddRange(IEnumerable<Pixel> pixels)
        {
            foreach (var pixel in pixels)
            {
                this.pixels.AddLast(pixel);
            }
        }

        public void AddRange(Image<Pixel> image)
        {
            foreach (var pixel in image.pixels)
            {
                this.pixels.AddLast(pixel);
            }
        }

        public void AddRange(Pixel[] pixels)
        {
            foreach (var pixel in pixels)
            {
                this.pixels.AddLast(pixel);
            }
        }

        public bool IsSupersetOf(IEnumerable<Pixel> pixels)
        {
            return this.pixels.Contains(pixels.First());
        }

        public bool IsSupersetOf(Image<Pixel> image)
        {
            return this.pixels.Contains(image.pixels.First());
        }

        




    }
}
