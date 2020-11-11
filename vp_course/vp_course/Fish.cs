using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Fish : Vertebrates
    {
        public string ScalesType { get; set; }
        public Fish() : base()
        {
            ScalesType = "Плакоидная";
        }
        public Fish(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string skull = "", string respiratorysystem = "", string scales = "") : base(name, latname, lifetime, pregnancy, progeny, skull, respiratorysystem)
        {
            ScalesType = scales;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Fish)
                    n++;
            }
            return n;
        }
    }
}
