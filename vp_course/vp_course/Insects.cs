﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public class Insects : Anthropod
    {
        private double _Facets;
        public double Facets
        {
            get
            {
                return _Facets;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Facets = value;
                }
            }
        }
        public Insects() : base()
        {
            Facets = 0;
        }
        public Insects(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0, string wings = "", double facets = 0) : base(name, latname, lifetime, pregnancy, progeny,wings)
        {
            Facets = facets;
        }
        public static new int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Insects)
                    n++;
            }
            return n;
        }
    }
}
