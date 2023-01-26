using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr09
{
    internal class Pixel
    {
        private string Color { get; set; }

        private Pixel()
        {
            
        }
        public Pixel(string color)
        {
            this.Color = color;
        }

        public override string ToString()
        {
            return $" [{this.Color}] ";
        }
       
    }
}
