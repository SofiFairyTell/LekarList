using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Mammals : Vertebrates
    {
        public string WoolType { get; set; }
        public Mammals() : base()
        {
            WoolType = "Короткошерстный";
        }
        public Mammals(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string skull = "", string respiratorysystem = "", string wooltype = "") : base(name, latname, lifetime, pregnancy, progeny, skull, respiratorysystem)
        {
            WoolType = wooltype;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Mammals)
                    n++;
            }
            return n;
        }
    }
}
