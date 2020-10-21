using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Vertebrates : Chordata
    {
        public string RespiratorySystem { get; set; }
        public Vertebrates() : base()
        {
            RespiratorySystem = "Лёгкие";
        }
        public Vertebrates(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string skull = "", string respiratorysystem = "") : base(name, latname, lifetime, pregnancy, progeny, skull)
        {
            RespiratorySystem = respiratorysystem;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Vertebrates)
                    n++;
            }
            return n;
        }
    }
}
