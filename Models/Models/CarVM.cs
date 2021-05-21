using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class CarVM
    {
        public string Model { get; set; }

        public List<Color> Colors { get; set; }
    }

    public class Color 
    {
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
