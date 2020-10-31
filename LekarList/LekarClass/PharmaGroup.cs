using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
    class PharmaGroup:Medication
    {
        private string AnatomMainGroup { get; set; }
        private string TherapSG { get; set; }
        private string PharmaSG { get; set; }

        public PharmaGroup(string ANMG, string THSG,string PHSG, int level, int index)
        {
            AnatomMainGroup = ANMG;
            TherapSG = THSG;
            PharmaSG = PHSG;
            MedicName = ANMG + THSG + PHSG;
            
            Level = level;
            Index = index;
        }

        public static new int Count(List<Medication> MedicGroups)
        {
            int n = 0;
            foreach (var obj in MedicGroups)
            {
                if (obj is PharmaGroup)
                    n++;
            }
            return n;
        }
    }
}
