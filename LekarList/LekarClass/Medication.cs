using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
    public abstract class Medication: IComparable<Medication>
    {
        public string MedicName { get; set; }
        public int Level;
        public int Index;
        //public string ShowText;
        public int Child;
        public Medication()
        {
            MedicName = " ";
            Level = 0;
            Index = 0;
        }
        public Medication(string MedicNam, int level, int index)
        {
            MedicName = MedicNam;
            Level = level;
            Index = index;
        }
        public static int Count(List<Medication> MedicGroups)
        {
            int n = 0;
            foreach (var obj in MedicGroups)
            {
                if (obj is Medication)
                    n++;
            }
            return n;
        }
        public int CompareTo(Medication ComparedGroup)
        {
            string name1 = this.MedicName;
            string name2 = ComparedGroup.MedicName;
            int n = 0;
            if (name1.Length > name2.Length)
                n = name1.Length;
            else
                n = name2.Length;
            for (int i = 0; i < n; i++)
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
