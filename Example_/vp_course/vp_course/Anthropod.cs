using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Anthropod : Animal
    {
        public string Wings { get; set; }
        public Anthropod() : base()
        {
            Wings = "Нет";
        }
        public Anthropod(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string wings = "") : base (name, latname, lifetime, pregnancy, progeny)
        {
            Wings = wings;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Anthropod)
                    n++;
            }
            return n;
        }
    }
}
