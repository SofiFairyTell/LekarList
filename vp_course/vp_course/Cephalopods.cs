using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Cephalopods : Mollusca
    {
        private int _Tentacles;
        public int Tentacles
        {
            get
            {
                return _Tentacles;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Tentacles = value;
                }
            }
        }
        public Cephalopods() : base()
        {
            Tentacles = 8;
        }
        public Cephalopods(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, int atrianumb = 0, int tentacles = 0) : base(name, latname, lifetime, pregnancy, progeny, atrianumb)
        {
            Tentacles = tentacles;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Cephalopods)
                    n++;
            }
            return n;
        }
    }
}
