using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace lr09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Image<Pixel> image1 = new Image<Pixel>();
            Image<Pixel> image2 = new Image<Pixel>();
            Image<Pixel> image3 = new Image<Pixel>();



            Pixel p1 = new Pixel("красный");
            Pixel p2 = new Pixel("зеленый");
            Pixel p3 = new Pixel("синий");
            Pixel p4 = new Pixel("желтый");
            Pixel p5 = new Pixel("фиолетовый");
            Pixel p6 = new Pixel("оранжевый");
            Pixel p7 = new Pixel("белый");
            Pixel p8 = new Pixel("черный");
            Pixel p9 = new Pixel("серый");

            image1.Add(p1);
            image1.Add(p2);
            image1.Add(p3);

            image2.Add(p4);
            image2.Add(p5);
            image2.Add(p6);

            image3.Add(p7);
            image3.Add(p8);
            image3.Add(p9);

            Console.WriteLine(image1.Contains(p2));



            Image<Pixel> image4 = image1 + image2;

            Console.WriteLine("image1 + image2: ");
            foreach (Pixel p in image4)
            {
                Console.WriteLine(p.ToString());
            }

            image4.Remove(p1);
            image4.Remove(p6);
            image4.Remove(p7);

            Console.WriteLine("new image1 + image2: ");
            foreach (Pixel p in image4)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("image1 all: ");
            foreach (Pixel p in image1)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("image2 all: ");
            foreach (Pixel p in image2)
            {
                Console.WriteLine(p.ToString());
            }
                
            Console.WriteLine("image3 all: ");
            foreach (Pixel p in image3)
            {
                Console.WriteLine(p.ToString());
            }
            

            // create second collection
            List<Pixel> pixels = new List<Pixel>();

            pixels.Add(p1);
            pixels.Add(p2);
            pixels.Add(p3);

            image3.AddRange(pixels);

            Console.WriteLine("image3 all: ");
            foreach (Pixel p in image3)
            {
                Console.WriteLine(p.ToString());
            }




            var MyColletion = new ObservableCollection<Pixel>();

            MyColletion.CollectionChanged += MyCollection_onChange;

            MyColletion.Add(p1);
            MyColletion.Add(p2);
            MyColletion.Add(p3);

            MyColletion.RemoveAt(0);
        }

        private static void MyCollection_onChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Add element in collection MyCollection");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Delete element in collection MyCollection");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Change element in collection MyCollection");
                    break;
            }
        }
    }
}
