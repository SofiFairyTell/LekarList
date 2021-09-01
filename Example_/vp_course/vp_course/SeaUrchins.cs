using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class SeaUrchins : Echinoderm
    {
        private double _RayLength;
        public double RayLength
        {
            get
            {
                return _RayLength;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _RayLength = value;
                }
            }
        }
        public SeaUrchins() : base()
        {
            RayLength = 1;
        }
        public SeaUrchins(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, int raysnumb = 0, double raylength = 0) : base(name, latname, lifetime, pregnancy, progeny, raysnumb)
        {
            RayLength = raylength;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is SeaUrchins)
                    n++;
            }
            return n;
        }
    }
}
