using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Reptiles : Vertebrates
    {
        public string CoverType { get; set; }
        public Reptiles() : base()
        {
            CoverType = "Панцырь";
        }
        public Reptiles(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string skull = "", string respiratorysystem = "", string covertype = "") : base(name, latname, lifetime, pregnancy, progeny, skull, respiratorysystem)
        {
            CoverType = covertype;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Reptiles)
                    n++;
            }
            return n;
        }
    }
}