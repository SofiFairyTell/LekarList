using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Mollusca : Animal
    {
        private int _AtriaNumb;
        public int AtriaNumb
        {
            get
            {
                return _AtriaNumb;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _AtriaNumb = value;
                }
            }
        }
        public Mollusca() : base()
        {
            AtriaNumb = 0;
        }
        public Mollusca(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, int atrianumb = 0) : base(name, latname, lifetime, pregnancy, progeny)
        {
            AtriaNumb = atrianumb;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Mollusca)
                    n++;
            }
            return n;
        }
    }
}
