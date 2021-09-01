using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Corals : Coelenterata
    {
        public string Color { get; set; }
        public Corals() : base()
        {
            Color = "Желтый";
        }
        public Corals(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string RepType = "Половое", string color = "") : base(name, latname, lifetime, pregnancy, progeny, RepType)
        {
            Color = color;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Corals)
                    n++;
            }
            return n;
        }
    }
}
