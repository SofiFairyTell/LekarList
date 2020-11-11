using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Chordata : Animal
    {
        public string Skull { get; set; }
        public Chordata() : base()
        {
            Skull = "Да";
        }
        public Chordata(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string skull = "") : base(name, latname, lifetime, pregnancy, progeny)
        {
            Skull = skull;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Chordata)
                    n++;
            }
            return n;
        }
    }
}
