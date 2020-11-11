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
        public PharmaGroup()
        {
            PharmaSG = "";
            MedicName = "";
            Code = "";
            Level = 0;
            Index = 0;
        }
        public PharmaGroup(string PHSG,string CodeSG, int level, int index)
        {
            PharmaSG = PHSG;
            MedicName = PHSG;
            Code = CodeSG;
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
