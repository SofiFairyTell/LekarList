using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Birds : Vertebrates
    {
        private double _WingsSize;
        public double WingsSize
        {
            get
            {
                return _WingsSize;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _WingsSize = value;
                }
            }
        }
        public Birds() : base()
        {
            WingsSize = 1;
        }
        public Birds(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string skull = "", string respiratorysystem = "", double wingssize = 0) : base(name, latname, lifetime, pregnancy, progeny, skull, respiratorysystem)
        {
            WingsSize = wingssize;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Birds)
                    n++;
            }
            return n;
        }
    }
}
