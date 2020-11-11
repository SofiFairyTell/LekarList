using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Bivalvias : Mollusca
    {
        public string Pattern { get; set; }
        public Bivalvias() : base()
        {
            Pattern = "Спираль";
        }
        public Bivalvias(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, int atrianumb = 0, string pattern = "") : base(name, latname, lifetime, pregnancy, progeny, atrianumb)
        {
            Pattern = pattern;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Bivalvias)
                    n++;
            }
            return n;
        }
    }
}
