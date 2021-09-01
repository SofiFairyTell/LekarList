using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Coelenterata : Animal
    {
        public string ReproductionType { get; set; }
        public Coelenterata(): base()
        {
            ReproductionType = "Половое";
        }
        public Coelenterata(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string RepType = "Половое"): base(name, latname, lifetime, pregnancy, progeny)
        {
            ReproductionType = RepType;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Coelenterata)
                    n++;
            }
            return n;
        }
    }
}
