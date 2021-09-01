using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Crustaceans : Anthropod
    {
        private double _Segments;
        public double Segments
        {
            get
            {
                return _Segments;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Segments = value;
                }
            }
        }
        public Crustaceans() : base()
        {
            Segments = 0;
        }
        public Crustaceans(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string wings = "", double segments = 0) : base(name, latname, lifetime, pregnancy, progeny, wings)
        {
            Segments = segments;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Crustaceans)
                    n++;
            }
            return n;
        }
    }
}
