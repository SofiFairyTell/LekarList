using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Starfish : Echinoderm
    {
        public string StarSize { get; set; }
        public Starfish() : base()
        {
            StarSize = "20 на 20";
        }
        public Starfish(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, int raysnumb = 0, string starsize = "") : base(name, latname, lifetime, pregnancy, progeny, raysnumb)
        {
            StarSize = starsize;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Starfish)
                    n++;
            }
            return n;
        }
    }
}
