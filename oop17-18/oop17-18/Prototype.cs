using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop17_18
{
    internal interface IPrototype
    {
        string TypeTour();
        void GetTypeTour(string tourtype);

        IPrototype Clone();
    }


    class Tour : IPrototype
    {
        public int NumberOfTickets { get; set; } = 0;
        public string NameOfTheTour { get; set; }

        public int price;
        public string tourtype { get; set; }

        public static List<Tour> tours = new List<Tour>();
        public Tour() { }
        public Tour(string tourtype, int price)
        {
            this.tourtype = tourtype;
            this.price = price;
        }
        public Tour(Tour donor) => this.tourtype = donor.tourtype;

        public string tourstatus { get; set; } = "Стандартный";
        public string TypeTour() => tourtype;
        public void GetTypeTour(string tourtype) => this.tourtype = tourtype;
        public IPrototype Clone() => new Tour(this);
    }

}