using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Echinoderm : Animal
    {
        private int _RaysNumb;
        public int RaysNumb
        {
            get
            {
                return _RaysNumb;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _RaysNumb = value;
                }
            }
        }
        public Echinoderm() : base()
        {
            RaysNumb = 4;
        }
        public Echinoderm(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, int raysnumb = 0) : base(name, latname, lifetime, pregnancy, progeny)
        {
            RaysNumb = raysnumb;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Echinoderm)
                    n++;
            }
            return n;
        }
    }
}
