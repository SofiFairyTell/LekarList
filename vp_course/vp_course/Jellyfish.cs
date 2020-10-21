using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Jellyfish : Coelenterata
    {
        private double _TentacleLength;
        public double TentacleLength
        {
            get
            {
                return _TentacleLength;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _TentacleLength = value;
                }
            }
        }
        public Jellyfish() : base()
        {
            TentacleLength = 0;
        }
        public Jellyfish(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string RepType = "Половое", double tentaclelength = 0) : base(name, latname, lifetime, pregnancy, progeny, RepType)
        {
            TentacleLength = tentaclelength;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Jellyfish)
                    n++;
            }
            return n;
        }
    }
}
