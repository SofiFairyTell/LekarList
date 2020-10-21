using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Spiders : Anthropod
    {
        private double _Eyes;
        public double Eyes
        {
            get
            {
                return _Eyes;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Eyes = value;
                }
            }
        }
        public Spiders() : base()
        {
            Eyes = 0;
        }
        public Spiders(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string wings = "", double eyes = 0) : base(name, latname, lifetime, pregnancy, progeny,wings)
        {
            Eyes = eyes;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Spiders)
                    n++;
            }
            return n;
        }
    }
}
