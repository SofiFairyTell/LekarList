using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_course
{
    public abstract class Animal : IComparable<Animal>
    {
        public string Name { get; set; }
        public string LatName { get; set; }
        private int _Lifetime;
        public int Lifetime
        {
            get 
            { 
                return _Lifetime; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Lifetime = value;
                }
            }
        }
        private int _Pregnancy;

        public int Pregnancy
        {
            get
            {
                return _Pregnancy;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Pregnancy = value;
                }
            }
        }
        private int _Progeny;

        public int Progeny
        {
            get
            {
                return _Progeny;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _Progeny = value;
                }
            }
        }
        public Animal()
        {
            Name = "";
            LatName = "";
            Lifetime = 0;
            Pregnancy = 0;
            Progeny = 0;
        }
        public Animal(string name, string latname, int lifetime = 0, int pregnancy = 0, int progeny = 0)
        {
            Name = name;
            LatName = latname;
            Lifetime = lifetime;
            Pregnancy = pregnancy;
            Progeny = progeny;
        }
        public static int count(List<Animal> animals)
        {
            int n = 0;
            foreach (var obj in animals)
            {
                if (obj is Animal)
                    n++;
            }
            return n;
        }
        public int CompareTo(Animal ComparedAnimal)
        {
            string name1 = this.Name;
            string name2 = ComparedAnimal.Name;
            int n = 0;
            if (name1.Length > name2.Length)
                n = name1.Length;
            else
                n = name2.Length;
            for (int i = 0; i<n; i++)
            {
                if (name1[i] > name2[i])
                    return 1;
                else if (name1[i] < name2[i])
                    return -1;
            }
            if (name1.Length < name2.Length)
                return 1;
            else if (name1.Length > name2.Length)
                return -1;
            else
                return 0;
        }
    }
}
