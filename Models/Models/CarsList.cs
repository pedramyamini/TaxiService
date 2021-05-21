using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public static class CarsList
    {
        static string path = @"..\..\..\Models\Models\cars.json";
        private static string json = System.IO.File.ReadAllText(path);
        private static readonly List<CarVM> cars =
            JsonConvert.DeserializeObject<List<CarVM>>(json);
        public static List<CarVM> Cars
        {
            get
            {
                return cars;
            }
        }
    }
}
